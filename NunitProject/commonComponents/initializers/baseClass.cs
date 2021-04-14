using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.demoQAProject.pageElementActions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.commonComponents.initializers
{
    class baseClass
    {
        public static ChromeDriver driver;
        String baseURL=null;
        public practiceFormActions practicePA;
        public indexPageActions indexPA;
        public navigationPanelActions navigationPA;
        public static String chromeDriverPath = "D:\\AutomationProjects\\cSharpAutomation\\SeleniumTest\\SeleniumTest\\commonComponents\\utilities";
        [SetUp]
        public void openBrowser()
        {
            baseURL = "https://demoqa.com/";
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Step 1: Navigate to URL
            driver.Url=baseURL;
            practicePA = new practiceFormActions(driver);
            indexPA = new indexPageActions(driver);
            navigationPA = new navigationPanelActions(driver);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
