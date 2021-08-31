using OpenQA.Selenium;

namespace SampleApplication
{
    internal class searchResultPage:basesampleapplicaton
    {

        //private IWebDriver Driver { get; }
        public searchResultPage(IWebDriver driver):base(driver) { }
        /*{
            Driver = driver;
        }*/



        internal bool visible => driver.Title.Contains("Test Google Search");

    }
}