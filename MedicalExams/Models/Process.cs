using System.ComponentModel.DataAnnotations;

namespace MedicalExams.Models;

public class Process
{
    public int Id { get; set; }

    [Required]
    public Person Person { get; set; }

    [Required]
    [MinLength(1, ErrorMessage = "Must select at least one exam")]
    public List<Exam> Exams { get; set; }

    [Required]
    public DateTime ProcessDate { get; set; }
}