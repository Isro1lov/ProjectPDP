using Model;
using ProjectPDP.Enums;
using ProjectPDP.Specialists;

namespace ProjectPDP;
public class Student : Person
{
    public Gender gender { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public List<StudentSpecialist> StudentSpecialists { get; set; } = new List<StudentSpecialist>();
    public List<TeacherStudentGroup> TeacherStudentGroups { get; set; } = new List<TeacherStudentGroup>();
    public List<Booking> Bookings { get; set; } = new List<Booking>();


}
