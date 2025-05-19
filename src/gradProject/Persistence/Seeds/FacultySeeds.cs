using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Persistence.Seeds
{
    public static class FacultySeeds
    {
        // Sabit fakülte ID'leri
        public static readonly Guid EngineeringFacultyId = new("10000000-0000-0000-0000-000000000001");
        public static readonly Guid ScienceFacultyId = new("10000000-0000-0000-0000-000000000002");
        public static readonly Guid ArchitectureFacultyId = new("10000000-0000-0000-0000-000000000003");

        public static IEnumerable<Faculty> GetSeeds()
        {
            return new List<Faculty>
            {
                new Faculty
                {
                    Id = EngineeringFacultyId,
                    Name = "Faculty of Engineering",
                    CreatedDate = DateTime.Now
                },
                new Faculty
                {
                    Id = ScienceFacultyId,
                    Name = "Faculty of Science",
                    CreatedDate = DateTime.Now
                },
                new Faculty
                {
                    Id = ArchitectureFacultyId,
                    Name = "Faculty of Architecture",
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
} 