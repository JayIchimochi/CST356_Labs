using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 123423131,
                EmailAddress = "Jerry@gmail.com"
            },
            new Student {
                Id = 928394058,
                EmailAddress = "Mary@live.com"
            }
        };

        public static List<Instructor> instructors = new List<Instructor> {
            new Instructor{
                FirstName = "John",
                MiddleInital = "H.",
                LastName = "Smith",
            },
            new Instructor{
                FirstName = "Laura",
                MiddleInital = "S.",
                LastName = "Tatter",
            },
            new Instructor{
                FirstName = "Issac",
                MiddleInital = "C.",
                LastName = "Clark",
            }
        };
    }
}