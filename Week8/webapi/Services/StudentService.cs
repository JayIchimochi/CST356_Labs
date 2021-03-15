using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _StudentRespository;

    public StudentService(IStudentRepository StudentRepository)
    {
        _StudentRespository = StudentRepository;
    }

    public List<StudentModel> GetAllStudents()
    {
        var StudentViewModels = new List<StudentModel>();

        foreach(var Student in _StudentRespository.GetAllStudents())
        {
            StudentViewModels.Add(new StudentModel {
                StudentId = Student.StudentId,
                Email = Student.address,
                Special = BusinessRules.isSpecial(Student)
            });
        }

        return StudentViewModels;
    }
}