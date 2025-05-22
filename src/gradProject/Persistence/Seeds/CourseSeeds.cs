using Domain.Entities;
using Domain.Enums;
using Persistence.Seeds; // Assuming DepartmentSeeds is in this namespace or accessible
using System;
using System.Collections.Generic;

namespace Persistence.Seeds
{
    public static class CourseSeeds
    {
        // Guids from original template (if course code matches transcript)
        public static readonly Guid Math141Id = new("30000000-0000-0000-0000-000000000001");
        public static readonly Guid Phys121Id = new("30000000-0000-0000-0000-000000000002");
        public static readonly Guid Ceng111Id = new("30000000-0000-0000-0000-000000000003");
        public static readonly Guid Ceng113Id = new("30000000-0000-0000-0000-000000000004");
        public static readonly Guid Ceng115Id = new("30000000-0000-0000-0000-000000000005");
        public static readonly Guid Eng101Id = new("30000000-0000-0000-0000-000000000006");
        public static readonly Guid Math142Id = new("30000000-0000-0000-0000-000000000007");
        public static readonly Guid Phys122Id = new("30000000-0000-0000-0000-000000000008");
        public static readonly Guid Math144Id = new("30000000-0000-0000-0000-000000000009");
        public static readonly Guid Ceng112Id = new("30000000-0000-0000-0000-000000000010");
        public static readonly Guid Eng102Id = new("30000000-0000-0000-0000-000000000012");
        public static readonly Guid Ceng211Id = new("30000000-0000-0000-0000-000000000014");
        public static readonly Guid Ceng213Id = new("30000000-0000-0000-0000-000000000015");
        public static readonly Guid Ceng215Id = new("30000000-0000-0000-0000-000000000016");
        public static readonly Guid Math255Id = new("30000000-0000-0000-0000-000000000017");
        public static readonly Guid Hist201Id = new("30000000-0000-0000-0000-000000000018");
        public static readonly Guid Turk201Id = new("30000000-0000-0000-0000-000000000019");
        public static readonly Guid Ceng212Id = new("30000000-0000-0000-0000-000000000022");
        public static readonly Guid Ceng214Id = new("30000000-0000-0000-0000-000000000023");
        public static readonly Guid Ceng218Id = new("30000000-0000-0000-0000-000000000025");
        public static readonly Guid Ceng222Id = new("30000000-0000-0000-0000-000000000026");
        public static readonly Guid Hist202Id = new("30000000-0000-0000-0000-000000000027");
        public static readonly Guid Turk202Id = new("30000000-0000-0000-0000-000000000028");
        public static readonly Guid Ceng311Id = new("30000000-0000-0000-0000-000000000031");
        public static readonly Guid Ceng315Id = new("30000000-0000-0000-0000-000000000032");
        public static readonly Guid Ceng312Id = new("30000000-0000-0000-0000-000000000033");
        public static readonly Guid Ceng316Id = new("30000000-0000-0000-0000-000000000034");
        public static readonly Guid Ceng318Id = new("30000000-0000-0000-0000-000000000035");
        public static readonly Guid Ceng322Id = new("30000000-0000-0000-0000-000000000036");
        public static readonly Guid Ceng411Id = new("30000000-0000-0000-0000-000000000037");
        public static readonly Guid Ceng415Id = new("30000000-0000-0000-0000-000000000038");
        public static readonly Guid Ceng416Id = new("30000000-0000-0000-0000-000000000039");
        public static readonly Guid Ceng391Id = new("30000000-0000-0000-0000-000000000050");
        public static readonly Guid Ceng431Id = new("30000000-0000-0000-0000-000000000053");
        public static readonly Guid Ceng463Id = new("30000000-0000-0000-0000-000000000068");
        public static readonly Guid Ceng464Id = new("30000000-0000-0000-0000-000000000069");
        public static readonly Guid Ceng465Id = new("30000000-0000-0000-0000-000000000070");
        public static readonly Guid Man216Id = new("30000000-0000-0000-0000-000000000137");


        // New Guids for courses in transcript but not in original template's specific Guids
        public static readonly Guid Econ205Id = new("40000000-0000-0000-0000-000000000001");
        public static readonly Guid Ceng323Id = new("40000000-0000-0000-0000-000000000002");
        public static readonly Guid Ceng246Id = new("40000000-0000-0000-0000-000000000003");
        public static readonly Guid Man223Id = new("40000000-0000-0000-0000-000000000004");
        public static readonly Guid Ceng400Id = new("40000000-0000-0000-0000-000000000005");
        public static readonly Guid Sprt211Id = new("40000000-0000-0000-0000-000000000006");
        public static readonly Guid Ceng418Id = new("40000000-0000-0000-0000-000000000007");
        public static readonly Guid Ceng424Id = new("40000000-0000-0000-0000-000000000008");
        public static readonly Guid Ceng506Id = new("40000000-0000-0000-0000-000000000009");


        public static IEnumerable<Course> GetSeeds()
        {
            return new List<Course>
            {
                // Courses from Transcript
                // 2021-2022 Öğrenim Öncesi Alınan Dersler + Güz + Bahar (Combined for simplicity)
                new Course { Id = Ceng111Id, CourseCode = "CENG111", CourseName = "BILGISAYAR MUHENDISLIGI KAVRAMLARI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 4, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng112Id, CourseCode = "CENG112", CourseName = "VERI YAPILARI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 7, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng113Id, CourseCode = "CENG113", CourseName = "PROGRAMLAMAYA GIRIS", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 4, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Eng101Id, CourseCode = "ENG101", CourseName = "INGILIZCE OKUMA VE YAZMA BECERILERI I", DepartmentId = DepartmentSeeds.ForeignLanguagesId, Ects = 4, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Eng102Id, CourseCode = "ENG102", CourseName = "INGILIZCE OKUMA VE YAZMA BECERILERI II", DepartmentId = DepartmentSeeds.ForeignLanguagesId, Ects = 4, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Math141Id, CourseCode = "MATH141", CourseName = "TEMEL ANALIZ I", DepartmentId = DepartmentSeeds.MathematicsId, Ects = 7, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Math142Id, CourseCode = "MATH142", CourseName = "TEMEL ANALİZ II", DepartmentId = DepartmentSeeds.MathematicsId, Ects = 7, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Math144Id, CourseCode = "MATH144", CourseName = "SONLU MATEMATIK", DepartmentId = DepartmentSeeds.MathematicsId, Ects = 5, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Phys121Id, CourseCode = "PHYS121", CourseName = "GENEL FIZIK I", DepartmentId = DepartmentSeeds.PhysicsId, Ects = 6, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Phys122Id, CourseCode = "PHYS122", CourseName = "GENEL FIZIK II", DepartmentId = DepartmentSeeds.PhysicsId, Ects = 6, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Turk201Id, CourseCode = "TURK201", CourseName = "TÜRK DİLİ DERSLERİ I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 2, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Turk202Id, CourseCode = "TURK202", CourseName = "TÜRK DİLİ DERSLERİ II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 2, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                
                new Course { Id = Ceng211Id, CourseCode = "CENG211", CourseName = "PROGRAMLAMANIN TEMELLERI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 6, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng213Id, CourseCode = "CENG213", CourseName = "ISLEM TEORISI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 6, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now }, // Taken twice
                new Course { Id = Ceng215Id, CourseCode = "CENG215", CourseName = "DEVRELER VE ELEKTRONIK", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 7, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Econ205Id, CourseCode = "ECON205", CourseName = "EKONOMININ PRENSIPLERI", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Math255Id, CourseCode = "MATH255", CourseName = "DIFERANSIYEL DENKLEMLER", DepartmentId = DepartmentSeeds.MathematicsId, Ects = 6, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Hist201Id, CourseCode = "HIST201", CourseName = "ATATÜRK İLKELERİ VE İNKILAP TARİHİ I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 2, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Man216Id, CourseCode = "MAN216", CourseName = "PAZARLAMAYA GIRIS", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 5, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now }, // ECTS from curriculum, transcript missing it for this entry
                
                new Course { Id = Ceng212Id, CourseCode = "CENG212", CourseName = "PROGRAMLAMA DILLERI KAVRAMI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng214Id, CourseCode = "CENG214", CourseName = "MANTIK TASARIMI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 7, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng246Id, CourseCode = "CENG246", CourseName = "SAYISAL HESAPLAMA", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now }, // Student took CENG246
                new Course { Id = Ceng218Id, CourseCode = "CENG218", CourseName = "ALGORITMALARIN ANALİZ VE TASARIMI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 6, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now }, // Taken twice
                new Course { Id = Ceng222Id, CourseCode = "CENG222", CourseName = "OLASILIK VE İSTATİSTİK", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Hist202Id, CourseCode = "HIST202", CourseName = "ATATÜRK İLKELERİ VE İNKILAP TARİHİ II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 2, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },

                // 2022-2023 Güz
                new Course { Id = Ceng115Id, CourseCode = "CENG115", CourseName = "AYRIK YAPILAR", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now }, // Taken twice
                new Course { Id = Ceng311Id, CourseCode = "CENG311", CourseName = "BILGISAYAR MIMARISI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 8, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng315Id, CourseCode = "CENG315", CourseName = "BİLGİ YÖNETIMI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 7, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng323Id, CourseCode = "CENG323", CourseName = "PROJE YÖNETİMİ", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 8, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng391Id, CourseCode = "CENG391", CourseName = "IMGE ANLAMAYA GİRİŞ", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },

                // 2022-2023 Bahar
                new Course { Id = Ceng312Id, CourseCode = "CENG312", CourseName = "BİLGİSAYAR AĞLARI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 7, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng316Id, CourseCode = "CENG316", CourseName = "YAZILIM MUHENDISLIGI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 8, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng318Id, CourseCode = "CENG318", CourseName = "INSAN BİLGİSAYAR ETKİLEŞİMİ", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng322Id, CourseCode = "CENG322", CourseName = "İŞLETİM SİSTEMLERİ", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 8, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng431Id, CourseCode = "CENG431", CourseName = "YAZILIM SİSTEMLERİ GELİŞTİRİLMESİ", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man223Id, CourseCode = "MAN223", CourseName = "YARATICI PROJE YAZIMI VE SUNUMU", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },

                // 2023-2024 Güz
                new Course { Id = Ceng400Id, CourseCode = "CENG400", CourseName = "YAZ STAJI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 4, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng411Id, CourseCode = "CENG411", CourseName = "BİLGİSAYAR MÜHENDİSLİĞİNDE PROFESYONELLİK", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 4, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng415Id, CourseCode = "CENG415", CourseName = "LISANS TEZİ VE SEMİNER I", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 9, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Sprt211Id, CourseCode = "SPRT211", CourseName = "SU ÜSTÜ SÖRF SPORLARI", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 5, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng465Id, CourseCode = "CENG465", CourseName = "VERİ YOĞUN SİSTEMLERİN İLKELERI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng463Id, CourseCode = "CENG463", CourseName = "YAPAY ÖĞRENMEYE GİRİS", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                
                // 2023-2024 Bahar
                new Course { Id = Ceng416Id, CourseCode = "CENG416", CourseName = "LISANS TEZİ VE SEMİNER II", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 9, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng418Id, CourseCode = "CENG418", CourseName = "BİLGİ GÜVENLİĞİ", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 6, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng424Id, CourseCode = "CENG424", CourseName = "GÖMÜLÜ BİLGİSAYAR SİSTEMLERI", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 7, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng506Id, CourseCode = "CENG506", CourseName = "DERİN ÖĞRENME", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 9, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng464Id, CourseCode = "CENG464", CourseName = "METİN MADENCİLİĞİNE GİRİŞ", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
            };
        }
    }
}