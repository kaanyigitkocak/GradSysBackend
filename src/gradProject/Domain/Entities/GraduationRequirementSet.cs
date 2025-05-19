using NArchitecture.Core.Persistence.Repositories;
using System.Collections.Generic; // HashSet için eklendi

namespace Domain.Entities; // Namespace düzeltildi

public class GraduationRequirementSet : Entity<Guid> // requirementSetId olacak primary key
{
    // requirementSetId (Guid, Primary Key) -> Id
    public Guid DepartmentId { get; set; } // _fk kaldırıldı, PascalCase
    public decimal MinGpa { get; set; } // PascalCase
    public int TotalMinEcts { get; set; } // PascalCase
    public int? MinTechnicalElectiveCoursesCount { get; set; } // PascalCase
    public int? MinNonTechnicalElectiveCoursesCount { get; set; } // PascalCase
    public int? MinUniversityElectiveCoursesCount { get; set; } // PascalCase
    public string? Description { get; set; } // PascalCase
    public Guid CreatedByUserId { get; set; } // _fk kaldırıldı, PascalCase
    public Guid LastModifiedByUserId { get; set; } // _fk kaldırıldı, PascalCase
    public DateTime CreationDate { get; set; } // PascalCase
    public DateTime LastModificationDate { get; set; } // PascalCase

    // Navigation Properties
    public virtual Department Department { get; set; }
    public virtual User CreatedByUser { get; set; }
    public virtual User LastModifiedByUser { get; set; }
    public virtual ICollection<RequirementMandatoryCourse> MandatoryCourses { get; set; } = new HashSet<RequirementMandatoryCourse>();

    public GraduationRequirementSet() { }

    public GraduationRequirementSet(Guid id, Guid departmentId, decimal minGpa, int totalMinEcts, Guid createdByUserId, Guid lastModifiedByUserId, DateTime creationDate, DateTime lastModificationDate, int? minTech = null, int? minNonTech = null, int? minUniv = null, string? desc = null)
    {
        Id = id;
        DepartmentId = departmentId;
        MinGpa = minGpa;
        TotalMinEcts = totalMinEcts;
        MinTechnicalElectiveCoursesCount = minTech;
        MinNonTechnicalElectiveCoursesCount = minNonTech;
        MinUniversityElectiveCoursesCount = minUniv;
        Description = desc;
        CreatedByUserId = createdByUserId;
        LastModifiedByUserId = lastModifiedByUserId;
        CreationDate = creationDate;
        LastModificationDate = lastModificationDate;
        MandatoryCourses = new HashSet<RequirementMandatoryCourse>();
    }
} 