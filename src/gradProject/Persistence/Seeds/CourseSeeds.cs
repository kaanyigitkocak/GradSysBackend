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


        // Additional Missing Courses
        public static readonly Guid Econ205Id = new("30000000-0000-0000-0000-000000000158");
        public static readonly Guid Ceng246Id = new("30000000-0000-0000-0000-000000000159");
        public static readonly Guid Ceng323Id = new("30000000-0000-0000-0000-000000000160");
        public static readonly Guid Man223Id = new("30000000-0000-0000-0000-000000000161");
        public static readonly Guid Ceng400Id = new("30000000-0000-0000-0000-000000000162");
        public static readonly Guid Sprt211Id = new("30000000-0000-0000-0000-000000000163");
        public static readonly Guid Ceng418Id = new("30000000-0000-0000-0000-000000000164");
        public static readonly Guid Ceng424Id = new("30000000-0000-0000-0000-000000000165");
        public static readonly Guid Ceng506Id = new("30000000-0000-0000-0000-000000000166");

        // Additional Missing Courses
        public static readonly Guid Econ205Id = new("30000000-0000-0000-0000-000000000158");
        public static readonly Guid Ceng246Id = new("30000000-0000-0000-0000-000000000159");
        public static readonly Guid Ceng323Id = new("30000000-0000-0000-0000-000000000160");
        public static readonly Guid Man223Id = new("30000000-0000-0000-0000-000000000161");
        public static readonly Guid Ceng400Id = new("30000000-0000-0000-0000-000000000162");
        public static readonly Guid Sprt211Id = new("30000000-0000-0000-0000-000000000163");
        public static readonly Guid Ceng418Id = new("30000000-0000-0000-0000-000000000164");
        public static readonly Guid Ceng424Id = new("30000000-0000-0000-0000-000000000165");
        public static readonly Guid Ceng506Id = new("30000000-0000-0000-0000-000000000166");

        // Additional Missing Courses
        public static readonly Guid Econ205Id = new("30000000-0000-0000-0000-000000000158");
        public static readonly Guid Ceng246Id = new("30000000-0000-0000-0000-000000000159");
        public static readonly Guid Ceng323Id = new("30000000-0000-0000-0000-000000000160");
        public static readonly Guid Man223Id = new("30000000-0000-0000-0000-000000000161");
        public static readonly Guid Ceng400Id = new("30000000-0000-0000-0000-000000000162");
        public static readonly Guid Sprt211Id = new("30000000-0000-0000-0000-000000000163");
        public static readonly Guid Ceng418Id = new("30000000-0000-0000-0000-000000000164");
        public static readonly Guid Ceng424Id = new("30000000-0000-0000-0000-000000000165");
        public static readonly Guid Ceng506Id = new("30000000-0000-0000-0000-000000000166");

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

<<<<<<< Updated upstream
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
=======
                // Non-Technical Elective Courses
                new Course { Id = Art201Id, CourseCode = "ART 201", CourseName = "Drawing-Sketch", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art202Id, CourseCode = "ART 202", CourseName = "Painting", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art203Id, CourseCode = "ART 203", CourseName = "Sculpture", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art204Id, CourseCode = "ART 204", CourseName = "Artistic Ceramics", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art205Id, CourseCode = "ART 205", CourseName = "Color Photography", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art206Id, CourseCode = "ART 206", CourseName = "Introduction to Sound Production and Design", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art210Id, CourseCode = "ART 210", CourseName = "Western Music and Aesthetics", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art211Id, CourseCode = "ART 211", CourseName = "Music Workshop", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art212Id, CourseCode = "ART 212", CourseName = "Introduction to Harmony", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art230Id, CourseCode = "ART 230", CourseName = "Dance Education", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art231Id, CourseCode = "ART 231", CourseName = "Traditional Folk Dances I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Art232Id, CourseCode = "ART 232", CourseName = "Traditional Folk Dances II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Chn201Id, CourseCode = "CHN 201", CourseName = "Basic Chinese I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Fren201Id, CourseCode = "FREN 201", CourseName = "Basic French I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Fren202Id, CourseCode = "FREN 202", CourseName = "Basic French II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Fren203Id, CourseCode = "FREN 203", CourseName = "Intermediate French I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ger201Id, CourseCode = "GER 201", CourseName = "Basic German I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ger202Id, CourseCode = "GER 202", CourseName = "Basic German II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ger203Id, CourseCode = "GER 203", CourseName = "Intermediate German I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ger204Id, CourseCode = "GER 204", CourseName = "Intermediate German II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum203Id, CourseCode = "HUM 203", CourseName = "Introduction to Social Anthropology", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum205Id, CourseCode = "HUM 205", CourseName = "Current Issues in Turkish Language", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum206Id, CourseCode = "HUM 206", CourseName = "Comparative Cultures", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum207Id, CourseCode = "HUM 207", CourseName = "Ottoman History I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum208Id, CourseCode = "HUM 208", CourseName = "Ottoman History II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum211Id, CourseCode = "HUM 211", CourseName = "Introduction to Russian Culture", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum213Id, CourseCode = "HUM 213", CourseName = "History of Western Civilizations I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum214Id, CourseCode = "HUM 214", CourseName = "History of Western Civilizations II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum215Id, CourseCode = "HUM 215", CourseName = "Mythology", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum216Id, CourseCode = "HUM 216", CourseName = "Analysis of Folklore Texts", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum217Id, CourseCode = "HUM 217", CourseName = "Art History I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum218Id, CourseCode = "HUM 218", CourseName = "Art History II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum219Id, CourseCode = "HUM 219", CourseName = "Art History III", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum220Id, CourseCode = "HUM 220", CourseName = "Introduction to Japanese Culture", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum223Id, CourseCode = "HUM 223", CourseName = "Introduction to French Culture", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum226Id, CourseCode = "HUM 226", CourseName = "Textual Analysis of Contemporary Turkish Literature", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum227Id, CourseCode = "HUM 227", CourseName = "Turkish Language Reform", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum230Id, CourseCode = "HUM 230", CourseName = "Group Dynamics", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum231Id, CourseCode = "HUM 231", CourseName = "Sociology of Work", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum232Id, CourseCode = "HUM 232", CourseName = "Visual Communication Symbols in Art and Daily Life", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum233Id, CourseCode = "HUM 233", CourseName = "Visual Perception in Art", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum240Id, CourseCode = "HUM 240", CourseName = "Introduction to Spanish Culture", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum251Id, CourseCode = "HUM 251", CourseName = "Ottoman Turkish I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum252Id, CourseCode = "HUM 252", CourseName = "Ottoman Turkish II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum255Id, CourseCode = "HUM 255", CourseName = "Latin I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Hum256Id, CourseCode = "HUM 256", CourseName = "Latin II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Jap201Id, CourseCode = "JAP 201", CourseName = "Basic Japanese I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Jap202Id, CourseCode = "JAP 202", CourseName = "Basic Japanese II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Jap203Id, CourseCode = "JAP 203", CourseName = "Intermediate Japanese I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man203Id, CourseCode = "MAN 203", CourseName = "Project Management", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man205Id, CourseCode = "MAN 205", CourseName = "Innovation Management", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man206Id, CourseCode = "MAN 206", CourseName = "Businesses and Business Life", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man210Id, CourseCode = "MAN 210", CourseName = "Corporate Communication and Management Skills", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man211Id, CourseCode = "MAN 211", CourseName = "Communication and Management Skills for Engineers", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man215Id, CourseCode = "MAN 215", CourseName = "Engineering Economy", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man216Id, CourseCode = "MAN 216", CourseName = "Introduction to Marketing", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man217Id, CourseCode = "MAN 217", CourseName = "Fundamentals of Management", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man218Id, CourseCode = "MAN 218", CourseName = "Entrepreneurship", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man220Id, CourseCode = "MAN 220", CourseName = "Leadership", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man221Id, CourseCode = "MAN 221", CourseName = "Organizational and Personal Career Management", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man230Id, CourseCode = "MAN 230", CourseName = "Law in Business Life", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man231Id, CourseCode = "MAN 231", CourseName = "Intellectual and Industrial Property Law", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Rus201Id, CourseCode = "RUS 201", CourseName = "Basic Russian I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Rus202Id, CourseCode = "RUS 202", CourseName = "Basic Russian II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Rus203Id, CourseCode = "RUS 203", CourseName = "Intermediate Russian I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Rus204Id, CourseCode = "RUS 204", CourseName = "Intermediate Russian II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Rus205Id, CourseCode = "RUS 205", CourseName = "Advanced Russian I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Rus206Id, CourseCode = "RUS 206", CourseName = "Advanced Russian II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Span203Id, CourseCode = "SPAN 203", CourseName = "Intermediate Spanish I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Span204Id, CourseCode = "SPAN 204", CourseName = "Intermediate Spanish II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Sprt201Id, CourseCode = "SPRT 201", CourseName = "Tennis I", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Sprt202Id, CourseCode = "SPRT 202", CourseName = "Tennis II", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Sprt203Id, CourseCode = "SPRT 203", CourseName = "Badminton", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Sprt204Id, CourseCode = "SPRT 204", CourseName = "Basketball", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Sprt206Id, CourseCode = "SPRT 206", CourseName = "Table Tennis", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Sprt208Id, CourseCode = "SPRT 208", CourseName = "Basic Fitness Techniques", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },

                // Additional Missing Courses
                new Course { Id = Econ205Id, CourseCode = "ECON 205", CourseName = "Principles of Economics", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng246Id, CourseCode = "CENG 246", CourseName = "Numerical Computing", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 5, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Ceng323Id, CourseCode = "CENG 323", CourseName = "Project Management", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 3, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Man223Id, CourseCode = "MAN 223", CourseName = "Creative Project Writing and Presentation", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng400Id, CourseCode = "CENG 400", CourseName = "Summer Internship", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 0, CourseType = CourseType.MANDATORY, CreatedDate = DateTime.Now },
                new Course { Id = Sprt211Id, CourseCode = "SPRT 211", CourseName = "Water Surface Sports", DepartmentId = DepartmentSeeds.GeneralCultureCoursesId, Ects = 3, CourseType = CourseType.ELECTIVE_NON_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng418Id, CourseCode = "CENG 418", CourseName = "Information Security", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 3, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng424Id, CourseCode = "CENG 424", CourseName = "Embedded Computer Systems", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 3, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now },
                new Course { Id = Ceng506Id, CourseCode = "CENG 506", CourseName = "Deep Learning", DepartmentId = DepartmentSeeds.ComputerEngineeringId, Ects = 3, CourseType = CourseType.ELECTIVE_TECHNICAL, CreatedDate = DateTime.Now }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            };
        }
    }
}