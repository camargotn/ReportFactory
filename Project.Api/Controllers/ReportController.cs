using Microsoft.AspNetCore.Mvc;
using Project.Application;
using Project.Communication;

namespace Project.Api.Controllers;
[Route("api/getReport")]
[ApiController]
public class ReportController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult GetAction([FromQuery] string reportName)
    {
        var reportRequest = new ReportRequest
        {
            ReportName = reportName
        };
        var reportFactory = new ReportFactory();
        var reportResponse = reportFactory.CreateReport(reportRequest);
        return Ok(reportResponse);
    }
}
