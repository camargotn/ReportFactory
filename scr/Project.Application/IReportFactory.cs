using Project.Communication;

namespace Project.Application;
public interface IReportFactory
{
    ReportResponse CreateReport(string reportName);
}
