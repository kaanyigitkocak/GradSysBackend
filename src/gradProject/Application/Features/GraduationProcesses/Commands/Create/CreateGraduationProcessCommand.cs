using Application.Features.GraduationProcesses.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Features.GraduationProcesses.Commands.Create;

public class CreateGraduationProcessCommand : IRequest<CreatedGraduationProcessResponse>
{
    public Guid StudentUserId { get; set; }
    public string AcademicTerm { get; set; }
    public DateTime InitiationDate { get; set; }
    public GraduationProcessStatus Status { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public string? Notes { get; set; }
    public Guid? AdvisorUserId { get; set; }
    public DateTime? AdvisorReviewDate { get; set; }
    public Guid? DeptSecretaryUserId { get; set; }
    public DateTime? DeptSecretaryReviewDate { get; set; }
    public Guid? DeansOfficeUserId { get; set; }
    public DateTime? DeansOfficeReviewDate { get; set; }
    public Guid? StudentAffairsUserId { get; set; }
    public DateTime? StudentAffairsReviewDate { get; set; }

    public class CreateGraduationProcessCommandHandler : IRequestHandler<CreateGraduationProcessCommand, CreatedGraduationProcessResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGraduationProcessRepository _graduationProcessRepository;
        private readonly GraduationProcessBusinessRules _graduationProcessBusinessRules;

        public CreateGraduationProcessCommandHandler(IMapper mapper, IGraduationProcessRepository graduationProcessRepository,
                                         GraduationProcessBusinessRules graduationProcessBusinessRules)
        {
            _mapper = mapper;
            _graduationProcessRepository = graduationProcessRepository;
            _graduationProcessBusinessRules = graduationProcessBusinessRules;
        }

        public async Task<CreatedGraduationProcessResponse> Handle(CreateGraduationProcessCommand request, CancellationToken cancellationToken)
        {
            GraduationProcess graduationProcess = _mapper.Map<GraduationProcess>(request);

            await _graduationProcessRepository.AddAsync(graduationProcess);

            CreatedGraduationProcessResponse response = _mapper.Map<CreatedGraduationProcessResponse>(graduationProcess);
            return response;
        }
    }
}