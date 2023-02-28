using System.ComponentModel.DataAnnotations;

namespace MedicalAPI.Models;

public class Person
{
    [Required]
    // [StringLength(9, MinimumLength = 9, ErrorMessage = "Número de Utente must have exactly 9 numbers")]
    public int NumUtente { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    [DataType(DataType.Date)]  // Ensure that the date is in the correct format (yyyy-mm-dd)
    public DateTime BirthDate { get; set; }
}