namespace ProjectPDP.Specialists
{
    public class TeacherSpecialist : Person
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int SpecialistId { get; set; }
        public Specialist Specialist { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }


    }
}
