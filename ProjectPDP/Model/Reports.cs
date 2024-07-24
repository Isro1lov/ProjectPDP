using ProjectPDP;

namespace Model;
public class Reports : Person
{
    public int TeacherId {  get; set; }
    public Teacher? Teacher;
}
