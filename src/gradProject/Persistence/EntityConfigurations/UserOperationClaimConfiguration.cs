using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class UserOperationClaimConfiguration : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.ToTable("UserOperationClaims").HasKey(uoc => uoc.Id);

            builder.Property(uoc => uoc.Id).HasColumnName("Id").IsRequired();
            builder.Property(uoc => uoc.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(uoc => uoc.OperationClaimId).HasColumnName("OperationClaimId").IsRequired();
            builder.Property(uoc => uoc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(uoc => uoc.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(uoc => uoc.DeletedDate).HasColumnName("DeletedDate");

            builder.HasQueryFilter(uoc => !uoc.DeletedDate.HasValue);

            builder.HasOne(uoc => uoc.User)
                   .WithMany(u => u.UserOperationClaims)
                   .HasForeignKey(uoc => uoc.UserId);

            builder.HasOne(uoc => uoc.OperationClaim)
                   .WithMany()
                   .HasForeignKey(uoc => uoc.OperationClaimId);

            builder.HasData(GetSeeds());
        }

        private IEnumerable<UserOperationClaim> GetSeeds()
        {
            return new List<UserOperationClaim>
            {
                new UserOperationClaim // System Admin
                {
                    Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Benzersiz bir Guid
                    UserId = UserConfiguration.SystemAdminUserId,
                    OperationClaimId = OperationClaimConfiguration.SystemAdminId,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new UserOperationClaim // Student
                {
                    Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), // Benzersiz bir Guid
                    UserId = UserConfiguration.StudentUserId,
                    OperationClaimId = OperationClaimConfiguration.StudentId,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new UserOperationClaim // Student Affairs Staff
                {
                    Id = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), // Benzersiz bir Guid
                    UserId = UserConfiguration.StudentAffairsStaffUserId,
                    OperationClaimId = OperationClaimConfiguration.StudentAffairsStaffId,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new UserOperationClaim // Advisor
                {
                    Id = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), // Benzersiz bir Guid
                    UserId = UserConfiguration.AdvisorUserId,
                    OperationClaimId = OperationClaimConfiguration.AdvisorId,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new UserOperationClaim // Department Secretary
                {
                    Id = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), // Benzersiz bir Guid
                    UserId = UserConfiguration.DepartmentSecretaryUserId,
                    OperationClaimId = OperationClaimConfiguration.DepartmentSecretaryId,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new UserOperationClaim // Dean's Office Staff
                {
                    Id = new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), // Benzersiz bir Guid
                    UserId = UserConfiguration.DeansOfficeStaffUserId,
                    OperationClaimId = OperationClaimConfiguration.DeansOfficeStaffId,
                    CreatedDate = new DateTime(2024, 1, 1)
                }
            };
        }
    }
}