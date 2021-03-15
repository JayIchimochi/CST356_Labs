public static class BusinessRules
{
    public static bool isSpecial(Student student) => 
        student.StudentId % 5 == 0;
}