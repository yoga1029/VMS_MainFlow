using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace VMS_MainFlow
{
    public class ExtentManager
    {
        private static ExtentReports extent;
        private static readonly object _lock = new object();

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                lock (_lock)
                {
                    if (extent == null)
                    {
                        string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

                        string reportPath = Path.Combine(
                            projectRoot,
                            "Reports",
                            "ExtentReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".html");

                        Directory.CreateDirectory(Path.GetDirectoryName(reportPath));

                        var htmlReporter = new ExtentSparkReporter(reportPath);

                        htmlReporter.Config.DocumentTitle = "Automation Test Report";
                        htmlReporter.Config.ReportName = "Workflow Test Report";

                        extent = new ExtentReports();
                        extent.AttachReporter(htmlReporter);
                    }
                }
            }
            return extent;
        }
    }
}