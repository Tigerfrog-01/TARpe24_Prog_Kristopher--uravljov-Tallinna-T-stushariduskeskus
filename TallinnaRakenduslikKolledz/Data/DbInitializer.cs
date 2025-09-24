using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Data
{
    public class DbInitializer
    {
        public static void Intialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any()) { return; }         
            var students = new Student[]
                {
                    new Student {FirstName = "George",LastName = "Teemus",EnrollmentDate = DateTime.Now     },
                    new Student {FirstName = "Napoleon",LastName = "Bonaparte",EnrollmentDate = DateTime.Now     },
                    new Student {FirstName = "Lennart",LastName = "Meri",EnrollmentDate = DateTime.Now     },
                    new Student {FirstName = "Alexander",LastName = "Great",EnrollmentDate = DateTime.Now     },
                    new Student {FirstName = "Friedrich",LastName = "Great",EnrollmentDate = DateTime.Now     },
                    new Student {FirstName = "Allahu",LastName = "Akhbar",EnrollmentDate = DateTime.Now     },
                    new Student {FirstName = "Kala",LastName = "Pulk",EnrollmentDate = DateTime.Now     },
                    new Student {FirstName = "Alfred",LastName = "Hiller",EnrollmentDate = DateTime.Now     }
                };
            context.Students.AddRange(students);
            context.SaveChanges();
            if (context.Courses.Any()) { return; }
            var courses = new Course[]
           {
               new Course {CourseID =1001, Title ="Progameerimise alused", Credits=3},
               new Course {CourseID =2002, Title ="Progameerimise 1", Credits=3},
               new Course {CourseID =3003, Title ="Progameerimise 2", Credits=3},
               new Course {CourseID =2003, Title ="Tarkvara Arendusprotsess", Credits=3},
               new Course {CourseID =1002, Title ="Multimeedia", Credits=3},
               new Course {CourseID =3001, Title ="Harjutusrakenduste alused", Credits=3},
                new Course {CourseID =9001, Title ="Cryptobro 101", Credits=0}

               };
            context.Courses.AddRange(courses);
            context.SaveChanges();
            if(context.Enrollments.Any()) { return; }
            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID =1,CourseID=3003,CurrentGrade=Grade.X},
                 new Enrollment{StudentID =1,CourseID=3001,CurrentGrade=Grade.A},
                   new Enrollment{StudentID =2,CourseID=1001,CurrentGrade=Grade.B},
                 new Enrollment{StudentID =2,CourseID=1002,CurrentGrade=Grade.D},
                  new Enrollment{StudentID =3,CourseID=1001,CurrentGrade=Grade.B},
                 new Enrollment{StudentID =3,CourseID=1002,CurrentGrade=Grade.X},
                  new Enrollment{StudentID =4,CourseID=1001,CurrentGrade=Grade.A},
                 new Enrollment{StudentID =4,CourseID=1002,CurrentGrade=Grade.C},
                    new Enrollment{StudentID =5,CourseID=1001,CurrentGrade=Grade.D},
                 new Enrollment{StudentID =5,CourseID=1002,CurrentGrade=Grade.A},
                    new Enrollment{StudentID =6,CourseID=1001,CurrentGrade=Grade.A},
                 new Enrollment{StudentID =6,CourseID=1002,CurrentGrade=Grade.A},
                    new Enrollment{StudentID =7,CourseID=1001,CurrentGrade=Grade.A},
                 new Enrollment{StudentID =7,CourseID=1002,CurrentGrade=Grade.F},
                    new Enrollment{StudentID =8,CourseID=1001,CurrentGrade=Grade.F},
                 new Enrollment{StudentID =8,CourseID=1002,CurrentGrade=Grade.A},

            };
            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
            if(context.Instructors.Any()) { return; }
            var instructors = new Instructor[]
            {
                new Instructor{FirstName="Alfred",LastName="Hiller",HireDate=DateTime.Now,Nationality="Jew"},
                new Instructor{FirstName="John",LastName="Smith",HireDate=DateTime.Now,Nationality="Arab"},
                new Instructor{FirstName="Adam",LastName="Date",HireDate=DateTime.Now,Nationality="American"},
            };
            context.Instructors.AddRange(instructors);
            context.SaveChanges();

                
        }
    }
}
