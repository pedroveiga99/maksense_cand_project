using System.ComponentModel.DataAnnotations;

namespace ClassesLibrary;

public class Person
{    
    // [StringLength(9, MinimumLength = 9, ErrorMessage = "Número de Utente must have exactly 9 numbers")]
    [Required(ErrorMessage = "Necessita de colocar um número de utente")]
    [Range(100000000, 999999999, ErrorMessage = "Número de utente tem de ter exatamente 9 algarismos")]  // There should be a better way
    public int? NumUtente { get; set; }

    [Required(ErrorMessage = "Necessita de colocar um nome")]
    public string Name { get; set; }

    [Required]
    [DataType(DataType.Date)]  // Ensure that the date is in the correct format (yyyy-mm-dd)
    public DateTime BirthDate { get; set; }
}