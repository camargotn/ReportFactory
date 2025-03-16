using Project.Application.BMF;
using Project.Application.Reports;
using Project.Communication;

namespace Project.Application;
public class ReportFactory : IReportFactory
{
    private readonly Dictionary<string, IReports> _reports;

    public ReportFactory(IEnumerable<IReports> reports)
    {
        _reports = reports.ToDictionary(report => report.GetType().Name.Replace("Report", ""), report => report);
    }

    public ReportResponse CreateReport(string reportName)
    {
        if (_reports.TryGetValue(reportName, out var report))
        {
            return report.GenerateReport();
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
