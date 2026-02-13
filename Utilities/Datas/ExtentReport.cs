using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;


public class ExtentManager
{
    private static ExtentReports _instance;
    private static readonly object _lock = new object();

    public static ExtentReports GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock) // thread safety
            {
                if (_instance == null)
                {
                    string reportPath = "D:\\ExtentReport\\1.html";
                    var htmlReporter = new ExtentSparkReporter(reportPath);


                    htmlReporter.Config.DocumentTitle = "Automation Test Report";
                    htmlReporter.Config.ReportName = "WorkFlow Test Report";


                    _instance = new ExtentReports();
                    _instance.AttachReporter(htmlReporter);
                }
            }
        }

        return _instance;
    }
}