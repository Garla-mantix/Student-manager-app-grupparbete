public class StudentService : IStudentService
{
    public required string Name { get; set; }
    public int Betyg { get; set; }

    List<Student> students = new List<Student> {
        new() { Name = "Arber", Betyg = 5},
        new() { Name = "Person", Betyg = 0},
    };
    public void addStudent(string name, int betyg)
    {
        students.Add(new Student() { Name = name, Betyg = betyg });
    }

    public void removeStudent(string name)
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
