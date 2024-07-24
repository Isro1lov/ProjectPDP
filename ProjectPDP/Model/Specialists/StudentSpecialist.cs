namespace ProjectPDP.Specialists
{
    public class StudentSpecialist : Person
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SpecialistId { get; set; }
        public Specialist Specialist { get; set; }


    }
}