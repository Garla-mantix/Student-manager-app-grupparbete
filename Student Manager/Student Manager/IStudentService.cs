public interface IStudentService
{
    void addStudent(List<Student> students, string Name, int Betyg);
    void removeStudent(List<Student> students, string Name);
    List<Student> sortByName(List<Student> students);
    List<Student> sortByBetyg(List<Student> students);

}