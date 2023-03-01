using MedicalAPI.Models;

namespace MedicalAPI.Services;

public static class ExamsServices
{
    static List<Exam> Exams = new List<Exam>();

    static ExamsServices()
    {
        Exams = Exam.PossibleExams;
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