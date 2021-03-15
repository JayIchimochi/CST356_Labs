using System.Collections.Generic;

public interface IStudentRepository
{
    List<Student> GetAllStudents();
    Student GetStudentById(long StudentId);

    void AddStudent(Student Student);

    void UpdateStudent(Student Student);

    void DeleteStudent(long StudentId);
}