using Application;
using Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NArchitecture.Core.CrossCuttingConcerns.Exception.WebApi.Extensions;
using NArchitecture.Core.CrossCuttingConcerns.Logging.Configurations;
using NArchitecture.Core.ElasticSearch.Models;
using NArchitecture.Core.Localization.WebApi;
using NArchitecture.Core.Mailing;
using NArchitecture.Core.Persistence.WebApi;
using NArchitecture.Core.Security.Encryption;
using NArchitecture.Core.Security.JWT;
using NArchitecture.Core.Security.WebApi.Swagger.Extensions;
using Persistence;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// 1) CORS policy — http://localhost:3000 ve ngrok-skip-browser-warning header’ını izin ver
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost3000", policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:5173", 
                "http://localhost:5174", 
                "http://localhost:3000",
                "http://localhost:4200"
            )
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    });
});

// 2) Controller & JSON ayarları
builder.Services.AddControllers(opts =>
    {
        opts.RespectBrowserAcceptHeader = false;
        opts.ReturnHttpNotAcceptable = true;
        opts.OutputFormatters.RemoveType<XmlDataContractSerializerOutputFormatter>();
    })
    .AddNewtonsoftJson(opts =>
    {
        opts.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        opts.SerializerSettings.Formatting = Formatting.Indented;
    })
    .ConfigureApiBehaviorOptions(opts =>
    {
        opts.SuppressConsumesConstraintForFormFileParameters = true;
        opts.SuppressMapClientErrors = false;
        opts.InvalidModelStateResponseFactory = ctx =>
        {
            var result = new BadRequestObjectResult(ctx.ModelState);
            result.ContentTypes.Add("application/json");
            return result;
        };
    });

// 3) JSON’ı zorunlu kıl
builder.Services.Configure<MvcOptions>(opts =>
{
    opts.Filters.Add(new ProducesAttribute("application/json"));
    opts.Filters.Add(new ConsumesAttribute("application/json"));
});

// 4) Uygulama servisleri
builder.Services.AddApplicationServices(
    mailSettings: builder.Configuration.GetSection("MailSettings").Get<MailSettings>()!,
    fileLogConfiguration: builder.Configuration.GetSection("SeriLogConfigurations:FileLogConfiguration").Get<FileLogConfiguration>()!,
    elasticSearchConfig: builder.Configuration.GetSection("ElasticSearchConfig").Get<ElasticSearchConfig>()!,
    tokenOptions: builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>()!
);
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddHttpContextAccessor();

// 5) JWT Authentication
var tokenOpts = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>()!;
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opts =>
    {
        opts.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = tokenOpts.Issuer,
            ValidAudience = tokenOpts.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOpts.SecurityKey)
        };
    });

builder.Services.AddDistributedMemoryCache();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
{
    s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header. Example: \"Authorization: Bearer <token>\""
    });
    s.OperationFilter<BearerSecurityRequirementOperationFilter>();
});

var app = builder.Build();

// 6) Middleware pipeline
app.UseRouting();

// 7) CORS’u burada uygula
app.UseCors("AllowLocalhost3000");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt => opt.DocExpansion(DocExpansion.None));
}

app.ConfigureCustomExceptionMiddleware();
app.UseDbMigrationApplier();

app.UseAuthentication();
app.UseAuthorization();

// 8) JSON content-type header ekle
app.Use(async (ctx, next) =>
{
    ctx.Response.OnStarting(() =>
    {
        if (!ctx.Response.Headers.ContainsKey("Content-Type"))
            ctx.Response.Headers["Content-Type"] = "application/json; charset=utf-8";
        return Task.CompletedTask;
    });
    await next();
});

app.UseResponseLocalization();
app.MapControllers();
app.Run();
