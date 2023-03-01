using MedicalAPI.Models;

namespace MedicalAPI.Services;

public static class ProcessService
{
    static List<Process> Processes = new List<Process>();
    static int nextId = 3;
    static ProcessService()
    {
        Processes = new List<Process>
        {
            new Process
            {
                Id = 1,
                Person = new Person
                {
                    NumUtente = 123456789,
                    Name = "John Doe",
                    BirthDate = new DateTime(2000, 1, 1)
                },
                Exams = new List<Exam>
                {
                    Exam.Exam1,
                    Exam.Exam2
                },
                ProcessDate = new DateTime(2021, 1, 1)
            },
            new Process
            {
                Id = 2,
                Person = new Person
                {
                    NumUtente = 2,
                    Name = "Jane Doe",
                    BirthDate = new DateTime(2000, 2, 2)
                },
                Exams = new List<Exam>
                {
                    Exam.Exam3,
                    Exam.Exam4,
                },
                ProcessDate = new DateTime(2021, 2, 2)
            }
        };

    }

    public static List<Process> GetAllProcesses()
    {
        return Processes;
    }

    public static Process? GetProcessById(int id)
    {
        return Processes.FirstOrDefault(p => p.Id == id);
    }

    public static Process AddProcess(Process process)
    {
        process.Id = nextId++;
        Processes.Add(process);
        return process;
    }

    public static Process? UpdateProcess(Process process)
    {
        int index = Processes.FindIndex(p => p.Id == process.Id);
        if (index == -1)
        {
            return null;
        }

        Processes[index] = process;
        return process;
    }

    public static void DeleteProcess(int id)
    {
        int index = Processes.FindIndex(p => p.Id == id);
        if (index != -1)
        {
            Processes.RemoveAt(index);
        }
    }

    public static Exam AddExamToProcess(int processId, Exam exam)
    {
        Process? process = GetProcessById(processId);
        if (process == null)
        {
            return new Exam();
        }

        int nextId = process.Exams?.Count + 1 ?? 1;
        exam.Id = nextId;
        process.Exams?.Add(exam);
        return exam;
    }

    public static Exam? UpdateExamFromProcess(int processId, Exam exam)
    {
        Process? process = GetProcessById(processId);
        if (process == null)
        {
            return null;
        }

        int index = process.Exams?.FindIndex(e => e.Id == exam.Id) ?? -1;
        if (index == -1)
        {
            return null;
        }

        process.Exams[index] = exam;
        return exam;
    }

    public static void DeleteExamFromProcess(int processId, int examId)
    {
        Process? process = GetProcessById(processId);
        if (process == null)
        {
            return;
        }

        int index = process.Exams?.FindIndex(e => e.Id == examId) ?? -1;
        if (index != -1)
        {
            process.Exams?.RemoveAt(index);
        }
    }




}