public class StudentService : IStudentService
{
    public required string Name { get; set; }
    public int Betyg { get; set; }

    public void addStudent(List<Student> students, string name, int betyg)
    {
        students.Add(new Student() { Name = name, Betyg = betyg });
    }

    public void removeStudent(List<Student> students, string name)
    {
        foreach (var student in students)
        {
            if (student.Name.Contains(name))
            {
                students.Remove(student);
                break;
            }
        }
    }
}
public class Student
{
  public string Name { get; set; }
  public int Betyg { get; set; }
}
