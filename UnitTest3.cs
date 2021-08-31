using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SampleApplication
{
    [TestClass]
    public class UnitTest3
    {
        public IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.cleartrip.com/flights#");

            //oneway
             driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[1]/div[1]/span"))
            .Click();
            //driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div[1]/div[1]/div/div/div/input")).SendKeys("Hyderabad");
           // driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div[1]/div[5]/div/div/div/input")).SendKeys("chennai");

            //mmultiway
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[3]/div[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[2]/div[1]/div/div/input")).SendKeys("Hyderabad");
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[2]/div[4]/div/div/input")).SendKeys("chennai");
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[5]/div[1]/div/div/input")).SendKeys("Hyderabad");
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[5]/div[4]/div/div[1]/input")).SendKeys("chennai");
            


        }
    }
}
