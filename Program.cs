using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebDriverDemo
{
    public class SeleniumWebDriver
    {
        static void Main()
        {
            // create browser instance
            var driver = new ChromeDriver();
            //var driver = new FirefoxDriver();
            //var driver = new EdgeDriver();

            // navigate to Wikipedia
            driver.Url = "https://www.wikipedia.org/";
            //driver.Navigate().GoToUrl("https://www.wikipedia.org/");

            // get browser title
            var pageTitle = driver.Title;

            Console.WriteLine("The page title is " + pageTitle);

            if (pageTitle == "Wikipedia")
            {
                Console.WriteLine("TEST PASS");
            } else
            {
                Console.WriteLine("TEST FAIL");
            }

            // close browser
            driver.Quit();
        }
    }
}