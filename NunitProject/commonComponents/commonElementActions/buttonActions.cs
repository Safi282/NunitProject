using OpenQA.Selenium;

namespace SeleniumTest.commonComponents.commonElementActions
{
    class buttonActions
    {
        public static void M_clickOnbutton(IWebDriver driver ,IWebElement button)
        {
            if (elementAvailability.M_isClickableOnScreen(driver,button)){
                button.Click();
            }
        }
    }
}
