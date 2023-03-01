using MedicalAPI.Models;
using MedicalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ExamController : ControllerBase
{

    public ExamController(){}

    // Responds to GET requests to /Process
    [HttpGet]
    public ActionResult<List<Exam>> GetAll()
    {
        return ExamServices.GetAllExams();
    }
    
    // Responds to GET requests to /Process/{id}
    [HttpGet("{id}")]
    public ActionResult<Exam> Get(int id)
    {
        var exam = ExamServices.GetExamById(id);
        if (exam == null)
        {
            return NotFound();
        }
        return exam;
    }



}