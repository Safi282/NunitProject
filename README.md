# NunitProject
This is a test project for basic testcase implementation using Page Object Model architecture along side Nunit

highlights about project:
1) Contains 2 test cases for demoqa.com
2) first test case is to fill out mandatory fields and submit form
3) Second test case is to submit empty form and map mandatoryfields (Fname,Lname,Number)

Highlghts about architecture:
Here you can find the three layered architecture for POM
1) pageElementLocators
2) pageElementActions
3) pageElementTests

for every page there is a separate class for locators, Actions and Tests. Since both tests are of same page there is only one class in pageElementTests package
There is also a commonComponents package that include bacis click, edit, visibility, clickability, scrolldown for common elements like button, textbox etc. These commonComponents
can be reused for multiple projects therefore i have made a separete packge for this and another for project.
Test Project
