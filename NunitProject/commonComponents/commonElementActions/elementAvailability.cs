using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.commonComponents.commonElementActions
{
    class elementAvailability
    {
        public static bool isVisibleOnScreen(IWebElement element)
        {
            bool isVisible = false;
            
            if (element.Displayed)
            {
                isVisible = true;
            }
            return isVisible;
        }

        public static bool isClickableOnScreen(IWebElement element)
        {
            bool isClickable = false;
            if (isVisibleOnScreen(element))
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
