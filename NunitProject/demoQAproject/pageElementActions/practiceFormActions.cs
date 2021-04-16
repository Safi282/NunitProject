using OpenQA.Selenium;
using SeleniumTest.commonComponents.commonElementActions;
using SeleniumTest.demoQAProject.pageElementLocators;
using System;
using System.Collections.Generic;

namespace SeleniumTest.demoQAProject.pageElementActions
{
    class practiceFormActions
    {
        IWebDriver driver;
        practiceFormLocators practiceFormPL = null;
        bool successfullySubmitted = false;
        List<IWebElement> allInputElements = null;
        List<String> requiredElements = new List<String>();
        private String firstName = null;
        private String lastName = null;
        private String gender = null;
        private String userNumber = null;
        public practiceFormActions(IWebDriver driver ,String paramFirstName, String paramLastName, String paramGender, String paramUserNumber)
        {
            this.driver = driver;
            practiceFormPL = new practiceFormLocators(this.driver);
            firstName = paramFirstName;
            lastName = paramLastName;
            gender = paramGender;
            userNumber = paramUserNumber;
        }

        private void M_inputFirstName(String firstName)
        {
            textBoxActions.M_sendInput(driver,practiceFormPL.getFirstNameTextbox(), firstName);
        }
        private void M_inputLastName(String lastName)
        {
            textBoxActions.M_sendInput(driver,practiceFormPL.getLastNameTextBox(), lastName);
        }
        private void M_selectMaleGender()
        {
            IWebElement maleSelectionRadioButton = practiceFormPL.getMaleGenderRadioButton();
            buttonActions.M_clickOnbutton(driver, maleSelectionRadioButton);
        }
        private void M_selectFemaleGender()
        {
            buttonActions.M_clickOnbutton(driver, practiceFormPL.getFemaleGenderRadioButton());
        }
        private void M_selectOtherGender()
        {
            buttonActions.M_clickOnbutton(driver, practiceFormPL.getOtherGenderRadioButton());
        }
        private void M_inputUserNumber(String userNumber)
        {
           textBoxActions.M_sendInput(driver, practiceFormPL.getUserNumber(), userNumber);
        }
        public void M_submitForm()
        {
            buttonActions.M_clickOnbutton(driver,practiceFormPL.getSubmitButton());
        }

        private bool M_successfulSubmit()
        {
            bool isSuccess = false;
            if (elementAvailability.M_isVisibleOnScreen(driver,practiceFormPL.getSuccessDialogue()))
            {
                isSuccess = true;
            }
            return isSuccess;
        }

        public List<String> M_RequiredFields()
        {
            allInputElements=practiceFormPL.getAllInputElements();
            for(int i = 0; i < allInputElements.Count; i++)
            {
                if (elementAvailability.M_isVisibleOnScreen(driver,allInputElements[i]))
                {
                    if (allInputElements[i].GetAttribute("required") != null)
                    {
                        requiredElements.Add(allInputElements[i].GetAttribute("id"));
                    }
                }
            }
            return requiredElements;
        }

        public bool M_fillForm()
        {
            
            M_inputFirstName(firstName);
            M_inputLastName(lastName);
            switch (gender)
            {
                case "Male": {
                        M_selectMaleGender();
                        break;
                    }
                case "Female": {
                        M_selectFemaleGender();
                        break;
                    }
                case "Other": {
                        M_selectOtherGender();
                        break;
                    }
                default: {
                        M_selectMaleGender();
                        break;
                    }
            }
            M_inputUserNumber(userNumber);
            M_submitForm();
            if (successfullySubmitted)
                successfullySubmitted = false;
            successfullySubmitted = M_successfulSubmit();
            return successfullySubmitted;
        }
    }
}
