using MedicalAPI.Models;

namespace MedicalAPI.Services;

public static class ExamsServices
{
    static List<Exam> Exams = new List<Exam>();

    static ExamsServices()
    {
        Exams = new List<Exam>
        {
            new Exam
            {
                Id = 1,
                Name = "Exam 1"
            },
            new Exam
            {
                Id = 2,
                Name = "Exam 2"
            },
            new Exam
            {
                Id = 3,
                Name = "Exam 3"
            },
            new Exam
            {
                Id = 4,
                Name = "Exam 4"
            },
            new Exam
            {
                Id = 5,
                Name = "Exam 5"
            },
        };
    }

    public static void AddExam(Exam exam)
    {
        Exams.Add(exam);
    }

    public static void RemoveExam(int id)
    {
        int index = Exams.FindIndex(e => e.Id == id);
        if (index != -1)
        {
            Exams.RemoveAt(index);
        }
        // Do something if the exam is not found
    }


} 