using Model;
using ProjectPDP.Specialists;

namespace ProjectPDP;
public class Group : Person
{

    public List<TeacherStudentGroup> TeacherStudentGroups { get; set; } = new List<TeacherStudentGroup>();

    public List<Booking> Bookings { get; set; } = new List<Booking>();

    public List<Exam> ExamList { get; set; } = new List<Exam>();
}
