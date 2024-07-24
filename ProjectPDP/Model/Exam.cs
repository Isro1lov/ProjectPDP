using ProjectPDP;
using ProjectPDP.Enums;

namespace Model;
public class Exam : Person
{
    public List<Exam> ExamList { get; set; } = new List<Exam>();
    
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public DateTime Start_on { get; set; }
    public DateTime End_on { get; set; }
    public Weekday Day { get; set; }
}
