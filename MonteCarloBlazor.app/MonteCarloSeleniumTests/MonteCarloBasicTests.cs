using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support.UI;

namespace MonteCarloSeleniumTests
{
    [TestClass]
    public class MonteCarloBasicTests
    {

        private static IWebDriver webDriver;
        
        [TestInitialize]
        public void TestInit()
        {
            webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webDriver.Navigate().GoToUrl("https://localhost:44314/");

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //IWebElement amountField = webDriver.FindElement(By.Id("portfolio-amount"));
            //amountField.SendKeys("100000");

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

     
        }

        [TestCleanup]
        public void CleanUp()
        {
            webDriver.Close();
        }

        public String getInvestmentAmount()
        {
            return webDriver.FindElement(By.XPath("/ html / body / div[1] / div / div / div / div / div / section / div / div[1] / div[2] / input")).Text;
        }

        [TestMethod]
        public void investment_amount_inputfield_exists()
        {    
            Assert.AreEqual("", getInvestmentAmount());
        }
    

    }
}
