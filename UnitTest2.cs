using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SampleApplication
{
    [TestClass]
    public class UnitTest2
    {
        private IWebDriver driver;

        internal testData testdata { get; private set; }

        [TestInitialize]
       public void browser()
        {
            var factory = new webDriverFactory();
            driver = factory.create(Browser.Chrome);


            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
             testdata = new testData();
            testdata.oneFrom = "Hyderabad";
            testdata.multiFrom = "chennai";

        }

        [TestMethod]
        public void onewaymethod()
        {
            testdata.triptype = trip.Oneway;
            var googleSearchPage = new googleTextClass(driver);
            googleSearchPage.Open();
            
         googleSearchPage.enteringAndClicking(testdata);
           // driver.Close();

        }

        [TestMethod]
        public void multiwaymethod()
        {
            testdata.triptype = trip.Multicity;
            var googleSearchPage = new googleTextClass(driver);
            googleSearchPage.Open();
           
            googleSearchPage.enteringAndClicking(testdata);

            //   Assert.IsTrue(searchResult.visible,"assert is failed with actual");
            //driver.Close();

        }




        // [TestCleanup]

        /*  [TestMethod]
          public void TestMethod2()
          {
              driver = new ChromeDriver();

              var googleSearchPage = new googleTextClass(driver);
              googleSearchPage.Open();
              Assert.IsTrue(googleSearchPage.visible);

              var searchbutton = driver.FindElement(By.Name("btnK"));

              var testdata1 = new testData();
              testdata1.v = "testing";
              testdata1.searchbutton = searchbutton;

              var searchResult = googleSearchPage.enteringAndClicking(testdata1);
              Assert.IsTrue(searchResult.visible, "assert is failed with actual");
              driver.Close();

          }*/
    }
}
