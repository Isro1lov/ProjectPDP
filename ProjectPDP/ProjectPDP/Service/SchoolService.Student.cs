using System.Text.Json;

namespace ProjectPDP.Service;

public partial class SchoolService
{
    private List<Student> students = new List<Student>();

    string filePathStudents = @"D:\\students.json";

    private void LoadStudentsFromJson()
    {
        if (File.Exists(filePathStudents))
        {
            string json = string.Empty;
            using (StreamReader sr = new StreamReader(filePathStudents))
            {
                json = sr.ReadToEnd();
            }
            students = JsonSerializer.Deserialize<List<Student>>(json);
        }
        else
            students = new List<Student>();
    }

    public void SaveToStudentJson()
    {
        string searilized = JsonSerializer.Serialize<List<Student>>(students);
        try
        {
            using (StreamWriter sw = new StreamWriter(filePathStudents))
            {
                sw.WriteLine(searilized);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving students to Json: {ex.Message}");
        }
    }

    public void AddStudent(string name)
    {
        if (name.Length != 0)
        {
            int id = students.Count > 0 ? students.Max(s => s.Id) + 1 : 1;
            students.Add(new Student { Id = id, Name = name });

        }
        else
            Console.WriteLine("Student name can not be empty");
        SaveToStudentJson();
    }

    public void UpdateStudent(int id, string name)
    {
        var student = students.FirstOrDefault(t => t.Id == id);
        if (student != null)
        {
            student.Name = name;
            Console.WriteLine("Successiful updated.");
        }
        else
            Console.WriteLine("Students not found!");
    }

    public void DeleteStudent(int d)
    {
        var student = students.FirstOrDefault(t => t.Id == d);
        if (student != null)
            students.Remove(student);
        else
            Console.WriteLine("Student not found!");
    }

    public void ListStudent()
    {
        foreach (var student in students)
        {
            Console.WriteLine($" Student: {student.Id}, Name: {student.Name}");
        }
    }
}
