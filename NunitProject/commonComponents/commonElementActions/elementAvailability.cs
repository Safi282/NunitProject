using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumTest.commonComponents.commonElementActions
{
    class elementAvailability
    {
        public static bool M_isVisibleOnScreen(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            bool isVisible = false;
            
            if (element.Displayed)
            {
                isVisible = true;
                action.MoveToElement(element);
                action.Perform();
            }
            return isVisible;
        }

        public static bool M_isClickableOnScreen(IWebDriver driver, IWebElement element)
        {

            
            bool isClickable = false;
            if (M_isVisibleOnScreen(driver,element))
            {
                if (element.Enabled)
                {
                    isClickable = true;

                }
            }
            return isClickable;
        }
    }
}
