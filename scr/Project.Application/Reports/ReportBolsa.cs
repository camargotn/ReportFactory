using Project.Communication;

namespace Project.Application.Reports;
public class ReportBolsa : IReports
{
    public ReportResponse GenerateReport()
    {
        return new ReportResponse
        {
            ReportName = "Bolsa",
            ReportContent = "Bolsa Report Content"
        };
    }
}
