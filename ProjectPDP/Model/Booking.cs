using ProjectPDP;

namespace Model;

public class Booking : Person
{
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public DateTime start_on { get; set; }
    public DateTime end_on { get; set; }
}
