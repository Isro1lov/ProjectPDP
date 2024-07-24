using System.Text.Json;

namespace ProjectPDP.Service;

public partial class SchoolService
{
    private List<Teacher> teachers = new List<Teacher>();

    string filePathTeachers = @"D:\\teachers.json";

    public class Car
    {
        int id;
    }

    private void LoadTeachersFromJson()
    {
        if (File.Exists(filePathTeachers))
        {
            string json = string.Empty;

            using (StreamReader streamReader = new StreamReader(filePathTeachers))
            {
                json = streamReader.ReadToEnd();
            }
            teachers = JsonSerializer.Deserialize<List<Teacher>>(json);
        }
        else
            teachers = new List<Teacher>();
    }

    private void SaveTeachersToJson()
    {
        string serialized = JsonSerializer.Serialize<List<Teacher>>(teachers);

        try
        {
            using (StreamWriter sw = new StreamWriter(filePathTeachers))
            {
                sw.WriteLine(serialized);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving teachers to JSON: {ex.Message}");
        }
    }

    public void AddTeacher(string name)
    {
        if (name.Length != 0)
        {
            int id = teachers.Count > 0 ? teachers.Max(t => t.Id) + 1 : 1;
            teachers.Add(new Teacher { Id = id, Name = name });
            Teacher teacher = new Teacher { Id = id, Name = name };
            SaveTeachersToJson();
            //string jsonPath = "D:\\teacher.json";
            //string serialezd = JsonSerializer.Serialize<List<Teacher>>(teachers);
            //using (StreamWriter writer = new StreamWriter(jsonPath))
            //{
            //    writer.WriteLine(serialezd);
            //}
            //using (StreamReader reader = new StreamReader(jsonPath))
            //{
            //    string json = reader.ReadToEnd();
            //}
            //List<Teacher> teachers = JsonSerializer.Deserialize<List<Teacher>>(jsonPath);
        }
        else
            Console.WriteLine("Name cannot be empty!");
    }

    public void UpdateTeacher(int id, string name)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == id);
        if (teacher != null)
        {
            teacher.Name = name;
            Console.WriteLine("Successiful updated.");
        }
        else
            Console.WriteLine("Teacher not found!");
    }

    public void DeleteTeacher(int d)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == d);
        if (teacher != null)
            teachers.Remove(teacher);
        else
            Console.WriteLine("Teacher not found!");
    }

    public void ListTeacher()
    {
        foreach (var teacher in teachers)
        {
            Console.WriteLine($" Teacher: {teacher.Id}, Name: {teacher.Name}");
        }
    }
}
