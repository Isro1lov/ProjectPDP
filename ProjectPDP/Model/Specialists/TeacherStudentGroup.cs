namespace ProjectPDP.Specialists;

public class TeacherStudentGroup : Person
{
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }

}
