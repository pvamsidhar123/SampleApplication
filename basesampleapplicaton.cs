using OpenQA.Selenium;

namespace SampleApplication
{
    internal class basesampleapplicaton
    {
        protected IWebDriver driver
        {
            get;
            set;
      
        }

        public basesampleapplicaton(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}