using NUnit.Framework;
using SeleniumTest.commonComponents.initializers;
using SeleniumTest.demoQAProject.pageElementActions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.demoQAProject.pageElementTests
{
    [TestFixture]
    class practiceFormTests:baseClass
    {
        List<String> expectedRequiredElements = new List<String> { "firstName","lastName", "userNumber"};
        List<String> actualRequiredElements = new List<String>();
         
        [Test]
        public void M_fillRequiredFields() {
            //Step 2: click on forms to navigate to forms page
            indexPA.M_navigateToFormsPage();
            //Step 3: click on practice form to open form
            navigationPA.M_navigateToPracticeForm();
            //Step 4: fill out mandatory fields and save result
            bool isSuccess =practicePA.M_fillForm();
            //Step 5: Assert Submitted Successfully
            Assert.True(isSuccess);
        }
        
        [Test]
        public void M_submitEmptyForm() {
            //Step 2: click on forms to navigate to forms page
            indexPA.M_navigateToFormsPage();
            //Step 3: click on practice form to open form
            navigationPA.M_navigateToPracticeForm();
            //Step 4: Submit Empty form
            practicePA.M_submitForm();
            //Step 5: Compare 2 Arraylist
            actualRequiredElements=practicePA.M_RequiredFields();
            //Step 5: Assert "Firstname", "Lastname", "Gender", "UserNumber" are Required
            Assert.AreEqual(actualRequiredElements, expectedRequiredElements);
        }
    }
}
