using MedicalAPI.Models;
using MedicalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAPI.Controllers;

/*

To test the API, use the following commands:

- Não é necessário meter id no post, o id é gerado automaticamente
post -c "{"person":{"numUtente":3,"name":"John Smith","birthDate":"2000-03-03"},"exams":[{"id":3,"name":"Exam 3"},{"id":4,"name":"Exam 4"}],"processDate":"2021-03-03"}"

put 2 -c "{"Id":2,"Person":{"NumUtente":2,"Name":"New Jane Doe","BirthDate":{"day":2,"month":2,"year":2000}},"Exams":[{"Id":5,"Name":"Exam 5"},{"Id":4,"Name":"Exam 4"}],"ProcessDate":{"day":2,"month":2,"year":2021}}"

delete 3 



*/
[ApiController]
[Route("[controller]")]
public class ProcessController : ControllerBase
{
    public ProcessController()
    {
    }

    // Responds to GET requests to /Process
    [HttpGet]
    public ActionResult<List<Process>> GetAll()
    {
        return ProcessService.GetAllProcesses();
    }

    // Responds to GET requests to /Process/{id}
    [HttpGet("{id}")]
    public ActionResult<Process> Get(int id)
    {
        var process = ProcessService.GetProcessById(id);
        if (process == null)
        {
            return NotFound();
        }
        return process;
    }

    // Responds to POST requests to /Process
    [HttpPost]
    public IActionResult NewProcess(Process process)
    {
        ProcessService.AddProcess(process);
        return CreatedAtAction(nameof(NewProcess), new { id = process.Id }, process);
    }

    // Responds to PUT requests to /Process/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateProcess(int id, Process process)
    {
        if (id != process.Id)
        {
            return BadRequest();
        }

        var existingProcess = ProcessService.GetProcessById(id);
        if (existingProcess is null)
        {
            return NotFound();
        }

        ProcessService.UpdateProcess(process);
        return NoContent();
    }

    // Responds to DELETE requests to /Process/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteProcess(int id)
    {
        var process = ProcessService.GetProcessById(id);
        if (process == null)
        {
            return NotFound();
        }

        ProcessService.DeleteProcess(id);
        return NoContent();
    }



}