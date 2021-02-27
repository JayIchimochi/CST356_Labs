using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentID = 123423131,
                EmailAddress = "Jerry@gmail.com"
            },
            new Student {
                Id = 2,
                StudentID = 938456279,
                EmailAddress = "Mary@live.com"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor{
                Id = 1,
                FirstName = "John",
                MiddleInital = "H.",
                LastName = "Smith",
            },
            new Instructor{
                Id = 2,
                FirstName = "Laura",
                MiddleInital = "S.",
                LastName = "Tatter",
            },
            new Instructor{
                Id = 3,
                FirstName = "Issac",
                MiddleInital = "C.",
                LastName = "Clark",
            }
        };
    }
}