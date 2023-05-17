using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace SeleniumFramework
{
    public class Driver
    {
        public static IWebDriver driver;
       
        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static IWebDriver GetDriver();
        {
            return public static void ShutdownDriver()
        {
            throw new NotImplementedException();
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }
        public static void ShutdownDriver()
        {
            driver.Quit();  
        }
        
    }

}