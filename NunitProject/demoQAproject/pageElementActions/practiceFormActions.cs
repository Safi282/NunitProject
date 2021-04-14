using OpenQA.Selenium;
using SeleniumTest.commonComponents.commonElementActions;
using SeleniumTest.demoQAProject.pageElementLocators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.demoQAProject.pageElementActions
{
    class practiceFormActions
    {
        IWebDriver driver;
        practiceFormLocators practiceFormPL = null;
        bool successfullySubmitted = false;
        List<IWebElement> allInputElements = null;
        List<String> requiredElements = new List<String>();
        public practiceFormActions(IWebDriver driver)
        {
            this.driver = driver;
            practiceFormPL = new practiceFormLocators(this.driver);
        }

        public void inputFirstName(String firstName)
        {
            textBoxActions.sendInput(practiceFormPL.getFirstNameTextbox(), firstName);
        }
        public void inputLastName(String lastName)
        {
            textBoxActions.sendInput(practiceFormPL.getLastNameTextBox(), lastName);
        }
        public void selectMaleGender()
        {
            IWebElement maleSelectionRadioButton = practiceFormPL.getMaleGenderRadioButton();
            buttonActions.clickOnbutton(maleSelectionRadioButton);
        }
        public void selectFemaleGender()
        {
            buttonActions.clickOnbutton(practiceFormPL.getFemaleGenderRadioButton());
        }
        public void selectOtherGender()
        {
            buttonActions.clickOnbutton(practiceFormPL.getOtherGenderRadioButton());
        }
        public void inputUserNumber(String userNumber)
        {
           textBoxActions.sendInput(practiceFormPL.getUserNumber(), userNumber);
        }
        public void submitForm()
        {
            buttonActions.clickOnbutton(practiceFormPL.getSubmitButton());
        }

        public bool successfulSubmit()
        {
            bool isSuccess = false;
            if (elementAvailability.isVisibleOnScreen(practiceFormPL.getSuccessDialogue()))
            {
                isSuccess = true;
            }
            return isSuccess;
        }

        public List<String> RequiredFields()
        {
            allInputElements=practiceFormPL.getAllInputElements();
            for(int i = 0; i < allInputElements.Count; i++)
            {
                if (elementAvailability.isVisibleOnScreen(allInputElements[i]))
                {
                    if (allInputElements[i].GetAttribute("required") != null)
                    {
                        requiredElements.Add(allInputElements[i].GetAttribute("id"));
                    }
                }
            }
            return requiredElements;
        }

        public bool fillForm(String firstName, String lastName, String gender, String userNumber)
        {
            
            inputFirstName(firstName);
            inputLastName(lastName);
            switch (gender)
            {
                case "Male": {
                        selectMaleGender();
                        break;
                    }
                case "Female": {
                        selectFemaleGender();
                        break;
                    }
                case "Other": {
                        selectOtherGender();
                        break;
                    }
                default: {
                        selectMaleGender();
                        break;
                    }
            }
            inputUserNumber(userNumber);
            submitForm();
            if (successfullySubmitted)
                successfullySubmitted = false;
            successfullySubmitted = successfulSubmit();
            return successfullySubmitted;
        }
    }
}
