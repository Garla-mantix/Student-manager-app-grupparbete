public interface IStudentService
{
    void addStudent(List<Student> students, string Name, int Betyg);
    void removeStudent(List<Student> students, string Name);
}