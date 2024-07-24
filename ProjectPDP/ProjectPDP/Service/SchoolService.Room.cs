using System.Text.Json;

namespace ProjectPDP.Service;

public partial class SchoolService
{
    private List<Room> rooms = new List<Room>();

    string FilePathRooms = @"D:\\rooms.json";

    private void LoadRoomFromJson()
    {
        if (File.Exists(FilePathRooms))
        {
            string json = string.Empty;
            using (StreamReader sr = new StreamReader(FilePathRooms))
            {
                json = sr.ReadToEnd();
            }
            rooms = JsonSerializer.Deserialize<List<Room>>(json);
        }
        else
            rooms = new List<Room>();
    }

    private void SaveRoomToJson()
    {
        string searilized = JsonSerializer.Serialize(rooms);
        using (StreamWriter sw = new StreamWriter(FilePathRooms))
        {
            sw.WriteLine(searilized);
        }
    }

    public void AddRoom(string name)
    {
        if (name.Length != 0)
        {
            int id = rooms.Count > 0 ? rooms.Max(s => s.Id) + 1 : 1;
            rooms.Add(new Room { Id = id, Name = name });
        }
        else
            Console.WriteLine("Room name can not be empty");
        SaveRoomToJson();
    }

    public void UpdateRoom(int id, string name)
    {
        var room = rooms.FirstOrDefault(t => t.Id == id);
        if (room != null)
        {
            room.Name = name;
            Console.WriteLine("Successiful updated.");
        }
        else
            Console.WriteLine("Room not found!");
    }

    public void DeleteRoom(int d)
    {
        var room = rooms.FirstOrDefault(t => t.Id == d);
        if (room != null)
            rooms.Remove(room);
        else
            Console.WriteLine("Room not found!");
    }

    public void ListRoom()
    {
        foreach (var room in rooms)
        {
            Console.WriteLine($" Room: {room.Id}, Name: {room.Name}");
        }
    }


}
