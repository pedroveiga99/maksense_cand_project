using System.ComponentModel.DataAnnotations;

namespace ClassesLibrary;

public class Exam
{
    public static Exam Exam1 = new(1, "Exam 1");
    public static Exam Exam2 = new(2, "Exam 2");
    public static Exam Exam3 = new(3, "Exam 3");
    public static Exam Exam4 = new(4, "Exam 4");
    public static Exam Exam5 = new(5, "Exam 5");
    public static Exam Exam6 = new(6, "Exam 6");
    public static Exam Exam7 = new(7, "Exam 7");
    public static Exam Exam8 = new(8, "Exam 8");
    public static Exam Exam9 = new(9, "Exam 9");


    public static List<Exam> PossibleExams = new List<Exam>
    {
        Exam1,
        Exam2,
        Exam3,
        Exam4,
        Exam5,
        Exam6,
        Exam7,
        Exam8,
        Exam9
    };


    [Required]
    public int Id { get; set; }  // Preferia que nao tivesse set; mas depois da problemas com o GET da API
    
    [Required]
    public string? Name { get; set; }  // Preferia que nao tivesse set; mas depois da problemas com o GET da API

    private Exam(int id, string name) 
    {
        this.Id = id;
        this.Name = name;
    }

    public Exam() { }
}