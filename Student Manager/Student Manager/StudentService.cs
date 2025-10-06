using Student_Manager.Pages;

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
            if (student.Name.ToLower() == name.ToLower())
            {
                students.Remove(student);
                break;
            }
            else
            {
                // Plats att lägga ifall man vill varna användaren om att studenten inte finns
            }
        }
    }
    public List<Student> sortByName(List<Student> students)
    {
        students = students
            .OrderBy(student => student.Name)
            .ToList();
        return students;
    }
    public List<Student> sortByBetyg(List<Student> students)
    {
        students = students
            .OrderByDescending(student => student.Betyg)
            .ToList();
        return students;
    }
}
public class Student
{
  public string Name { get; set; }
  public int Betyg { get; set; }
}
