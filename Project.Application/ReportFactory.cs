using Project.Application.BMF;
using Project.Communication;

namespace Project.Application;
public class ReportFactory : IReportFactory
{
    public ReportResponse CreateReport(ReportRequest request)
    {
        if (request.ReportName == "BMF")
        {
            return new ReportBMF().GenerateReport();
        }
        else
        {
            return new ReportResponse
            {
                ReportName = "Unknown",
                ReportContent = "Unknown Report Content"
            };
        }
    }
}
