using System.Text.Json;

namespace ProjectPDP.Service;

public partial class SchoolService
{
    private List<Group> groups = new List<Group>();

    string FilePathGroups = @"D:\\groups.json";

    private void LoadGroupFromJson()
    {
        string json = string.Empty;
        if (File.Exists(FilePathGroups))
        {
            using (StreamReader sr = new StreamReader(FilePathGroups))
            {
                json = sr.ReadToEnd();
            }
            groups = JsonSerializer.Deserialize<List<Group>>(json);
        }
        else
        {
            groups = new List<Group>();
        }
    }

    private void SaveGroupToJson()
    {
        string searilized = JsonSerializer.Serialize(groups);
        using (StreamWriter sw = new StreamWriter(FilePathGroups))
        {
            sw.WriteLine(searilized);
        }
    }

    public void AddGroup(string name)
    {
        if (name.Length != 0)
        {
            int id = groups.Count > 0 ? groups.Max(s => s.Id) + 1 : 1;
            groups.Add(new Group { Id = id, Name = name });
        }
        else
            Console.WriteLine("Name cannot be empty!");
        SaveGroupToJson();
    }

    public void UpdateGroup(int id, string name)
    {
        var group = groups.FirstOrDefault(t => t.Id == id);
        if (group != null)
        {
            group.Name = name;
            Console.WriteLine("Successiful updated.");
        }
        else
            Console.WriteLine("Groups not found!");
    }

    public void DeleteGroup(int d)
    {
        var group = groups.FirstOrDefault(t => t.Id == d);
        if (group != null)
            groups.Remove(group);
        else
            Console.WriteLine("Group not found!");
    }

    public void ListGroup()
    {
        foreach (var group in groups)
        {
            Console.WriteLine($" Group: {group.Id}, Name: {group.Name}");
        }
    }
}
