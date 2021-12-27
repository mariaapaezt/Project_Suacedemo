using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;


namespace SauProject.pages
{

   

    public class Home
    {
        public IWebDriver chromeDrive;
        public string ruta = @"C:\Users\jesus\Downloads\chromedriver";

        
        public IWebElement titulo { set; get; }
        public IWebElement username { set; get; }
        public IWebElement password { set; get; }
        public IWebElement login_button { set; get; }



        public void Crecenciales()
        {

            chromeDrive = new ChromeDriver(ruta);
            chromeDrive.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(35);
            titulo = chromeDrive.FindElement(By.CssSelector("//div[contains(@class,'login_logo')]"));
            username = chromeDrive.FindElement(By.XPath("//input[contains(@placeholder,'Username')]"));
            password = chromeDrive.FindElement(By.XPath("//input[contains(@placeholder,'Password')]"));
            login_button = chromeDrive.FindElement(By.CssSelector("input[contains(@id,'login-button')]"));
        }


    }

}
