using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Threading;
using VMS_MainFlow.Utilities.Datas;
using WindowsInput;
using WindowsInput.Native;

namespace VMS_MainFlow   //same namespace
{
    [TestClass]
    [DoNotParallelize]
    public class TestFlow
    {
        public static IWebDriver driver;
        public static bool previousStepFailed = false;

        private static ExtentReports extent;
        private static ExtentTest test;

        [ClassInitialize]
        public static void ClassSetup(TestContext context)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://cloud-test.vendolite.com/");
            extent = ExtentManager.GetInstance();
        }

        [TestMethod]
        [Priority(1)]
        public void Step1_Login()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Login Flow");

            try
            {
                new Login(driver).LoginFlow();
                test.Pass("Login successful");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }

        [TestMethod]
        [Priority(2)]
        public void Step2_AddBranch()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Add Branch Flow");

            try
            {
                new AddBranch(driver).AddBranchFlow();
                test.Pass("Branch completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }

        [TestMethod]
        [Priority(3)]
        public void Step3_AddClient()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Add Client Flow");

            try
            {
                new AddClient(driver).AddClientFlow();
                test.Pass("Client completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }

        [TestMethod]
        [Priority(4)]
        public void Step4_MachineMapping()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Machine Mapping Flow");

            try
            {
                new MachineMapping(driver).ClientMappingWithMachineFlow();
                test.Pass("Machine mapping completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }

        [TestMethod]
        [Priority(5)]
        public void Step5_AddBrand()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Add Brand Flow");

            try
            {
                new AddBrand(driver).AddBrandFlow();
                test.Pass("Brand completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }

        [TestMethod]
        [Priority(6)]
        public void Step6_AddCategory()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Add Category Flow");

            try
            {
                new AddCategory(driver).AddCategoryFlow();
                test.Pass("Category completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }



        [TestMethod]
        [Priority(7)]
        public void Step7_AddSubCategory()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Add SubCategory Flow");

            try
            {
                new AddSubCategory(driver).AddSubCategoryFlow();
                test.Pass("SubCategory completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }


        [TestMethod]
        [Priority(8)]
        public void Step8_AddProduct()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Add Product Flow");

            try
            {
                new AddProduct(driver).AddProductFlow();
                test.Pass("Product completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }

        [TestMethod]
        [Priority(9)]
        public void Step9_AddWarehouse()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Add Warehouse Flow");

            try
            {
                new AddWarehouse(driver).AddWarehouseFlow();
                test.Pass("Warehouse completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }

        [TestMethod]
        [Priority(10)]
        public void Step10_AddVendor()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Add Vendor Flow");

            try
            {
                new AddVendor(driver).AddVendorFlow();
                test.Pass("Vendor completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }



        [TestMethod]
        [Priority(11)]
        public void Step11_ProductMapping()
        {
            if (previousStepFailed)
                Assert.Inconclusive("Previous step failed");

            test = extent.CreateTest("Product Mapping Flow");

            try
            {
                new Productmapping(driver).ProductMappingFlow();
                test.Pass("Product Mapping completed");
            }
            catch (Exception ex)
            {
                test.Fail(ex);
                previousStepFailed = true;
                throw;
            }
        }


        //[Priority(12)]
        //public void Step12_AddPurchase()
        //{
        //    if (previousStepFailed)
        //        Assert.Inconclusive("Previous step failed");

        //    test = extent.CreateTest("Add Purchase Flow");

        //    try
        //    {
        //        new AddPurchase(driver).AddPurchaseFlow();
        //        test.Pass("Purchase completed");
        //    }
        //    catch (Exception ex)
        //    {
        //        test.Fail(ex);
        //        previousStepFailed = true;
        //        throw;
        //    }
        //}




        //[Priority(13)]
        //public void Step13_RaiseRefillRequest()
        //{
        //    if (previousStepFailed)
        //        Assert.Inconclusive("Previous step failed");

        //    test = extent.CreateTest("Raise Refill Request Flow");

        //    try
        //    {
        //        new RaiseRefillRequest(driver).RaiseRefillRequestFlow();
        //        test.Pass("Refill Request completed");
        //    }
        //    catch (Exception ex)
        //    {
        //        test.Fail(ex);
        //        previousStepFailed = true;
        //        throw;
        //    }
        //}



        //[Priority(14)]
        //public void Step14_ReturnRequest()
        //{
        //    if (previousStepFailed)
        //        Assert.Inconclusive("Previous step failed");

        //    test = extent.CreateTest("Return Request Flow");

        //    try
        //    {
        //        new ReturnRequest(driver).ReturnRequestFlow();
        //        test.Pass("Return Request completed");
        //    }
        //    catch (Exception ex)
        //    {
        //        test.Fail(ex);
        //        previousStepFailed = true;
        //        throw;
        //    }
        //}



        //[Priority(15)]
        //public void Step15_MachineScrapping()
        //{
        //    if (previousStepFailed)
        //        Assert.Inconclusive("Previous step failed");

        //    test = extent.CreateTest("Machine Scrapping Flow");

        //    try
        //    {
        //        new MachineScrapping(driver).MachineScrappingFlow();
        //        test.Pass("Machine scrapping completed");
        //    }
        //    catch (Exception ex)
        //    {
        //        test.Fail(ex);
        //        previousStepFailed = true;
        //        throw;
        //    }
        //}


        [ClassCleanup]
        public static void ClassCleanup()
        {
            extent.Flush();
            driver.Quit();
        }
    }




    // ================= LOGIN CLASS =================

    public class Login
    {
        private IWebDriver driver;
        private WebDriverWait wait;


        public Login(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
        }

        public void LoginFlow()
        {
            //login to portal
            IWebElement login = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("username")));
            login.SendKeys(LoginData.loginSuccess["username"]);

            IWebElement password = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            password.SendKeys(LoginData.loginSuccess["password"]);

            IWebElement loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.mat-raised-button")));
            loginButton.Click();
            Thread.Sleep(2000);
        }

    }
    // ================= BRANCH CLASS =================

    public class AddBranch
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AddBranch(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
        }

        public void AddBranchFlow()
        {
            try
            {

                Thread.Sleep(2000);
                //Locate Company Module
                IWebElement companyModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Company")));
                companyModule.Click();

                //Locate branch sub-module
                IWebElement branchListSubModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'Branch List')]")));
                branchListSubModule.Click();
                Thread.Sleep(2000);


                string searchName = AddBranchData.addBranchSuccess["searchName"];
                IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
                searchText.Clear();
                searchText.SendKeys(searchName + Keys.Enter);
                Thread.Sleep(3000);

                // Check if branch exists
                var rows = driver.FindElements(By.XPath("//table//tbody/tr"));
                if (rows.Count == 0)
                {
                    Console.WriteLine($"Branch '{searchName}' not found. Adding Branch");

                    // Navigate to add branch page
                    IWebElement addBranchButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
                    addBranchButton.Click();
                    Thread.Sleep(2000);

                    //Fill the input fields
                    IWebElement name = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name")));
                    name.SendKeys(AddBranchData.addBranchSuccess["name"]);

                    IWebElement location = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("location")));
                    location.SendKeys(AddBranchData.addBranchSuccess["location"]);

                    IWebElement code = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("code")));
                    code.SendKeys(AddBranchData.addBranchSuccess["code"]);

                    IWebElement email = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("email")));
                    email.SendKeys(AddBranchData.addBranchSuccess["email"]);

                    IWebElement contactDetails = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("contactDetails")));
                    contactDetails.SendKeys(AddBranchData.addBranchSuccess["contactDetails"]);

                    IWebElement gstNo = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("gstNo")));
                    gstNo.SendKeys(AddBranchData.addBranchSuccess["gstNo"]);

                    IWebElement address = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("address")));
                    address.SendKeys(AddBranchData.addBranchSuccess["address"]);

                    IWebElement companyName = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("companyName")));
                    companyName.SendKeys(AddBranchData.addBranchSuccess["companyName"]);

                    IWebElement companyContactNo = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("companyContactNo")));
                    companyContactNo.SendKeys(AddBranchData.addBranchSuccess["companyContactNo"]);

                    IWebElement companyEmail = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("companyEmail")));
                    companyEmail.SendKeys(AddBranchData.addBranchSuccess["companyEmail"]);

                    IWebElement companyAddress = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("companyAddress")));
                    companyAddress.SendKeys(AddBranchData.addBranchSuccess["companyAddress"]);
                    Thread.Sleep(3000);

                    // Upload Branch Image
                    IWebElement branchLogo = wait.Until(
                        ExpectedConditions.ElementExists(By.Id("fileUpload")));

                    string projectRoot = Directory.GetCurrentDirectory();
                    string fileName = AddBranchData.addBranchSuccess["fileUpload"];
                    string filePath = Path.Combine(projectRoot, "TestData", fileName);

                    branchLogo.SendKeys(filePath);

                    driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    Thread.Sleep(4000);

                    //// Upload Branch Image
                    //IWebElement branchLogo = wait.Until(ExpectedConditions.ElementExists(By.Id("fileUpload")));
                    //branchLogo.SendKeys(AddBranchData.addBranchSuccess["fileUpload"]);

                    //driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    //Thread.Sleep(4000); //Save button


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Assert.Fail(ex.Message);
            }
        }
    }
}


//////////////////////  ================= CLIENT CLASS =================  ///////////////////////////////////////////


public class AddClient
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public AddClient(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
    }

    public void AddClientFlow()
    {
        try
        {

            // Locate Company Module
            IWebElement companyModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Company")));
            companyModule.Click();

            // Fetching Client sub-menu
            IWebElement clientButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Company1")));
            clientButton.Click();
            Thread.Sleep(2000);

            for (int i = 0; i < AddClientData.Clients.GetLength(0); i++)
            {
                string searchName = AddClientData.Clients[i, 0];
                IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
                searchText.Clear();
                searchText.SendKeys(searchName + Keys.Enter);
                Thread.Sleep(2000);
                var rows = driver.FindElements(By.XPath("//table//tbody/tr"));

                // Check if client exists
                if (rows.Count == 0)
                {
                    Console.WriteLine($"Client '{searchName}' not found. Adding Client");

                    // Navigate to add client page
                    IWebElement addClientButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
                    addClientButton.Click();
                    Thread.Sleep(2000);

                    // Fill the input fields using 2D array
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name"))).SendKeys(AddClientData.Clients[i, 1]);

                    driver.FindElement(By.Name("branch")).Click();
                    string branchName = AddClientData.Clients[i, 2];
                    string dynamicXPath = $"//span[text()=' {branchName} ']";
                    driver.FindElement(By.XPath(dynamicXPath)).Click();
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("contactno"))).SendKeys(AddClientData.Clients[i, 3]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("email"))).SendKeys(AddClientData.Clients[i, 4]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("address"))).SendKeys(AddClientData.Clients[i, 5]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("gstNo"))).SendKeys(AddClientData.Clients[i, 6]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("companyName"))).SendKeys(AddClientData.Clients[i, 7]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("companyContactNo"))).SendKeys(AddClientData.Clients[i, 8]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("companyEmail"))).SendKeys(AddClientData.Clients[i, 9]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("companyAddress"))).SendKeys(AddClientData.Clients[i, 10]);
                    Thread.Sleep(2000);

                    // Save client
                    driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    Thread.Sleep(2000);

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Assert.Fail(ex.Message);
        }
    }
}





// ================= Machine Mapping CLASS =================

public class MachineMapping
{
    private IWebDriver driver;
    private WebDriverWait wait;
    public static string unmappedMachineForMapping;

    public MachineMapping(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
    }

    public void ClientMappingWithMachineFlow()
    {
        try
        {
            Thread.Sleep(4000);
            IWebElement machineMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines")));
            machineMenu.Click();
            Thread.Sleep(1000);

            //Fetching Machine List
            IWebElement machineList = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines0")));
            machineList.Click();
            Thread.Sleep(6000);

            // Get all rows 
            var machineRows = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("table tbody tr"))).ToList();
            Console.WriteLine("Total Machines Found: " + machineRows.Count);

            //store unmapped machines
            List<IWebElement> unmappedMachines = new List<IWebElement>();

            foreach (var row in machineRows)
            {
                var cells = row.FindElements(By.TagName("td"));
                string clientName = cells[2].Text.Trim();
                if (string.Equals(clientName, "N/A", StringComparison.OrdinalIgnoreCase))
                {
                    unmappedMachines.Add(row);
                }
            }
            Console.WriteLine("Unmapped Machines Count: " + unmappedMachines.Count);
            if (unmappedMachines.Count > 0)
            {
                var firstUnmappedRow = unmappedMachines.First();
                string firstUnmappedMachineId = firstUnmappedRow.FindElements(By.TagName("td"))[0].Text;
                Console.WriteLine("First Unmapped Machine Id: " + firstUnmappedMachineId);

                // Store for further mapping
                unmappedMachineForMapping = firstUnmappedMachineId;
            }
            else
            {
                Console.WriteLine("No unmapped machines found.");
            }
            // Navigate to Purchase Order menu
            IWebElement purchaseOrderButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'Purchase Order')]")));
            purchaseOrderButton.Click();
            Thread.Sleep(2000);
            // Navigate to Current Purchase Order submenu
            IWebElement currentPurchaseOrderMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'Current Purchase Order')]")));
            currentPurchaseOrderMenu.Click();
            Thread.Sleep(2000);

            // Navigate to Add Client Purchase Order page
            IWebElement addClientPurchaseOrderButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
            addClientPurchaseOrderButton.Click();

            // Bill Date
            IWebElement billDate = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("drange2")));
            billDate.Click();
            Thread.Sleep(1000);

            IWebElement yearControl = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='owl-dt-calendar-control']")));
            yearControl.Click();
            Thread.Sleep(1000);

            IWebElement yearToSelect = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[.//span[text()='2025']]")));
            yearToSelect.Click();
            Thread.Sleep(1000);

            IWebElement monthToSelect = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[.//span[text()='Sept']]")));
            monthToSelect.Click();
            Thread.Sleep(1000);

            IWebElement dayToSelect = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[.//span[text()='3']]")));
            dayToSelect.Click();
            Thread.Sleep(1000);

            IWebElement client = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("client")));
            client.Click();
            Thread.Sleep(1000);

            string clientName1 = AddClientPurchaseOrderData.addClientPurchaseOderSuccess["clientName"];
            string dynamicXPath = $"//span[text()=' {clientName1} ']";
            driver.FindElement(By.XPath(dynamicXPath)).Click();

            //IWebElement uploadBtn = driver.FindElement(By.XPath("//mat-icon[text()='cloud_upload']"));
            //uploadBtn.Click();
            //Thread.Sleep(2000);

            IWebElement fileInput = driver.FindElement(
                By.XPath("//input[@type='file']"));

            string projectRoot = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(projectRoot, "TestData", "PO-PDF.pdf");
            fileInput.SendKeys(filePath);

            //// Simulate typing file path + Enter
            //var sim = new InputSimulator();
            //sim.Keyboard.TextEntry(@"C:\Users\Yogeswari-PC\Downloads\PO-PDF.pdf");
            //sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            //Thread.Sleep(2000);

            // Expiry Date
            IWebElement billDateCalendarIcon = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("drange")));
            billDateCalendarIcon.Click();
            Thread.Sleep(1000);

            IWebElement yearControl1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='owl-dt-calendar-control']")));
            yearControl1.Click();
            Thread.Sleep(1000);

            IWebElement yearToSelect1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[.//span[text()='2035']]")));
            yearToSelect1.Click();
            Thread.Sleep(1000);

            IWebElement monthToSelect1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[.//span[text()='Sept']]")));
            monthToSelect1.Click();
            Thread.Sleep(1000);

            IWebElement dayToSelect1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[.//span[text()='2']]")));
            dayToSelect1.Click();
            Thread.Sleep(3000);

            //IWebElement selectMachine = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name = 'machineId']")));
            //selectMachine.Click();
            //Thread.Sleep(2000);

            //IWebElement selectMachineInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("machineId")));
            //selectMachineInput.SendKeys(unmappedMachineForMapping[0] + Keys.Enter);
            //selectMachineInput.Click();
            //Thread.Sleep(5000);


            IWebElement selectMachineInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("machineId")));
            selectMachineInput.Click();
            Thread.Sleep(1000);

            // Get all dropdown machine options
            var machineOptions = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("mat-option span")));

            // Compare stored unmapped machine with each dropdown option
            bool found = false;
            for (int i = 0; i < machineOptions.Count; i++)
            {
                string optionTexts = machineOptions[i].Text.Trim();
                if (optionTexts.Equals(unmappedMachineForMapping, StringComparison.OrdinalIgnoreCase))
                {
                    machineOptions[i].Click();
                    Console.WriteLine("Mapped machine is: " + optionTexts);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Stored unmapped machine not found in dropdown!");
            }


            IWebElement addBtn = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.mat-icon-button.mat-primary")));
            addBtn.Click();
            Thread.Sleep(2000);

            //// Click add button
            //IWebElement addBtn = driver.FindElement(By.CssSelector("button.mat-icon-button.mat-primary"));
            //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //    js.ExecuteScript("arguments[0].click();", addBtn);

            IWebElement save = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[.//span[normalize-space(text())='Save']]")));
            save.Click();
            Thread.Sleep(3000);

        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Assert.Fail(ex.Message);
        }
    }
}




////    /// /////////////////////////////////////// ADD BRAND ///////////////////////////////////////////////////////////////



public class AddBrand
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public AddBrand(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
    }

    public void AddBrandFlow()
    {
        try
        {
            Thread.Sleep(2000);
            //Locate Product Module
            IWebElement productModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'Products')]")));
            productModule.Click();

            //Locate brand sub-module
            IWebElement brandListSubModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),' Brand ')]")));
            brandListSubModule.Click();
            Thread.Sleep(4000);

            for (int i = 0; i < AddBrandData.Brands.GetLength(0); i++)
            {

                string searchName = AddBrandData.Brands[i, 0];
                IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
                searchText.Clear();
                searchText.SendKeys(searchName + Keys.Enter);
                Thread.Sleep(3000);

                // Check if brand exists
                var rows = driver.FindElements(By.XPath("//table//tbody/tr"));
                if (rows.Count == 0)
                {
                    Console.WriteLine($"Brand '{searchName}' not found. Adding brand");

                    // Click Add button
                    IWebElement addBrandButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
                    addBrandButton.Click();
                    Thread.Sleep(2000);

                    //Fill the input fields
                    IWebElement brandName = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name")));
                    brandName.SendKeys(AddBrandData.Brands[i, 1]);


                    driver.FindElement(By.Name("branch")).Click();
                    string branchName = AddBrandData.Brands[i, 2];
                    string dynamicXPath = $"//span[text()=' {branchName} ']";
                    driver.FindElement(By.XPath(dynamicXPath)).Click();

                    // Upload Brand Image
                    IWebElement imageUploadBtn = wait.Until(ExpectedConditions.ElementExists(By.Id("fileUpload")));
                    imageUploadBtn.SendKeys(AddBrandData.Brands[i, 3]);

                    driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine($"Brand '{searchName}' already exists.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Assert.Fail(ex.Message);
        }
    }
}





//    /// /////////////////////////////////////// ADD Category ///////////////////////////////////////////////////////////////


public class AddCategory
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public AddCategory(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
    }

    public void AddCategoryFlow()
    {

        try
        {
            Thread.Sleep(1000);
            //Locate Product Module
            IWebElement productModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'Products')]")));
            productModule.Click();

            //Locate Category sub-module
            IWebElement categorySubModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),' Categories ')]")));
            categorySubModule.Click();
            Thread.Sleep(2000);


            for (int i = 0; i < AddCategoryData.Categories.GetLength(0); i++)
            {
                string searchName = AddCategoryData.Categories[i, 0];
                IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
                searchText.Clear();
                searchText.SendKeys(searchName + Keys.Enter);
                Thread.Sleep(3000);

                // Check if category exists
                var rows = driver.FindElements(By.XPath("//table//tbody/tr"));
                Thread.Sleep(1000);
                if (rows.Count == 0)
                {
                    Console.WriteLine($"Category '{searchName}' not found. Adding category");


                    // Navigate to add catgeory page
                    IWebElement addCategoryButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
                    addCategoryButton.Click();
                    Thread.Sleep(2000);

                    //Fill the input fields
                    IWebElement categoryName = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name")));
                    categoryName.SendKeys(AddCategoryData.Categories[i, 1]);

                    driver.FindElement(By.Name("branch")).Click();
                    string branchName = AddCategoryData.Categories[i, 2];
                    string dynamicBranchXPath = $"//span[text()=' {branchName} ']";
                    driver.FindElement(By.XPath(dynamicBranchXPath)).Click();

                    driver.FindElement(By.Name("brand")).Click();
                    string brandName = AddCategoryData.Categories[i, 3];
                    string dynamicBrandXPath = $"//span[text()=' {brandName} ']";
                    driver.FindElement(By.XPath(dynamicBrandXPath)).Click();


                    // Upload Category Image
                    IWebElement imageUploadBtn = wait.Until(ExpectedConditions.ElementExists(By.Id("fileUpload")));
                    imageUploadBtn.SendKeys(AddCategoryData.Categories[i, 4]);

                    driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    Thread.Sleep(3000);

                }
                else
                {
                    Console.WriteLine($"Category '{searchName}' already exists.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Assert.Fail(ex.Message);
        }
    }
}




/// /////////////////////////////////////// ADD PRODUCT ///////////////////////////////////////////////////////////////

public class AddSubCategory
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public AddSubCategory(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
    }

    public void AddSubCategoryFlow()
    {
        try
        {
            Thread.Sleep(1000);
            //Locate Product Module
            IWebElement productModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'Products')]")));
            productModule.Click();

            //Locate Subategory sub-module
            IWebElement subCategory = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),' Sub Categories ')]")));
            subCategory.Click();
            Thread.Sleep(3000);


            for (int i = 0; i < AddSubCategoryData.SubCategory.GetLength(0); i++)
            {
                string searchName = AddSubCategoryData.SubCategory[i, 0];
                IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
                searchText.Clear();
                searchText.SendKeys(searchName + Keys.Enter);
                Thread.Sleep(5000);
                var rows = driver.FindElements(By.XPath("//table//tbody/tr"));
                if (rows.Count == 0)
                {
                    Console.WriteLine($"Subcategory '{searchName}' not found. Adding Subcategory");


                    // Navigate to add subcatgeory page
                    IWebElement addSubCategoryButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
                    addSubCategoryButton.Click();
                    Thread.Sleep(2000);

                    // Fill the input fields using 2D array
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name"))).SendKeys(AddSubCategoryData.SubCategory[i, 1]);

                    driver.FindElement(By.Name("branch")).Click();
                    string branchName = AddSubCategoryData.SubCategory[i, 2];
                    string dynamicBranchXPath = $"//span[text()=' {branchName} ']";
                    driver.FindElement(By.XPath(dynamicBranchXPath)).Click();


                    driver.FindElement(By.Name("brand")).Click();
                    string brandName = AddSubCategoryData.SubCategory[i, 3];
                    string dynamicBrandXPath = $"//span[text()=' {brandName} ']";
                    driver.FindElement(By.XPath(dynamicBrandXPath)).Click();

                    driver.FindElement(By.Name("category")).Click();
                    string categoryName = AddSubCategoryData.SubCategory[i, 4];
                    string dynamicCategoryXPath = $"//span[text()=' {categoryName} ']";
                    driver.FindElement(By.XPath(dynamicCategoryXPath)).Click();

                    // Upload Category Image
                    IWebElement imageUploadBtn = wait.Until(ExpectedConditions.ElementExists(By.Id("fileUpload")));
                    imageUploadBtn.SendKeys(AddSubCategoryData.SubCategory[i, 5]);

                    ////Fill the input fields
                    //IWebElement brand = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("brand")));
                    //brand.Click();
                    //Thread.Sleep(1000);

                    //IWebElement chooseBrandName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text() = ' Chro ']")));
                    //chooseBrandName.Click();
                    //Thread.Sleep(1000);

                    driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine($"Subcategory '{searchName}' already exists.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Assert.Fail(ex.Message);
        }
    }
}



/// <summary>
/// /////////////////////////////////////// ADD PRODUCT ///////////////////////////////////////////////////////////////
/// </summary>


public class AddProduct
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public AddProduct(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
    }

    public void AddProductFlow()
    {

        try
        {
            Thread.Sleep(1000);
            //Locate Product Module
            IWebElement productModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'Products')]")));
            productModule.Click();

            //Locate ProductList sub-module
            IWebElement productList = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),' Product List ')]")));
            productList.Click();
            Thread.Sleep(2000);

            for (int i = 0; i < AddProductData.Products.GetLength(0); i++)
            {

                IWebElement branchFilter = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name = 'branch']")));
                branchFilter.Click();
                Thread.Sleep(2000);

                IWebElement selectBranch = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains (text(), ' Pudukkottai Branch ')]")));
                selectBranch.Click();
                Thread.Sleep(2000);

                string searchName = AddProductData.Products[i, 0];
                IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
                searchText.Clear();
                searchText.SendKeys(searchName + Keys.Enter);
                Thread.Sleep(3000);

                // Check if product exists
                var rows = driver.FindElements(By.XPath("//table//tbody/tr"));
                if (rows.Count == 0)
                {
                    Console.WriteLine($"Product '{searchName}' not found. Adding Product");

                    // Navigate to add product page
                    IWebElement addProductButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
                    addProductButton.Click();
                    Thread.Sleep(2000);

                    //Fill the input fields

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name"))).SendKeys(AddProductData.Products[i, 1]);
                    Thread.Sleep(2000);

                    //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[@placeholder = 'Branch'])[2]"))).Click();
                    //string branchName = AddProductData.Products[i, 2];
                    //string dynamicBranchXPath = $"//span[text()=' {branchName} ']";
                    //driver.FindElement(By.XPath(dynamicBranchXPath)).Click();

                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[@placeholder = 'Branch'])[2]"))).Click();
                    string branchName = AddProductData.Products[i, 2];
                    driver.FindElement(By.XPath($"//span[text()=' {branchName} ']")).Click();

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("brand"))).Click();
                    string brandName = AddProductData.Products[i, 3];
                    string dynamicBrandXPath = $"//span[text()=' {brandName} ']";
                    driver.FindElement(By.XPath(dynamicBrandXPath)).Click();

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("category"))).Click();
                    string categoryName = AddProductData.Products[i, 4];
                    string dynamicCategoryXPath = $"//span[text()=' {categoryName} ']";
                    driver.FindElement(By.XPath(dynamicCategoryXPath)).Click();

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("subcategory"))).Click();
                    string subcategoryName = AddProductData.Products[i, 5];
                    string dynamicSubcategoryXPath = $"//span[text()=' {subcategoryName} ']";
                    driver.FindElement(By.XPath(dynamicSubcategoryXPath)).Click();

                    IWebElement productId = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("customProductId")));
                    productId.SendKeys(AddProductData.Products[i, 6]);
                    Thread.Sleep(2000);

                    IWebElement hsnCode = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("hsnCode")));
                    hsnCode.SendKeys(AddProductData.Products[i, 7]);
                    Thread.Sleep(2000);

                    bool sp = true;
                    if (AddProductData.Products[i, 10] == "1")
                    {
                        IWebElement addGstCheckbox = wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='addGST']")));
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("arguments[0].click();", addGstCheckbox);
                        Thread.Sleep(1000);

                        sp = false;
                        IWebElement maximumRetailPrice = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("mrp")));
                        maximumRetailPrice.SendKeys(AddProductData.Products[i, 11]);
                        Thread.Sleep(2000);

                        IWebElement cgst = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("cgst")));
                        cgst.SendKeys(AddProductData.Products[i, 12]);
                        Thread.Sleep(2000);

                        IWebElement sgst = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("sgst")));
                        sgst.SendKeys(AddProductData.Products[i, 13]);
                        Thread.Sleep(2000);

                        IWebElement utgst = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("utgst")));
                        utgst.SendKeys(AddProductData.Products[i, 14]);
                        Thread.Sleep(1000);

                        IWebElement cess = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("cess")));
                        cess.SendKeys(AddProductData.Products[i, 15]);
                        Thread.Sleep(1000);

                        IWebElement costForState = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("sCost")));
                        costForState.SendKeys(AddProductData.Products[i, 16]);
                        Thread.Sleep(2000);

                        IWebElement costForUt = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("utCost")));
                        costForUt.SendKeys(AddProductData.Products[i, 17]);
                        Thread.Sleep(2000);

                        //Taxable price for state and ut will be automatically calculated 
                    }
                    if (sp)
                    {
                        IWebElement sellingPrice = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("cost")));
                        sellingPrice.SendKeys(AddProductData.Products[i, 8]);
                        Thread.Sleep(2000);
                    }

                    // Upload Product Image
                    IWebElement imageUploadBtn = wait.Until(ExpectedConditions.ElementExists(By.Id("fileUpload")));
                    imageUploadBtn.SendKeys(AddProductData.Products[i, 9]);


                    driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    Thread.Sleep(3000);

                    driver.FindElement(By.XPath("//button//span[contains(text(),'Cancel')]")).Click();
                    Thread.Sleep(3000);

                }
                else
                {
                    Console.WriteLine($"Product '{searchName}' already exists.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Assert.Fail(ex.Message);
        }
    }
}






///////////////////////////////////////ADD WAREHOUSE //////////////////////////////////////////////////////////////
public class AddWarehouse
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public AddWarehouse(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
    }

    public void AddWarehouseFlow()
    {
        try
        {
            //Locate Warehouse Module
            IWebElement warehouseModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Warehouse")));
            warehouseModule.Click();

            // Fetching Warehouse List sub-menu
            IWebElement warehouseList = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Warehouse0")));
            warehouseList.Click();
            Thread.Sleep(2000);

            for (int i = 0; i < AddWarehouseData.Warehouses.GetLength(0); i++)
            {

                IWebElement searchTypeButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//mat-select[@role = 'listbox'])[2]")));
                searchTypeButton.Click();
                Thread.Sleep(2000);

                IWebElement selectName = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains (text(), ' Name ')]")));
                selectName.Click();
                Thread.Sleep(2000);


                string searchName = AddWarehouseData.Warehouses[i, 0];
                IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
                searchText.Clear();
                searchText.SendKeys(searchName + Keys.Enter);
                Thread.Sleep(2000);

                var rowData = driver.FindElements(By.XPath("//table//tbody/tr"));    //fetching table data
                if (rowData.Count == 0)
                {
                    Console.WriteLine($"Warehouse '{searchName}' not found. Adding Warehouse");

                    // Navigate to add warehouse page
                    IWebElement addWarehouseButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
                    addWarehouseButton.Click();
                    Thread.Sleep(2000);

                    // Fill the input fields using 2D array
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name"))).SendKeys(AddWarehouseData.Warehouses[i, 1]);

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("lat"))).SendKeys(AddWarehouseData.Warehouses[i, 2]);

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("lon"))).SendKeys(AddWarehouseData.Warehouses[i, 3]);


                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("city"))).SendKeys(AddWarehouseData.Warehouses[i, 4]);

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("state"))).SendKeys(AddWarehouseData.Warehouses[i, 5]);

                    driver.FindElement(By.Name("branch")).Click();
                    string branchName = AddWarehouseData.Warehouses[i, 6];
                    string dynamicXPath = $"//span[text()=' {branchName} ']";
                    driver.FindElement(By.XPath(dynamicXPath)).Click();


                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("phoneNo"))).SendKeys(AddWarehouseData.Warehouses[i, 7]);
                    Thread.Sleep(1000);

                    // Click publish
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'publish')]"))).Click();

                    // Upload file directly
                    IWebElement fileInput = wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='file']")));

                    string projectRoot = Directory.GetCurrentDirectory();
                    string fileName = AddWarehouseData.Warehouses[i, 8];
                    string filePath = Path.Combine(projectRoot, "TestData", fileName);

                    Console.WriteLine("File path: " + filePath);
                    Console.WriteLine("Exists: " + File.Exists(filePath));

                    fileInput.SendKeys(filePath);

                    //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span [contains(text(),'publish' )]"))).Click();
                    //Thread.Sleep(1000);
                    //var sim = new InputSimulator();
                    //sim.Keyboard.TextEntry(AddWarehouseData.Warehouses[i, 8]);
                    //sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    //Thread.Sleep(1000);


                    driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine($"Warehouse '{searchName}' already exists.");
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Assert.Fail(ex.Message);
        }
    }
}




///////////////////////////////////////////// ADD VENDOR ////////////////////////////////////////////////////

public class AddVendor
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public AddVendor(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
    }

    public void AddVendorFlow()
    {

        try
        {
            //Locate Warehouse Module
            IWebElement warehouseModule = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Warehouse")));
            warehouseModule.Click();

            // Fetching Vendor List sub-menu
            IWebElement vendorList = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Warehouse1")));
            vendorList.Click();
            Thread.Sleep(2000);

            for (int i = 0; i < AddWarehouseData.Vendors.GetLength(0); i++)
            {
                IWebElement searchTypeButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//mat-select[@role = 'listbox'])[2]")));
                searchTypeButton.Click();
                Thread.Sleep(2000);

                IWebElement selectName = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains (text(), ' Name ')]")));
                selectName.Click();
                Thread.Sleep(2000);

                string searchName = AddWarehouseData.Vendors[i, 0];
                IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
                searchText.Clear();
                searchText.SendKeys(searchName + Keys.Enter);
                Thread.Sleep(2000);

                var rowData = driver.FindElements(By.XPath("//table//tbody/tr"));    //fetching table data
                if (rowData.Count == 0)
                {
                    Console.WriteLine($"Warehouse '{searchName}' not found. Adding Warehouse");

                    // Navigate to add warehouse page
                    IWebElement addVendorButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,'add_fab')]")));
                    addVendorButton.Click();
                    Thread.Sleep(2000);

                    // Fill the input fields using 2D array
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name"))).SendKeys(AddWarehouseData.Vendors[i, 1]);

                    driver.FindElement(By.Name("branch")).Click();
                    string branchName = AddWarehouseData.Vendors[i, 2];
                    string dynamicXPath = $"//span[text()=' {branchName} ']";
                    driver.FindElement(By.XPath(dynamicXPath)).Click();

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("email"))).SendKeys(AddWarehouseData.Vendors[i, 3]);


                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("mobile"))).SendKeys(AddWarehouseData.Vendors[i, 4]);

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("contactPersonName"))).SendKeys(AddWarehouseData.Vendors[i, 5]);

                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("contactPersonEmail"))).SendKeys(AddWarehouseData.Vendors[i, 6]);


                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name("contactPersonMobile"))).SendKeys(AddWarehouseData.Vendors[i, 7]);
                    Thread.Sleep(1000);

                    driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
                    Thread.Sleep(2000);

                }
                else
                {
                    Console.WriteLine($"Vendor '{searchName}' already exists.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Assert.Fail(ex.Message);
        }
    }
}




/// ///////////////////////////////////////PRODUCT MAPPING ///////////////////////////////////////////////////////


public class Productmapping
{
    private IWebDriver driver;
    private WebDriverWait wait;
    static ITakesScreenshot screenshotDriver;

    public Productmapping(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
    }

    public void ProductMappingFlow()
    {
        try
        {
            //Fetching Machine menu
            IWebElement machineMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines")));
            machineMenu.Click();

            // Fetching Machine List
            IWebElement machineList = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines0")));
            machineList.Click();
            Thread.Sleep(1000);

            string machineId = MachineMapping.unmappedMachineForMapping;
            Console.WriteLine("Selecting machine: " + machineId);

            IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
            searchText.Clear();
            searchText.SendKeys(machineId + Keys.Enter);
            Thread.Sleep(3000);

            // Action Button 
            IWebElement actionButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".mat-focus-indicator.mat-menu-trigger.mat-icon-button.mat-button-base")));
            actionButton.Click();
            Thread.Sleep(1000);

            //Fetching the details of the machine 
            IWebElement machineDetails = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("mat-menu-item")));
            machineDetails.Click();
            Thread.Sleep(3000);

            //Edit Planogram
            Thread.Sleep(3000);
            IWebElement editSlot = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@mattooltip='Edit Slot']")));
            editSlot.Click();
            Thread.Sleep(1000);

            IWebElement slotRowCount = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("slotRowCount")));
            slotRowCount.Clear();
            slotRowCount.SendKeys(PlanogramData.slotCounts[0, 0]);


            IWebElement slotColumnCount = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("slotColumnCount")));
            slotColumnCount.Clear();
            slotColumnCount.SendKeys(PlanogramData.slotCounts[0, 1]);

            IWebElement endingRowCount = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[@name='slotColumnCount'])[2]")));
            endingRowCount.Clear();
            endingRowCount.SendKeys(PlanogramData.slotCounts[0, 0]);


            IWebElement endingColumnCount = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[@type='number'])[6]")));
            endingColumnCount.Clear();
            endingColumnCount.SendKeys(PlanogramData.slotCounts[0, 1]);
            Thread.Sleep(1000);
            IWebElement saveSlots = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), ' Save ')]")));
            saveSlots.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Product Matrix Changed");

            ///* wait for Angular overlay/backdrop to disappear */
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(
            //    By.ClassName("cdk-overlay-backdrop")));


            IWebElement editInfo = wait.Until(
                ExpectedConditions.ElementToBeClickable(By.XPath("//button[@mattooltip='Edit Info']")));
            editInfo.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Entered into Machine Details Page");

            IWebElement clientLocation = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("clientLocation")));
            clientLocation.Clear();
            clientLocation.SendKeys(machineInfoData.machineDetails[0, 0]);
            Thread.Sleep(2000);

            IWebElement routeIdentifier = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("routeIdentifier")));
            routeIdentifier.Clear();
            routeIdentifier.SendKeys(machineInfoData.machineDetails[0, 1]);
            Thread.Sleep(2000);

            // Direct Refill checkbox
            IWebElement directRefillCheckbox = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='directRefill']")));

            if (directRefillCheckbox.Selected)
            {
                Console.WriteLine("Direct Refill is checked. Unchecking now..");
                IWebElement directRefillLabel = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Direct Refill Option')]")));
                directRefillLabel.Click();
                Thread.Sleep(1000); // allow Auto Refill to enable
            }
            else
            {
                Console.WriteLine("Direct Refill is already unchecked. Moving to check the status of Auto Refill...");
            }

            // Auto Refill checkbox
            IWebElement autoRefillCheckbox = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name ='disabledAutoRefill']")));

            if (autoRefillCheckbox.Selected)
            {
                Console.WriteLine("Disable Auto Refill is checked. Unchecking now..");
                IWebElement autoRefillLabel = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Disable Auto Refill')]")));
                autoRefillLabel.Click();
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Disable Auto Refill is already unchecked. Saving..");
            }
            Thread.Sleep(2000);

            //Save
            IWebElement saveButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Save')]")));
            saveButton.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Exited from Machine Details Page");


            //// Edit Single Slot 
            Console.WriteLine("Product Mapping in to slots...");
            Thread.Sleep(3000);
            Actions a = new Actions(driver);

            //Product Assigning Matrix 
            for (int i = 0; i < ProductMappingData.products.GetLength(0); i++)
            {
                Thread.Sleep(2000);
                IWebElement product = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"(//mat-card)[{ProductMappingData.products[i, 0]}]")));

                a.MoveToElement(product).Pause(TimeSpan.FromSeconds(2)).Perform();

                // String dynamicXPath1 = $"(//mat-card)[{slotIndex}]//button//mat-icon";
                IWebElement editSlot2 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"(//mat-card)[{ProductMappingData.products[i, 0]}]//button//mat-icon")));
                editSlot2.Click();
                Thread.Sleep(2000);

                // Locate the toggle button input
                IList<IWebElement> toggleButtons = driver.FindElements(By.XPath("//section[@class='full_width']//input"));

                foreach (IWebElement toggleButton in toggleButtons)
                {
                    // Check current state of toggle button
                    bool isToggleEnabled = toggleButton.Selected;
                    if (!isToggleEnabled)
                    {
                        Console.WriteLine("Toggle is OFF. Enabling now...");
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("arguments[0].click();", toggleButton);
                        Thread.Sleep(1000);
                        Console.WriteLine("Toggled Enabled.");
                    }
                }

                IWebElement selectProduct = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("product")));
                selectProduct.Click();

                //String name = ProductMappingData.products[i, 1];
                IWebElement choosingProduct = wait.Until(ExpectedConditions.ElementToBeClickable(
                    By.XPath($"//div[@role='listbox']//div[contains(text(), ' {ProductMappingData.products[i, 1]} ')]")));
                choosingProduct.Click();


                IWebElement purchaseLimitPerUser = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("purchaseLimitPerUser")));
                purchaseLimitPerUser.Clear();
                purchaseLimitPerUser.SendKeys(ProductMappingData.products[i, 2]);

                IWebElement purchaseLimitPerTransaction = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("purchaseLimitPerTransaction")));
                purchaseLimitPerTransaction.Clear();
                purchaseLimitPerTransaction.SendKeys(ProductMappingData.products[i, 3]);


                IWebElement purchaseLimitResetPerUser = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("purchaseLimitResetPerUser")));
                purchaseLimitResetPerUser.Click();
                IWebElement resetTime = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//span[contains(text(), ' {ProductMappingData.products[i, 4]} ')]")));
                resetTime.Click();

                IWebElement stockLimitInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("stockLimit")));
                stockLimitInput.Click();
                //String stockLimit = ProductMappingData.products[i, 5];
                //String stockLimitXPath = $"//span[contains(text(), ' {ProductMappingData.products[i, 5]} ')]";
                IWebElement chooseStockLimit = wait.Until(ExpectedConditions.ElementToBeClickable(
                    By.XPath($"//span[contains(text(), ' {ProductMappingData.products[i, 5]} ')]")));
                chooseStockLimit.Click();

                IWebElement save = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), ' Save ')]")));
                save.Click();
            }

            //Modify Planogram after Product Mapping
            IWebElement editSlot1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@mattooltip='Edit Slot']")));
            editSlot.Click();
            Thread.Sleep(1000);

            IWebElement slotRowCount1 = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("slotRowCount")));
            slotRowCount1.Clear();
            slotRowCount1.SendKeys(PlanogramData.slotCounts[0, 2]);


            IWebElement slotColumnCount1 = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("slotColumnCount")));
            slotColumnCount1.Clear();
            slotColumnCount1.SendKeys(PlanogramData.slotCounts[0, 3]);

            IWebElement endingRowCount1 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[@name='slotColumnCount'])[2]")));
            endingRowCount1.Clear();
            endingRowCount1.SendKeys(PlanogramData.slotCounts[0, 2]);


            IWebElement endingColumnCount1 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[@type='number'])[6]")));
            endingColumnCount1.Clear();
            endingColumnCount1.SendKeys(PlanogramData.slotCounts[0, 3]);
            Thread.Sleep(2000);
            IWebElement saveSlots1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), ' Save ')]")));
            saveSlots1.Click();
            Console.WriteLine("Product Matrix Changed again");
            Thread.Sleep(2000);


        }
        catch
        {
            // Take screenshot
            screenshotDriver = (ITakesScreenshot)driver;
            Screenshot screenshot = screenshotDriver.GetScreenshot();

            // Jenkins workspace / project root
            string projectPath3 = Directory.GetCurrentDirectory();

            // Create Screenshots folder
            string screenshotDir3 = Path.Combine(projectPath3, "Screenshots");
            Directory.CreateDirectory(screenshotDir3);

            // FIX: remove invalid characters from filename
            string filePath2 = Path.Combine(
                screenshotDir3,
                $"Screenshot_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png"
            );

            // Save screenshot
            screenshot.SaveAsFile(filePath2);

            Console.WriteLine($"Screenshot saved at: {filePath2}");
            Assert.Fail();
        }
    }

    public void SafeClick(By locator)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        // Wait for element to exist in DOM
        IWebElement element = wait.Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator)
        );

        // Wait until element is visible
        element = wait.Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)
        );

        // Scroll into view
        ((IJavaScriptExecutor)driver)
            .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", element);

        try
        {
            // Try normal click first
            element.Click();
        }
        catch (ElementClickInterceptedException)
        {
            // If intercepted, use JS click
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].click();", element);
        }
    }
}



///// <summary>
///// ////////////////////////////////// ADD PURCHASE /////////////////////////////////////////
///// </summary>

//public class AddPurchase
//{
//    private IWebDriver driver;
//    private WebDriverWait wait;

//    public AddPurchase(IWebDriver driver)
//    {
//        this.driver = driver;
//        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
//    }

//    public void AddPurchaseFlow()
//    {

//        //locate Warehouse Module
//        IWebElement warehouseTransactionsButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[normalize-space(text())='W. Transactions']")));
//        warehouseTransactionsButton.Click();
//        Thread.Sleep(2000);

//        //Go to Purchase module
//        IWebElement purchaseMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-W. Transactions0")));
//        purchaseMenu.Click();
//        Thread.Sleep(2000);


//        IWebElement AddWarehousePurchase = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains (@mattooltip, 'Add Warehouse Purchase')]")));
//        AddWarehousePurchase.Click();
//        Thread.Sleep(1000);
//        driver.FindElement(By.Name("warehouse")).Click();
//        string warehouseName = AddPurchaseData.Purchases[0, 0];
//        string dynamicWarehouseXPath = $"//span[text()=' {warehouseName} ']";
//        driver.FindElement(By.XPath(dynamicWarehouseXPath)).Click();

//        for (int i = 0; i < AddPurchaseData.Purchases.GetLength(0); i++)
//        {

//            ////Filter by product
//            //IWebElement productFilter = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//mat-select[@role = 'listbox'])[2]")));
//            //productFilter.Click();
//            //Thread.Sleep(2000);

//            //IWebElement selectProductName = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains (text(), ' Product Name ')]")));
//            //selectProductName.Click();
//            //Thread.Sleep(2000);


//            //string chooseProductName = AddPurchaseData.Purchases[i, 5];
//            //IWebElement enterProductName = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
//            //enterProductName.Click();
//            //enterProductName.Clear();
//            //enterProductName.SendKeys(chooseProductName + Keys.Enter);

//            //var rows = driver.FindElements(By.XPath("//table//tbody/tr"));
//            //if (rows.Count == 0)
//            //{
//            //Console.WriteLine($"Product not found. Adding Purchase of the product");
//            //IWebElement AddWarehousePurchase = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains (@mattooltip, 'Add Warehouse Purchase')]")));
//            //AddWarehousePurchase.Click();
//            //Thread.Sleep(1000);

//            //driver.FindElement(By.Name("warehouse")).Click();
//            //string warehouseName = AddPurchaseData.Purchases[0, 0];
//            //string dynamicWarehouseXPath = $"//span[text()=' {warehouseName} ']";
//            //driver.FindElement(By.XPath(dynamicWarehouseXPath)).Click();



//            // Add Purchase Page

//            driver.FindElement(By.Name("vendor")).Click();
//            string vendorName = AddPurchaseData.Purchases[i, 1];
//            string dynamicVendorXPath = $"//span[text()=' {vendorName} ']";
//            driver.FindElement(By.XPath(dynamicVendorXPath)).Click();

//            driver.FindElement(By.Name("productId")).Click();
//            string productName = AddPurchaseData.Purchases[i, 2];
//            string dynamicProductXPath = $"//span[contains(text(), ' {productName} ')]";
//            driver.FindElement(By.XPath(dynamicProductXPath)).Click();

//            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("qty"))).SendKeys(AddPurchaseData.Purchases[i, 3]);

//            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("batchId"))).SendKeys(AddPurchaseData.Purchases[i, 4]);

//            // Expiry Date selection
//            IWebElement expiryCalendarIcon = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("drange")));
//            expiryCalendarIcon.Click();
//            Thread.Sleep(1000);

//            IWebElement yearControl = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='owl-dt-calendar-control']")));
//            yearControl.Click();
//            Thread.Sleep(1000);

//            IWebElement yearToSelect = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//td[.//span[text()='{AddPurchaseData.Purchases[i, 6]}']]")));
//            yearToSelect.Click();
//            Thread.Sleep(1000);

//            IWebElement monthToSelect = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//td[.//span[text()='{AddPurchaseData.Purchases[i, 7]}']]")));
//            monthToSelect.Click();
//            Thread.Sleep(1000);

//            IWebElement dayToSelect = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//td[.//span[text()='{AddPurchaseData.Purchases[i, 8]}']]")));
//            dayToSelect.Click();
//            Thread.Sleep(1000);

//            // Bill Date selection
//            IWebElement billDateCalendarIcon = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("drange2")));
//            billDateCalendarIcon.Click();
//            Thread.Sleep(1000);


//            IWebElement yearControl1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='owl-dt-calendar-control']")));
//            yearControl1.Click();
//            Thread.Sleep(1000);

//            IWebElement yearToSelect1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//td[.//span[text()='{AddPurchaseData.Purchases[i, 9]}']]")));
//            yearToSelect1.Click();
//            Thread.Sleep(1000);

//            IWebElement monthToSelect1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//td[.//span[text()='{AddPurchaseData.Purchases[i, 10]}']]")));
//            monthToSelect1.Click();
//            Thread.Sleep(1000);

//            IWebElement dayToSelect1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//td[.//span[text()='{AddPurchaseData.Purchases[i, 11]}']]")));
//            dayToSelect1.Click();
//            Thread.Sleep(3000);

//            IWebElement addButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[text()= ' Add ']")));
//            addButton.Click();
//            Thread.Sleep(2000);



//        }
//        IWebElement saveButton1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[text()= ' Save ']")));
//        saveButton1.Click();
//        Thread.Sleep(2000);
//    }

//    public void SafeClick(By locator)
//    {
//        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

//        // Wait for element to exist in DOM
//        IWebElement element = wait.Until(
//            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator)
//        );

//        // Wait until element is visible
//        element = wait.Until(
//            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)
//        );

//        // Scroll into view
//        ((IJavaScriptExecutor)driver)
//            .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", element);

//        try
//        {
//            // Try normal click first
//            element.Click();
//        }
//        catch (ElementClickInterceptedException)
//        {
//            // If intercepted, use JS click
//            ((IJavaScriptExecutor)driver)
//                .ExecuteScript("arguments[0].click();", element);
//        }
//    }

//}





///// <summary>
///// ///////////////////////////////////////////////////////// RAISE REFILL REQUEST /////////////////////////////////////////////////////
///// </summary>
//public class RaiseRefillRequest
//{
//    private IWebDriver driver;
//    private WebDriverWait wait;

//    public RaiseRefillRequest(IWebDriver driver)
//    {
//        this.driver = driver;
//        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
//    }

//    public void RaiseRefillRequestFlow()
//    {

//        //Fetching Machine List
//        IWebElement machineMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines")));
//        machineMenu.Click();
//        Thread.Sleep(1000);

//        IWebElement machineList = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines0")));
//        machineList.Click();
//        Thread.Sleep(2000);

//        IWebElement machineFilter = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name = 'searchText']")));
//        machineFilter.Click();
//        machineFilter.Clear();
//        machineFilter.SendKeys(MachineMapping.unmappedMachineForMapping /* "2VE0000223" */ + Keys.Enter);
//        Thread.Sleep(3000);

//        //CHANGING OPERTION STATUS to Down Planned
//        // Action Button 
//        IWebElement actionBtn = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".mat-focus-indicator.mat-menu-trigger.mat-icon-button.mat-button-base")));
//        actionBtn.Click();
//        Thread.Sleep(1000);

//        //Fetching the details of the machine 
//        IWebElement machineDetails = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("mat-menu-item")));
//        machineDetails.Click();
//        Thread.Sleep(3000);

//        //Operation Status
//        Console.WriteLine("Setting the Status of the Machine To Down Planned");
//        IWebElement selectStatus = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Operation Status')]/following::a[1]")));
//        selectStatus.Click();
//        Thread.Sleep(1000);

//        IWebElement statusDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-select[@name='status']")));
//        statusDropdown.Click();

//        IWebElement downPlannedOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-option//span[contains(normalize-space(),'Down (Planned)')]")));
//        downPlannedOption.Click();

//        IWebElement saveStatus = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[text()= ' Save ']")));
//        saveStatus.Click();
//        Thread.Sleep(2000);
//        driver.Navigate().Back();
//        Thread.Sleep(2000);

//        IWebElement machineFilter1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name = 'searchText']")));
//        machineFilter1.Click();
//        machineFilter1.Clear();
//        machineFilter1.SendKeys(MachineMapping.unmappedMachineForMapping /* "2VE0000223" */ + Keys.Enter);
//        Thread.Sleep(3000);


//        //Raising refill request
//        IWebElement actionButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//td)[10]")));
//        actionButton.Click();
//        Thread.Sleep(1000);

//        IWebElement raiseRefillRequest = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'Raise Refill Request')]")));
//        raiseRefillRequest.Click();
//        Thread.Sleep(3000);

//        IWebElement saveRequest = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[.//span[text()=' Save ']]")));
//        saveRequest.Click();
//        Thread.Sleep(1000);
//        driver.Navigate().Back();
//        Thread.Sleep(3000);

//        //Warehouse Assigning
//        IWebElement warTransactionsButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-W. Transactions")));
//        warTransactionsButton.Click();
//        Thread.Sleep(3000);

//        IWebElement refillRequestMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-W. Transactions2")));
//        refillRequestMenu.Click();
//        Thread.Sleep(3000);

//        IWebElement actionButton1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//td)[13]")));
//        actionButton1.Click();
//        Thread.Sleep(1000);

//        IWebElement assignWarehouseButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),' Assign Warehouse ')]")));
//        assignWarehouseButton.Click();
//        Thread.Sleep(1000);

//        IWebElement warehouseDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("providorWarehouseId")));
//        warehouseDropdown.Click();

//        String chooseWarehouse = RaiseRefillRequestData.refillDatas["warehouseName"];
//        IWebElement choosingWarehouse = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//span[contains(text(), ' {chooseWarehouse} ')]")));
//        choosingWarehouse.Click();

//        IWebElement saveWarehouse = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[text()= ' Save ']")));
//        saveWarehouse.Click();
//        Thread.Sleep(3000);

//        //Stock Selection
//        IWebElement actionButton2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//td)[13]")));
//        actionButton2.Click();
//        Thread.Sleep(1000);
//        IWebElement selectStock = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),' Select Stock ')]")));
//        selectStock.Click();
//        Thread.Sleep(2000);


//        // Check Stock Availability and Collect Out-of-Stock Products
//        List<(string ProductName, string ReqQty)> outOfStockList = new List<(string, string)>();

//        //IList<IWebElement> outofstockProducts = driver.FindElements(By.XPath("//table/tbody/tr"));

//        //foreach (var row in outofstockProducts)
//        //{
//        //    var outOfStockText = row.FindElements(By.XPath(".//span[contains(text(),'Out of Stock')]"));
//        //    if (outOfStockText.Count > 0 && outOfStockText[0].Displayed)
//        //    {
//        //        string productName = row.FindElement(By.XPath(".//td[2]")).Text; // Product Name column
//        //        string reqQty = row.FindElement(By.XPath(".//td[5]")).Text;      // Required Qty column

//        //        // Store directly as a tuple (ProductName, ReqQty)
//        //        outOfStockList.Add((productName, reqQty));

//        //        Console.WriteLine($"[Out of Stock Found] Product: {productName}, Required Qty: {reqQty}");
//        //    }
//        //}

//        // If there are out-of-stock products → go to Purchase module
//        if (outOfStockList.Count == 0)
//        {
//            driver.FindElement(By.XPath("//button//span[text()=' Save ']")).Click();
//            Thread.Sleep(4000);

//            //Stock Selection
//            IWebElement actionButton3 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//td)[13]")));
//            actionButton3.Click();
//            Thread.Sleep(1000);
//            IWebElement completeRefill = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),' Complete Refill ')]")));
//            completeRefill.Click();
//            Thread.Sleep(2000);

//            IWebElement checkAllButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[normalize-space()='Check All']")));
//            checkAllButton.Click();
//            Thread.Sleep(2000);
//            driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
//            Thread.Sleep(4000);

//            //Fetching Machine List
//            IWebElement machineMenu1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines")));
//            machineMenu1.Click();
//            Thread.Sleep(1000);

//            IWebElement machineList1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines0")));
//            machineList1.Click();
//            Thread.Sleep(2000);

//            IWebElement machineFilter2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name = 'searchText']")));
//            machineFilter2.Click();
//            machineFilter2.Clear();
//            machineFilter2.SendKeys(MachineMapping.unmappedMachineForMapping + Keys.Enter);
//            Thread.Sleep(2000);

//            //CHANGING OPERTION STATUS to ONLINE
//            // Action Button 
//            IWebElement actionBtn1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".mat-focus-indicator.mat-menu-trigger.mat-icon-button.mat-button-base")));
//            actionBtn1.Click();
//            Thread.Sleep(1000);

//            //Fetching the details of the machine 
//            IWebElement machineDetails1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("mat-menu-item")));
//            machineDetails1.Click();
//            Thread.Sleep(3000);

//            //Operation Status
//            Console.WriteLine("Setting the Status of the Machine to ONLINE");
//            IWebElement selectStatus1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Operation Status')]/following::a[1]")));
//            selectStatus1.Click();
//            Thread.Sleep(1000);

//            IWebElement statusDropdown1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-select[@name='status']")));
//            statusDropdown1.Click();

//            IWebElement onlineOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-option//span[contains(normalize-space(),'Online')]")));
//            onlineOption.Click();

//            IWebElement saveStatus1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[text()= ' Save ']")));
//            saveStatus1.Click();
//            Thread.Sleep(2000);


//        }
//    }
//}



/////////////////////////////// RETURN REQUEST //////////////////////////////////////////

//public class ReturnRequest
//{
//    private IWebDriver driver;
//    private WebDriverWait wait;

//    public ReturnRequest(IWebDriver driver)
//    {
//        this.driver = driver;
//        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
//    }

//    public void ReturnRequestFlow()
//    {
//        Thread.Sleep(2000);

//        // Machines → Requests → Return
//        //Fetching Machine List
//        IWebElement machineMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines")));
//        machineMenu.Click();
//        Thread.Sleep(1000);
//        IWebElement requests = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines2")));
//        requests.Click();
//        Thread.Sleep(2000);
//        IWebElement ReturnTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@role='tab']//div[text()='Return']")));
//        ReturnTab.Click();
//        Thread.Sleep(2000);

//        IWebElement AddReturnRequest = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains (@mattooltip, 'Add Return request')]")));
//        AddReturnRequest.Click();
//        Thread.Sleep(2000);

//        //Fill the input fields
//        string machineId = /*"2VE0000224"*/ MachineMapping.unmappedMachineForMapping;
//        Console.WriteLine("Selected machine for returning products: " + machineId);

//        // 1. Click the dropdown
//        IWebElement machineDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("machineIds")));
//        machineDropdown.Click();
//        Thread.Sleep(2000);

//        // 2. Wait for list to appear
//        var machineOptions = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("mat-option span")));

//        // 3. Loop through dropdown and click exact match
//        bool found = false;
//        foreach (var option in machineOptions)
//        {
//            string optionText = option.Text.Trim();
//            //Console.WriteLine("Found option: " + optionText);

//            if (optionText.Equals(machineId, StringComparison.OrdinalIgnoreCase))
//            {
//                option.Click();
//                Console.WriteLine("Machine selected: " + optionText);
//                found = true;
//                break;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine("Machine ID NOT FOUND in dropdown! → " + machineId);
//        }
//        Thread.Sleep(1000);
//        IWebElement checkAllButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[normalize-space()='Check All']")));
//        checkAllButton.Click();
//        driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
//        Thread.Sleep(3000);

//        //Warehouse Assigning to Return the products
//        IWebElement warTransactionsButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-W. Transactions")));
//        warTransactionsButton.Click();
//        Thread.Sleep(3000);

//        IWebElement returnRequestMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-W. Transactions3")));
//        returnRequestMenu.Click();
//        Thread.Sleep(3000);

//        IWebElement searchTypeButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//mat-select[@role = 'listbox'])[2]")));
//        searchTypeButton.Click();
//        Thread.Sleep(2000);
//        IWebElement selectMachineId = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(normalize-space(),'Machine Id')]")));
//        selectMachineId.Click();
//        Thread.Sleep(2000);
//        IWebElement searchRequest = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name = 'searchText']")));
//        searchRequest.Clear();
//        searchRequest.SendKeys(/*MachineMapping.unmappedMachineForMapping */ machineId + Keys.Enter);
//        Thread.Sleep(2000);

//        IWebElement actionButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//td)[11]")));
//        actionButton.Click();
//        Thread.Sleep(1000);

//        IWebElement assignWarehouseButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),' Assign Warehouse ')]")));
//        assignWarehouseButton.Click();
//        Thread.Sleep(2000);

//        IWebElement warehouseDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("providorWarehouseId")));
//        warehouseDropdown.Click();
//        Thread.Sleep(2000);

//        String chooseWarehouse = ReturnRequestData.refillDatas["warehouseName"];
//        IWebElement choosingWarehouse = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//span[contains(text(), ' {chooseWarehouse} ')]")));
//        choosingWarehouse.Click();

//        IWebElement saveWarehouse = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[text()= ' Save ']")));
//        saveWarehouse.Click();
//        Thread.Sleep(3000);

//        IWebElement actionButton1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//td)[11]")));
//        actionButton1.Click();
//        Thread.Sleep(2000);

//        IWebElement pickupStock = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),' Pick Up Stock ')]")));
//        pickupStock.Click();
//        Thread.Sleep(3000);

//        IWebElement confirmPickup = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[text()= ' Pick Up ']")));
//        confirmPickup.Click();
//        Thread.Sleep(3000);

//        IWebElement actionButton2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//td)[11]")));
//        actionButton2.Click();
//        Thread.Sleep(2000);

//        IWebElement completeReturn = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),' Complete Return ')]")));
//        completeReturn.Click();
//        Thread.Sleep(2000);

//        IWebElement checkAllButton1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[normalize-space()='Check All']")));
//        checkAllButton1.Click();
//        driver.FindElement(By.XPath("//button//span[contains(text(),'Save')]")).Click();
//        Thread.Sleep(4000);


//        //SETTING LOCATION AND PARAMETERS 
//        //Fetching Machine menu
//        IWebElement machineMenu1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines")));
//        machineMenu1.Click();

//        // Fetching Machine List
//        IWebElement machineList = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("menuItem-Machines0")));
//        machineList.Click();
//        Thread.Sleep(1000);

//        //string machineId = /*"2VE0000218" */ MachineMapping.unmappedMachineForMapping;
//        //Console.WriteLine("Selecting machine: " + machineId);

//        IWebElement searchText = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("searchText")));
//        searchText.Clear();
//        searchText.SendKeys(machineId + Keys.Enter);
//        Thread.Sleep(3000);

//        // Action Button 
//        IWebElement actionBtn = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".mat-focus-indicator.mat-menu-trigger.mat-icon-button.mat-button-base")));
//        actionBtn.Click();
//        Thread.Sleep(1000);

//        //Fetching the details of the machine 
//        IWebElement machineDetails = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("mat-menu-item")));
//        machineDetails.Click();
//        Thread.Sleep(3000);

//        //Set Location for Machine
//        Console.WriteLine("Setting the Location of the Machine");
//        IWebElement selectLocation = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='cityText']")));
//        selectLocation.Click();

//        IWebElement city = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("City")));
//        city.Clear();
//        city.SendKeys(LocationData.location[0, 0]);
//        IWebElement state = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("State")));
//        state.Clear();
//        state.SendKeys(LocationData.location[0, 1]);
//        IWebElement plusCode = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("pluscode")));
//        plusCode.Clear();
//        plusCode.SendKeys(LocationData.location[0, 2]);
//        IWebElement validatePlusCode = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[contains(text(),' Validate Plus Code ')]")));
//        validatePlusCode.Click();
//        Thread.Sleep(1000);
//        IWebElement saveLocation = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), ' Save ')]")));
//        saveLocation.Click();
//        Console.WriteLine("Machine's Location Updated");
//        Thread.Sleep(4000);


//        //SET PARAMETERS
//        //Read expected parameters from ParametersData file
//        IWebElement parameters = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[contains(text(),' Parameters ')]")));
//        parameters.Click();
//        Thread.Sleep(1000);
//        List<string> expectedParams = new List<string>()
//            {
//                ParametersData.parameters[0, 0],
//                ParametersData.parameters[0, 1],
//                ParametersData.parameters[0, 2]
//            };

//        // Scan existing parameters on Machine Parameters popup
//        var existingParamElements = driver.FindElements(By.XPath("//div[@class='itemName']/div"));
//        List<string> presentParams = existingParamElements.Select(e => e.Text.Trim()).ToList();

//        Console.WriteLine("Present Parameters:");
//        presentParams.ForEach(Console.WriteLine);

//        // Build missing parameter list
//        List<string> missingParams = expectedParams.Where(p => !presentParams.Contains(p)).ToList();

//        Console.WriteLine("Missing Parameters:");
//        missingParams.ForEach(Console.WriteLine);

//        //If Missing Parameters Exixts
//        if (missingParams.Count != 0)
//        {
//            // Click "Add Parameters" button 
//            IWebElement addParameterBtn = wait.Until(ExpectedConditions.ElementToBeClickable(
//            By.XPath("//div[contains(@class,'parameterDisplay') and contains(.,'Add Parameters')]")));
//            addParameterBtn.Click();
//            Thread.Sleep(2000);

//            // Add missing parameters ONE BY ONE
//            foreach (string param in missingParams)
//            {
//                Console.WriteLine($"Adding missing parameter: {param}");

//                // Open dropdown
//                IWebElement dropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("machineParameterToAdd")));
//                dropdown.Click();
//                Thread.Sleep(400);

//                // Select the parameter from dropdown
//                IWebElement paramOption = wait.Until(ExpectedConditions.ElementToBeClickable(
//                        By.XPath($"//div[contains(@class,'cdk-overlay-pane')]//span[normalize-space()='{param}']")));
//                paramOption.Click();
//                Thread.Sleep(400);

//                // Click Add +
//                IWebElement addButtonInside = wait.Until(ExpectedConditions.ElementToBeClickable(
//                        By.XPath("//button//span[contains(text(),'Add')]")));
//                addButtonInside.Click();
//                Thread.Sleep(700);
//            }

//            IWebElement enableButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[contains(text(),'Enable')]")));
//            enableButton.Click();
//            Thread.Sleep(1000);

//            IWebElement closePopup = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-icon[text()='clear']")));
//            closePopup.Click();
//            Thread.Sleep(1000);
//            Console.WriteLine("All missing parameters added & enabled successfully");
//        }
//        else
//        {
//            Console.WriteLine("All parameters already exist. Nothing to add.");
//            IWebElement closeNow = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-icon[text()='clear']")));
//            closeNow.Click();
//            Thread.Sleep(800);

//        }
//        Thread.Sleep(3000);

//        Console.WriteLine("Parameter and Location are Updated. Moving to Add Functions of the Machine...");
//        //MachineFunctions machineFunction = new MachineFunctions(driver);
//        //machineFunction.MachineFunctionsFlow();

//    }
//}



//    /// <summary>
//    /// /////////////////////////////// MACHINE SCRAPPING  //////////////////////////////////////
//    /// </summary>

//    public class MachineScrapping
//    {
//        private IWebDriver driver;
//        private WebDriverWait wait;

//        public MachineScrapping(IWebDriver driver)
//        {
//            this.driver = driver;
//            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
//        }

//        public void MachineScrappingFlow()
//        {
//            Thread.Sleep(2000);

//            // Navigate to Current Purchase Order submenu
//            IWebElement currentPurchaseOrderMenu = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[contains(text(),'Current Purchase Order')]")));
//            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", currentPurchaseOrderMenu);
//            Thread.Sleep(300);
//            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", currentPurchaseOrderMenu);
//            Thread.Sleep(2000);


//            //Search Machine to Scrap
//            IWebElement searchTypeButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//mat-select[@role = 'listbox'])[2]")));
//            searchTypeButton.Click();
//            Thread.Sleep(2000);

//            IWebElement selectMachineId = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(normalize-space(),'Machine Id')]")));
//            selectMachineId.Click();
//            Thread.Sleep(2000);

//            string machineId = /*"2VE0000220" */ MachineMapping.unmappedMachineForMapping;
//            Console.WriteLine("Selecting machine: " + machineId);

//            IWebElement searchMachine = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name = 'searchText']")));
//            searchMachine.Clear();
//            searchMachine.SendKeys(/*MachineMapping.unmappedMachineForMapping */ machineId + Keys.Enter);
//            Thread.Sleep(2000);

//            IWebElement actionButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//td)[13]")));
//            actionButton.Click();
//            Thread.Sleep(1000);

//            IWebElement scarpButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),' Move to scrap ')]")));
//            scarpButton.Click();
//            Thread.Sleep(2000);

//            IWebElement comfirmScrapping = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button//span[contains(text(),' Confirm ')]")));
//            comfirmScrapping.Click();
//            Thread.Sleep(2000);

//            Console.WriteLine("The Machine is Scrapped: " + machineId);

//        }
//    }




