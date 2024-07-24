using System.Text.Json;

namespace ProjectPDP.Service;

public partial class SchoolService
{
    private List<Specialist> specialists = new List<Specialist>();

    string FilePathSpecialists = @"D:\\specialists.json";

    private void LoadSpecialistFromJson()
    {
        if (File.Exists(FilePathSpecialists))
        {
            string json = string.Empty;
            using (StreamReader reader = new StreamReader(FilePathSpecialists))
            {
                json = reader.ReadToEnd();
            }
            specialists = JsonSerializer.Deserialize<List<Specialist>>(json);
        }
        else
            specialists = new List<Specialist>();
    }

    private void SaveSpecialisttoJson()
    {
        string searilized = JsonSerializer.Serialize(specialists);
        using (StreamWriter writer = new StreamWriter(FilePathSpecialists))
        {
            writer.WriteLine(searilized);
        }
    }

    public void AddSpecialist(string name, string stack)
    {
        if (name.Length != 0)
        {
            if (stack.Length != 0)
            {
                var id = specialists.Count > 0 ? specialists.Max(t => t.Id) + 1 : 1;
                specialists.Add(new Specialist { Name = name, Id = id, Stack = stack });
            }
            else
                Console.WriteLine("Stack name cannot be empty!");
            SaveSpecialisttoJson();
        }
        else
            Console.WriteLine("Specialist name cannot be empty!");
    }

    public void UpdateSpecialist(int id, string name, string stack)
    {
        var specialist = specialists.FirstOrDefault(s => s.Id == id);
        if (specialist != null)
        {
            specialist.Name = name;
            specialist.Stack = stack;
            Console.WriteLine("Successiful updated.");
        }
        else
        {
            Console.WriteLine("Specialist not found!");
        }
    }

    public void DeleteSpecialist(int id)
    {
        var specialist = specialists.FirstOrDefault(s => s.Id == id);
        if (specialist != null)
            specialists.Remove(specialist);
        else
            Console.WriteLine("Specialist not found!");
    }

    public void ListSpecialists()
    {
        foreach (var specialist in specialists)
        {
            Console.WriteLine($" Specialist: {specialist.Id}, Name: {specialist.Name}, Stack: {specialist.Stack}");
        }
    }
}
