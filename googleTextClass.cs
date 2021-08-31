using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using OpenQA.Selenium;
using System;

namespace SampleApplication
{
    internal class googleTextClass:basesampleapplicaton
    {

        private static Logger log = LogManager.GetCurrentClassLogger();


        // private IWebDriver driver;

        public googleTextClass (IWebDriver driver):base(driver) { }
        /*{
            this.driver = driver;
        }*/

        public bool visible
        {
            get
            {
                 return driver.Url.Contains("https://www.cleartrip.com/flights");
            }

            internal set
            {

            }
        }

        public IWebElement text => driver.FindElement(By.Name("q"));
        public IWebElement text1 => driver.FindElement(By.Name("q"));
        public IWebElement oneFrom => driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div[1]/div[1]/div/div/div/input"));
       public IWebElement multiFrom => driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[2]/div[1]/div/div/input"));

        public IWebElement oneway =>driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[1]/div[1]/span"));
        public IWebElement multiway => driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[3]/div[1]/span"));


        internal void Open()
        {
            log.Trace("Attempting to open the application");
            var url = "https://www.cleartrip.com/flights#";
                driver.Navigate().GoToUrl(url);

            log.Info($"opened the url=>{url}");

            Assert.IsTrue(visible);
            log.Info("Assert was succesfull");

        }
        internal void enteringAndClicking(testData data)
        {
            log.Trace("Attempting select the enter and click for trips");
            switch (data.triptype)
            {

                case trip.Oneway:
                    {
                        oneway.Click();
                        log.Info($"selcted trip is => {trip.Oneway}");
                        oneFrom.SendKeys(data.oneFrom);
                        log.Info($"following data was entered succesfully=>{data.oneFrom}");
                    }
                    break;
                case trip.Multicity:
                    {
                        
                       multiway.Click();
                        multiFrom.SendKeys(data.multiFrom);
                    }
            
                    break;
                default:
                    break;
            }


            //one way
            

            //multiway
            


        }








     /*   internal searchResultPage enteringAndClicking(testData data)
        {
        //oneway
              var oneway = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[1]/div[1]/span"));
             data.oneway.Click();
            var onefrom=  driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div[1]/div[1]/div/div/div/input"));
             data.onefrom.SendKeys(data.onefrom);
               var onetwo=driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div[1]/div[5]/div/div/div/input"));
              data.onetwo.SendKeys("chennai");*/

           

           /* //mmultiway
            var multiway = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[3]/div[1]/span"));
              data.multiway.Click();
            var multifrom1 = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[2]/div[1]/div/div/input"));
            data.multifrom1.SendKeys("Hyderabad");
            var multito1 = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[2]/div[4]/div/div/input"));
            data.multito1.SendKeys("chennai");
            var multifrom2 = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[5]/div[1]/div/div/input"));
            data.multifrom2.SendKeys("Hyderabad");
            var multito2 = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[5]/div[4]/div/div[1]/input"));
            data.multito2.SendKeys("chennai");

        }*/











       /* internal searchResultPage enteringAndClicking(testData data)
        {

          //var text =   driver.FindElement(By.Name("q"));
            text.SendKeys(data.v);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //text.SendKeys(Keys.Enter);
            data.searchbutton.Click();
            return new searchResultPage(driver);
        }*/
    }
}