using MediatR;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.CourseTakens.Queries.GetStudentCourseIds;

public class GetStudentCourseIdsQuery : IRequest<GetStudentCourseIdsResponse>
{
    public class GetStudentCourseIdsQueryHandler : IRequestHandler<GetStudentCourseIdsQuery, GetStudentCourseIdsResponse>
    {
        public async Task<GetStudentCourseIdsResponse> Handle(GetStudentCourseIdsQuery request, CancellationToken cancellationToken)
        {
            // Select a random student (using StudentUser5 for this example)
            var selectedStudentUserId = UserSeeds.StudentUser5Id;
            // Student's taken courses based on the provided transcript
            var takenCourseIds = new List<Guid>
            {
                // 2021-2022 Fall Semester
                CourseSeeds.Ceng111Id, // BILGISAYAR MUHENDISLIGI KAVRAMLARI
                CourseSeeds.Ceng113Id, // PROGRAMLAMAYA GIRIS
                CourseSeeds.Eng101Id,  // INGILIZCE OKUMA VE YAZMA BECERILERII
                CourseSeeds.Math141Id, // TEMEL ANALIZI
                CourseSeeds.Phys121Id, // GENEL FIZIK I
                CourseSeeds.Turk201Id, // TÜRK DİLİ DERSLERİ 1
                CourseSeeds.Ceng211Id, // PROGRAMLAMANIN TEMELLERI
                CourseSeeds.Ceng213Id, // ISLEM TEORISI (Withdrawn, but retaken later)
                CourseSeeds.Ceng215Id, // DEVRELER VE ELEKTRONIK
                CourseSeeds.Econ205Id, // EKONOMININ PRENSIPLERI
                CourseSeeds.Math255Id, // DIFERANSIYEL DENKLEMLER
                CourseSeeds.Hist201Id, // ATATÜRK İLKELERİ VE İNKILAP TARİHİ
                CourseSeeds.Man216Id,  // PAZARLAMAYA GIRIS

                // 2021-2022 Spring Semester
                CourseSeeds.Ceng112Id, // VERI YAPILARI
                CourseSeeds.Eng102Id,  // INGILIZCE OKUMA VE YAZMA BECERILERI II
                CourseSeeds.Math142Id, // TEMEL ANALİZ 11
                CourseSeeds.Math144Id, // SONLU MATEMATIK
                CourseSeeds.Phys122Id, // GENEL FIZIK 11
                CourseSeeds.Turk202Id, // TÜRK DİLİ DERSLERİ II
                CourseSeeds.Ceng212Id, // PROGRAMLAMA DILLERI KAVRAMI
                CourseSeeds.Ceng214Id, // MANTIK TASARIMI
                CourseSeeds.Ceng246Id, // SAYISAL HESAPLAMA
                CourseSeeds.Ceng218Id, // ALGORITMALARIN ANALİZ VE TASARIMI
                CourseSeeds.Ceng222Id, // OLASILIK VE İSTATİSTİK
                CourseSeeds.Hist202Id, // ATATÜRK İLKELERİ VE İNKILAP TARİHİ

                // 2022-2023 Fall Semester
                CourseSeeds.Ceng115Id, // AYRIK YAPILAR (Withdrawn, but retaken later)
                CourseSeeds.Ceng311Id, // BILGISAYAR MIMARISI
                CourseSeeds.Ceng315Id, // BİLGİ YÖNETIMI
                CourseSeeds.Ceng323Id, // PROJE YÖNETİMİ
                CourseSeeds.Ceng391Id, // IMGE ANLAMAYA GİRİŞ

                // 2022-2023 Spring Semester
                CourseSeeds.Ceng312Id, // BİLGİSAYAR AĞLARI
                CourseSeeds.Ceng316Id, // YAZILIM MUHENDISLIGI
                CourseSeeds.Ceng318Id, // INSAN BİLGİSAYAR ETKİLEŞİMİ
                CourseSeeds.Ceng322Id, // İŞLETİM SİSTEMLERİ
                CourseSeeds.Ceng431Id, // YAZILIM SİSTEMLERİ GELİŞTİRİLMESİ
                CourseSeeds.Man223Id,  // YARATICI PROJE YAZIMI VE SUNUMU

                // 2023-2024 Fall Semester
                CourseSeeds.Ceng400Id, // YAZ STAJI
                CourseSeeds.Ceng411Id, // BİLGİSAYAR MÜHENDİSLİĞİNDE PROFESYONELLİK
                CourseSeeds.Ceng415Id, // LISANS TEZİ VE SEMİNERT
                CourseSeeds.Sprt211Id, // SU ÜSTÜ SÖRF SPORLARI
                CourseSeeds.Ceng465Id, // VERİ YOĞUN SİSTEMLERİN İLKELERI
                CourseSeeds.Ceng463Id, // YAPAY ÖĞRENMEYE GİRİS

                // 2023-2024 Spring Semester
                CourseSeeds.Ceng416Id, // LISANS TEZİ VE SEMİNER II
                CourseSeeds.Ceng418Id, // BİLGİ GÜVENLİĞİ
                CourseSeeds.Ceng424Id, // GÖMÜLÜ BİLGİSAYAR SİSTEMLERI
                CourseSeeds.Ceng506Id, // DERİN ÖĞRENME
                CourseSeeds.Ceng464Id  // METİN MADENCİLİĞİNE GİRİŞ
            };

            // Create CourseTaken records for the student
            var courseTakenRecords = CreateCourseTakenRecords(selectedStudentUserId, takenCourseIds);
            
            // Calculate GPA and ECTS
            var totalEcts = courseTakenRecords.Sum(ct => ct.CreditsEarned);
            var weightedGradePoints = courseTakenRecords.Sum(ct => GetGradePoints(ct.Grade) * ct.CreditsEarned);
            var calculatedGpa = totalEcts > 0 ? weightedGradePoints / totalEcts : 0;

            // Update Student information
            var updatedStudent = new Student(
                userId: selectedStudentUserId,
                studentNumber: "20240005",
                departmentId: DepartmentSeeds.ComputerEngineeringId,
                programName: "Computer Engineering Undergraduate Program",
                enrollDate: new DateTime(2021, 9, 1),
                graduationStatus: StudentGraduationStatus.ACTIVE,
                currentGpa: (decimal)calculatedGpa,
                currentEctsCompleted: totalEcts,
                assignedAdvisorUserId: UserSeeds.StaffUser1Id
            );

            // Create TranscriptData record
            var transcriptData = new TranscriptData
            {
                Id = Guid.NewGuid(),
                StudentUserId = selectedStudentUserId,
                ParsingDate = DateTime.Now,
                ParsedGpa = (decimal)calculatedGpa,
                ParsedEcts = totalEcts,
                IsValidForProcessing = true
            };

            return new GetStudentCourseIdsResponse
            {
                CourseIds = takenCourseIds,
                TotalCourseCount = takenCourseIds.Count,
                StudentUserId = selectedStudentUserId,
                CourseTakenRecords = courseTakenRecords,
                UpdatedStudent = updatedStudent,
                TranscriptData = transcriptData,
                CalculatedGpa = (decimal)calculatedGpa,
                TotalEctsCompleted = totalEcts
            };
        }

        private List<CourseTaken> CreateCourseTakenRecords(Guid studentUserId, List<Guid> courseIds)
        {
            var courseTakenRecords = new List<CourseTaken>();
            var courseData = GetCourseTranscriptData();
            
            foreach (var courseId in courseIds)
            {
                if (courseData.TryGetValue(courseId, out var data))
                {
                    courseTakenRecords.Add(new CourseTaken(
                        id: Guid.NewGuid(),
                        studentUserId: studentUserId,
                        courseCodeInTranscript: data.CourseCode,
                        courseNameInTranscript: data.CourseName,
                        grade: data.Grade,
                        semesterTaken: data.Semester,
                        creditsEarned: data.Credits,
                        isSuccessfullyCompleted: data.IsSuccessful,
                        matchedCourseId: courseId
                    ));
                }
            }
            
            return courseTakenRecords;
        }

        private Dictionary<Guid, (string CourseCode, string CourseName, string Grade, string Semester, int Credits, bool IsSuccessful)> GetCourseTranscriptData()
        {
            return new Dictionary<Guid, (string, string, string, string, int, bool)>
            {
                // 2021-2022 Fall Semester
                { CourseSeeds.Ceng111Id, ("CENG111", "BILGISAYAR MUHENDISLIGI KAVRAMLARI", "AA", "2021-2022 Fall", 5, true) },
                { CourseSeeds.Ceng113Id, ("CENG113", "PROGRAMLAMAYA GIRIS", "BA", "2021-2022 Fall", 6, true) },
                { CourseSeeds.Eng101Id, ("ENG101", "INGILIZCE OKUMA VE YAZMA BECERILERII", "BB", "2021-2022 Fall", 3, true) },
                { CourseSeeds.Math141Id, ("MATH141", "TEMEL ANALIZI", "BB", "2021-2022 Fall", 5, true) },
                { CourseSeeds.Phys121Id, ("PHYS121", "GENEL FIZIK I", "CB", "2021-2022 Fall", 7, true) },
                { CourseSeeds.Turk201Id, ("TURK201", "TÜRK DİLİ DERSLERİ 1", "AA", "2021-2022 Fall", 2, true) },
                { CourseSeeds.Ceng211Id, ("CENG211", "PROGRAMLAMANIN TEMELLERI", "BA", "2021-2022 Fall", 5, true) },
                { CourseSeeds.Ceng213Id, ("CENG213", "ISLEM TEORISI", "BB", "2022-2023 Fall", 5, true) }, // Retaken
                { CourseSeeds.Ceng215Id, ("CENG215", "DEVRELER VE ELEKTRONIK", "CC", "2021-2022 Fall", 6, true) },
                { CourseSeeds.Econ205Id, ("ECON205", "EKONOMININ PRENSIPLERI", "BB", "2021-2022 Fall", 3, true) },
                { CourseSeeds.Math255Id, ("MATH255", "DIFERANSIYEL DENKLEMLER", "CB", "2021-2022 Fall", 6, true) },
                { CourseSeeds.Hist201Id, ("HIST201", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ", "AA", "2021-2022 Fall", 2, true) },
                { CourseSeeds.Man216Id, ("MAN216", "PAZARLAMAYA GIRIS", "BA", "2021-2022 Fall", 3, true) },

                // 2021-2022 Spring Semester
                { CourseSeeds.Ceng112Id, ("CENG112", "VERI YAPILARI", "BB", "2021-2022 Spring", 5, true) },
                { CourseSeeds.Eng102Id, ("ENG102", "INGILIZCE OKUMA VE YAZMA BECERILERI II", "BA", "2021-2022 Spring", 3, true) },
                { CourseSeeds.Math142Id, ("MATH142", "TEMEL ANALİZ 11", "CB", "2021-2022 Spring", 6, true) },
                { CourseSeeds.Math144Id, ("MATH144", "SONLU MATEMATIK", "BB", "2021-2022 Spring", 5, true) },
                { CourseSeeds.Phys122Id, ("PHYS122", "GENEL FIZIK 11", "CC", "2021-2022 Spring", 8, true) },
                { CourseSeeds.Turk202Id, ("TURK202", "TÜRK DİLİ DERSLERİ II", "AA", "2021-2022 Spring", 2, true) },
                { CourseSeeds.Ceng212Id, ("CENG212", "PROGRAMLAMA DILLERI KAVRAMI", "BA", "2021-2022 Spring", 5, true) },
                { CourseSeeds.Ceng214Id, ("CENG214", "MANTIK TASARIMI", "BB", "2021-2022 Spring", 6, true) },
                { CourseSeeds.Ceng246Id, ("CENG246", "SAYISAL HESAPLAMA", "CB", "2021-2022 Spring", 5, true) },
                { CourseSeeds.Ceng218Id, ("CENG218", "ALGORITMALARIN ANALİZ VE TASARIMI", "BB", "2022-2023 Spring", 5, true) }, // Retaken
                { CourseSeeds.Ceng222Id, ("CENG222", "OLASILIK VE İSTATİSTİK", "BA", "2021-2022 Spring", 5, true) },
                { CourseSeeds.Hist202Id, ("HIST202", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ", "AA", "2021-2022 Spring", 2, true) },

                // 2022-2023 Fall Semester
                { CourseSeeds.Ceng115Id, ("CENG115", "AYRIK YAPILAR", "BB", "2023-2024 Fall", 5, true) }, // Retaken
                { CourseSeeds.Ceng311Id, ("CENG311", "BILGISAYAR MIMARISI", "BA", "2022-2023 Fall", 8, true) },
                { CourseSeeds.Ceng315Id, ("CENG315", "BİLGİ YÖNETIMI", "BB", "2022-2023 Fall", 6, true) },
                { CourseSeeds.Ceng323Id, ("CENG323", "PROJE YÖNETİMİ", "BA", "2022-2023 Fall", 3, true) },
                { CourseSeeds.Ceng391Id, ("CENG391", "IMGE ANLAMAYA GİRİŞ", "AA", "2022-2023 Fall", 3, true) },

                // 2022-2023 Spring Semester
                { CourseSeeds.Ceng312Id, ("CENG312", "BİLGİSAYAR AĞLARI", "BA", "2022-2023 Spring", 6, true) },
                { CourseSeeds.Ceng316Id, ("CENG316", "YAZILIM MUHENDISLIGI", "BB", "2022-2023 Spring", 6, true) },
                { CourseSeeds.Ceng318Id, ("CENG318", "INSAN BİLGİSAYAR ETKİLEŞİMİ", "CB", "2022-2023 Spring", 6, true) },
                { CourseSeeds.Ceng322Id, ("CENG322", "İŞLETİM SİSTEMLERİ", "BA", "2022-2023 Spring", 8, true) },
                { CourseSeeds.Ceng431Id, ("CENG431", "YAZILIM SİSTEMLERİ GELİŞTİRİLMESİ", "AA", "2022-2023 Spring", 3, true) },
                { CourseSeeds.Man223Id, ("MAN223", "YARATICI PROJE YAZIMI VE SUNUMU", "BA", "2022-2023 Spring", 3, true) },

                // 2023-2024 Fall Semester
                { CourseSeeds.Ceng400Id, ("CENG400", "YAZ STAJI", "P", "2023-2024 Fall", 0, true) }, // Pass/Fail
                { CourseSeeds.Ceng411Id, ("CENG411", "BİLGİSAYAR MÜHENDİSLİĞİNDE PROFESYONELLİK", "BA", "2023-2024 Fall", 6, true) },
                { CourseSeeds.Ceng415Id, ("CENG415", "LISANS TEZİ VE SEMİNERT", "AA", "2023-2024 Fall", 8, true) },
                { CourseSeeds.Sprt211Id, ("SPRT211", "SU ÜSTÜ SÖRF SPORLARI", "AA", "2023-2024 Fall", 3, true) },
                { CourseSeeds.Ceng465Id, ("CENG465", "VERİ YOĞUN SİSTEMLERİN İLKELERI", "BA", "2023-2024 Fall", 3, true) },
                { CourseSeeds.Ceng463Id, ("CENG463", "YAPAY ÖĞRENMEYE GİRİS", "AA", "2023-2024 Fall", 3, true) },

                // 2023-2024 Spring Semester
                { CourseSeeds.Ceng416Id, ("CENG416", "LISANS TEZİ VE SEMİNER II", "AA", "2023-2024 Spring", 8, true) },
                { CourseSeeds.Ceng418Id, ("CENG418", "BİLGİ GÜVENLİĞİ", "BA", "2023-2024 Spring", 3, true) },
                { CourseSeeds.Ceng424Id, ("CENG424", "GÖMÜLÜ BİLGİSAYAR SİSTEMLERI", "BB", "2023-2024 Spring", 3, true) },
                { CourseSeeds.Ceng506Id, ("CENG506", "DERİN ÖĞRENME", "AA", "2023-2024 Spring", 3, true) },
                { CourseSeeds.Ceng464Id, ("CENG464", "METİN MADENCİLİĞİNE GİRİŞ", "BA", "2023-2024 Spring", 3, true) }
            };
        }

        private double GetGradePoints(string grade)
        {
            return grade switch
            {
                "AA" => 4.0,
                "BA" => 3.5,
                "BB" => 3.0,
                "CB" => 2.5,
                "CC" => 2.0,
                "DC" => 1.5,
                "DD" => 1.0,
                "FD" => 0.5,
                "FF" => 0.0,
                "P" => 0.0, // Pass/Fail courses don't count towards GPA
                _ => 0.0
            };
        }
    }
} 