using System.Collections.Generic;
using System.Linq;
using Database;
using System;

public class StudentRepository : IStudentRepository
{
    private readonly dbContext _dbContext;

    public StudentRepository(dbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Student> GetAllStudents()
    {
        try
        {
            return _dbContext.Student.ToList();
        } 
        catch(Exception ex)
        {
            return new List<Student>();
        }
    }
}