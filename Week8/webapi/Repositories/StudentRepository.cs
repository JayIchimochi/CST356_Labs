using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Database;
using System;

public class StudentRepository : IStudentRepository
{
    private readonly dbContext _dbContext;
    private readonly ILogger _logger;

    public StudentRepository(dbContext dbContext, ILoggerFactory loggerFactory)
    {
        _dbContext = dbContext;
        _logger = loggerFactory.CreateLogger("Controllers.StudentRepository");
    }

    public List<Student> GetAllStudents()
    {
        try
        {
            return _dbContext.Student.ToList();
        } 
        catch(Exception ex)
        {
            _logger.LogError("Failed to get Students.", ex);
            
            return new List<Student>();
        }
    }

    public Student GetStudentById(long StudentId)
    {
        return _dbContext.Student.SingleOrDefault(p => p.StudentId == StudentId);
    }

    public void AddStudent(Student Student)
    {
        _dbContext.Student.Add(Student);
        _dbContext.SaveChanges();
    }

    public void UpdateStudent(Student StudentUpdate)
    {
        var Student = GetStudentById(StudentUpdate.StudentId);

        if (Student != null)
        {
            Student.Name = StudentUpdate.Name;
            Student.Price = StudentUpdate.Price;
            Student.Count = StudentUpdate.Count;

            _dbContext.Update(Student);

            _dbContext.SaveChanges();
        }
    }

    public void DeleteStudent(long StudentId)
    {
        var Student = new Student { StudentId = StudentId };

        _dbContext.Student.Attach(Student);
        _dbContext.Student.Remove(Student);
        _dbContext.SaveChanges();
    }
}