using Project.Application.Reports;
using Project.Communication;

namespace Project.Application.BMF;
public class ReportBMF : IReports
{
    public ReportResponse GenerateReport()
    {
        return new ReportResponse
        {
            ReportName = "BMF",
            ReportContent = "BMF Report Content"
        };
    }
}
