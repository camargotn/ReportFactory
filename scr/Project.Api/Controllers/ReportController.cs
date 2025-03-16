using Microsoft.AspNetCore.Mvc;
using Project.Application;
using Project.Communication;

namespace Project.Api.Controllers;
[Route("api/getReport")]
[ApiController]
public class ReportController : ControllerBase
{
    private readonly IReportFactory _reportFactory;

    public ReportController(IReportFactory reportFactory) => _reportFactory = reportFactory;

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult GetAction([FromQuery] string reportName)
    {
        var reportResponse = _reportFactory.CreateReport(reportName);

        return Ok(reportResponse);
    }
}
