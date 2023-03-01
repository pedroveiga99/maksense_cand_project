using System.ComponentModel.DataAnnotations;

namespace MedicalExams.Models;

public class Exam
{
    public static Exam Exam1 = new(1, "Exam 1");
    public static Exam Exam2 = new(2, "Exam 2");
    public static Exam Exam3 = new(3, "Exam 3");
    public static Exam Exam4 = new(4, "Exam 4");
    public static Exam Exam5 = new(5, "Exam 5");

    public static List<Exam> PossibleExams = new List<Exam>
    {
        Exam1,
        Exam2,
        Exam3,
        Exam4,
        Exam5
    };


    [Required]
    public int Id { get;}
    
    [Required]
    public string? Name { get;}

    private Exam(int id, string name) 
    {
        this.Id = id;
        this.Name = name;
    }

    public Exam() { }
}