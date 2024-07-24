using ProjectPDP.Specialists;

namespace ProjectPDP;
public class Specialist : Person
{
    public string Stack {  get; set; }
    public List<TeacherSpecialist> TeacherSpecialists { get; set; } = new List<TeacherSpecialist>();
    public List<StudentSpecialist> StudentSpecialists { get; set;} = new List<StudentSpecialist>();
}
