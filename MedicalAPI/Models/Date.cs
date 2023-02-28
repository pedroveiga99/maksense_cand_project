using System.ComponentModel.DataAnnotations;

namespace MedicalAPI.Models;

public class Date
{
    // Maybe validate if the day is valid for the month
    [Required]
    public int day { get; set; }

    [Required]
    [Range(0, 12, ErrorMessage = "Month must be between 1 and 12")]
    public int month { get; set; }

    [Required]
    public int year { get; set; }
    
}