using Model;

namespace ProjectPDP;
public class Room : Person
{
    public int Count { get; set; }
    public List<Booking> Bookings { get; set; } = new List<Booking>();
    public List<Exam> ExamList { get; set; } = new List<Exam>();
}
