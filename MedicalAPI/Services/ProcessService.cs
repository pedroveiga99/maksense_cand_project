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
                    NumUtente = 1,
                    Name = "John Doe",
                    BirthDate = new Date
                    {
                        day = 1,
                        month = 1,
                        year = 2000
                    }
                },
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
                    }
                },
                ProcessDate = new Date
                {
                    day = 1,
                    month = 1,
                    year = 2021
                }
            },
            new Process
            {
                Id = 2,
                Person = new Person
                {
                    NumUtente = 2,
                    Name = "Jane Doe",
                    BirthDate = new Date
                    {
                        day = 2,
                        month = 2,
                        year = 2000
                    }
                },
                Exams = new List<Exam>
                {
                    new Exam
                    {
                        Id = 3,
                        Name = "Exam 3"
                    },
                    new Exam
                    {
                        Id = 4,
                        Name = "Exam 4"
                    }
                },
                ProcessDate = new Date
                {
                    day = 2,
                    month = 2,
                    year = 2021
                }
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
        var index = Processes.FindIndex(p => p.Id == process.Id);
        if (index == -1)
        {
            return null;
        }

        Processes[index] = process;
        return process;
    }

    public static void DeleteProcess(int id)
    {
        var index = Processes.FindIndex(p => p.Id == id);
        if (index != -1)
        {
            Processes.RemoveAt(index);
        }
    }

    public static Exam AddExamToProcess(int processId, Exam exam)
    {
        var process = GetProcessById(processId);
        if (process == null)
        {
            return new Exam();
        }

        var nextId = process.Exams?.Count + 1 ?? 1;
        exam.Id = nextId;
        process.Exams?.Add(exam);
        return exam;
    }

    public static Exam? UpdateExamFromProcess(int processId, Exam exam)
    {
        var process = GetProcessById(processId);
        if (process == null)
        {
            return null;
        }

        var index = process.Exams?.FindIndex(e => e.Id == exam.Id) ?? -1;
        if (index == -1)
        {
            return null;
        }

        process.Exams[index] = exam;
        return exam;
    }

    public static void DeleteExamFromProcess(int processId, int examId)
    {
        var process = GetProcessById(processId);
        if (process == null)
        {
            return;
        }

        var index = process.Exams?.FindIndex(e => e.Id == examId) ?? -1;
        if (index != -1)
        {
            process.Exams?.RemoveAt(index);
        }
    }

}