using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;


namespace TestProject1
{
    [TestClass]
    public class CandidateTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;


        [TestMethod]
        public void TheCandidateTestJavascriptDisabled()
        {
            Random gen = new Random();

            FirefoxProfile profile = new FirefoxProfile();
            profile.SetPreference("javascript.enabled", false);
            driver = new FirefoxDriver(profile);
			
			
            verificationErrors = new StringBuilder();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Navigate().GoToUrl("http://test.telerikacademy.com/SoftwareAcademy/Candidate");
            driver.FindElement(By.Id("UsernameOrEmail")).Clear();
            driver.FindElement(By.Id("UsernameOrEmail")).SendKeys("qaacademy2013");
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("qastudent");
            driver.FindElement(By.CssSelector("input.submit-button")).Click();
            driver.FindElement(By.Id("FirstName")).Clear();
            driver.FindElement(By.Id("FirstName")).SendKeys("QA");
            driver.FindElement(By.Id("SecondName")).Clear();
            driver.FindElement(By.Id("SecondName")).SendKeys("QA");
            driver.FindElement(By.Id("LastName")).Clear();
            driver.FindElement(By.Id("LastName")).SendKeys("QA");
            driver.FindElement(By.CssSelector("input#BirthDay.date-picker")).Clear();
            driver.FindElement(By.CssSelector("input#BirthDay.date-picker")).SendKeys("01/01/1900");
            driver.FindElement(By.Id("SchoolName")).Click();
            driver.FindElement(By.Id("SchoolName")).Clear();
            driver.FindElement(By.Id("SchoolName")).SendKeys("mySchool");
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("");
            driver.FindElement(By.Id("Phone")).Clear();
            driver.FindElement(By.Id("Phone")).SendKeys("0888123456");
           
            driver.FindElement(By.Id("SendButton")).Click();

            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("span.field-validation-error > span")));
            }
            catch (AssertFailedException e)
            {
                verificationErrors.Append(e.Message);
            }

            driver.FindElement(By.Id("Email")).Click();
            string email = "qastudent" + gen.Next(1, 100000) + "@abv.bg";
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys(email);

            driver.Manage().Cookies.DeleteCookieNamed("ASPXAUTH");

            try
            {
                Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.Id("Email")).Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"));
            }
            catch (AssertFailedException e)
            {
                verificationErrors.Append(e.Message);
            }

            try
            {
                Assert.IsTrue(!IsElementPresent(By.CssSelector("span.field-validation-error > span")));
            }
            catch (AssertFailedException e)
            {
                verificationErrors.Append(e.Message);
            }

            try
            {
                Assert.IsFalse(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*Имейл адресът е задължителен\\.[\\s\\S]*$"));
            }
            catch (AssertFailedException e)
            {
                verificationErrors.Append(e.Message);
            }

            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("abv.bg");

            try
            {
                Assert.AreEqual("Моля въведете валиден e-mail адрес.", driver.FindElement(By.XPath("//fieldset[@id='PersonalData']/div[12]/span")).Text);
            }
            catch (AssertFailedException e)
            {
                verificationErrors.Append(e.Message);
            }

            driver.FindElement(By.Id("ExitMI")).Click();
            driver.Close();
            driver.Quit();
        }
		private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
