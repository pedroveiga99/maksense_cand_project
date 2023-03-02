using ClassesLibrary;
using MedicalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAPI.Controllers;

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