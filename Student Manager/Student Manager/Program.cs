using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Student_Manager;
using Student_Manager.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton<IStudent, Student>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

public interface IStudent
{
    public static void addStudent(string name, int betyg) { }
    public static void removeStudent(string name) { }
    //string editStudent();
}  

public class Student : IStudent
{

    public required string Name { get; set; }
    public int Betyg { get; set; }

    List<Student> students = new List<Student> {
        new() { Name = "Arber", Betyg = 5},
        new() { Name = "Person", Betyg = 0},
    };
    public void addStudent(string name, int betyg) {
        students.Add(new Student() { Name = name, Betyg = betyg });
    }

    public void removeStudent(string name) {
        foreach (var student in students) {
            if (student.Name.Contains(name)) {
                students.Remove(student);
                break;
            }
        }
    }
}