namespace MedicalAPI.Models;

public class Process
{
    public int Id { get; set; }
    public Person? Person { get; set; }
    public List<Exam>? Exams { get; set; }
    public Date? ProcessDate { get; set; }
}