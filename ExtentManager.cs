using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_MainFlow
{
    public class ExtentManager
    {
        private static ExtentReports extent;

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

                string reportPath = Path.Combine(
                    projectRoot,
                    "Reports",
                    "ExtentReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".html");

                Directory.CreateDirectory(Path.GetDirectoryName(reportPath));

                var spark = new ExtentSparkReporter(reportPath);

                extent = new ExtentReports();
                extent.AttachReporter(spark);

                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("Browser", "Chrome");
                extent.AddSystemInfo("Execution", "Jenkins/Local");
            }

            return extent;
        }
    }
}
