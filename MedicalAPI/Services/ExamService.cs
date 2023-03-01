using MedicalAPI.Models;

namespace MedicalAPI.Services;

public static class ExamServices
{
    static List<Exam> Exams = new List<Exam>();

    static ExamServices()
    {
        Exams = Exam.PossibleExams;
    }

    public static List<Exam> GetAllExams()
    {
        return Exams;
    }

    public static Exam? GetExamById(int id)
    {
        return Exams.FirstOrDefault(e => e.Id == id);
    }


    // public static void AddExam(Exam exam)
    // {
    //     Exams.Add(exam);
    // }

    // public static void RemoveExam(int id)
    // {
    //     int index = Exams.FindIndex(e => e.Id == id);
    //     if (index != -1)
    //     {
    //         Exams.RemoveAt(index);
    //     }
    //     // Do something if the exam is not found
    // }


} 