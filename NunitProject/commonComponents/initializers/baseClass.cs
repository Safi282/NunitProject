using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumTest.demoQAProject.pageElementActions;
using System;

namespace SeleniumTest.commonComponents.initializers
{
    class baseClass
    {
        public ChromeDriver driver;
        public String baseURL=null;
        public practiceFormActions practicePA;
        public indexPageActions indexPA;
        public navigationPanelActions navigationPA;
        public static String chromeDriverPath = "D:\\AutomationProjects\\cSharpAutomation\\SeleniumTest\\SeleniumTest\\commonComponents\\utilities";
        [SetUp]
        public void M_openBrowser()
        {
            M_browserSettingsAndObjectCreation();
        }

        [TearDown]
        public void M_closeBrowser()
        {
            driver.Close();
        }

        private void M_browserSettingsAndObjectCreation()
        {
            baseURL = "https://demoqa.com/";
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Step 1: Navigate to URL
            driver.Url = baseURL;
            practicePA = new practiceFormActions(driver, "TestingFirstName", "TestingLastName", "Male", "1234567890");
            indexPA = new indexPageActions(driver);
            navigationPA = new navigationPanelActions(driver);
        }
    }
}
