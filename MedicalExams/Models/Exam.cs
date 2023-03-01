using System.ComponentModel.DataAnnotations;

namespace MedicalExams.Models;

public class Exam
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
}