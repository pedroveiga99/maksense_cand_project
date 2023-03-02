using System.ComponentModel.DataAnnotations;

namespace ClassesLibrary;

public class Process
{
    public int Id { get; set; }

    [Required]
    [ValidateComplexType]  // It uses a experimental package (https://www.nuget.org/packages/Microsoft.AspNetCore.Components.DataAnnotations.Validation)
    public Person Person { get; set; }

    [Required]  // Será necessário? Já tem o MinLength...
    [MinLength(1, ErrorMessage = "Necessita de selecionar pelo menos um exame")]
    public List<Exam> Exams { get; set; }

    [Required]
    public DateTime ProcessDate { get; set; }
}