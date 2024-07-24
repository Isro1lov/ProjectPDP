using Model;
using ProjectPDP.Enums;
using ProjectPDP.Specialists;

namespace ProjectPDP;

public class Teacher : Person
{
    public Gender gender { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public List<TeacherSpecialist> TeacherSpecialists { get; set; } = new List<TeacherSpecialist>();
    public List<TeacherStudentGroup> TeacherStudentGroups { get; set; } = new List<TeacherStudentGroup>();
    public List<Booking> Bookings { get; set; } = new List<Booking>();
    public List<Exam> ExamList { get; set; } = new List<Exam>();

}
