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
using SauProject.metod;

namespace SauProject
{
    [TestClass] 

    public class Saucedemo_main
    {
        public IWebDriver chromeDrive;
        //public IWebDriver chromeDrive{ get; set; }
        public string url = "https://www.saucedemo.com/";
        public string ruta = @"C:\Users\jesus\Downloads\chromedriver";
        

        [TestMethod]
        public void TestIngresarWeb()
        {
            Validaciones validaciones = new Validaciones();
            validaciones.ValidarTituloPage();
            validaciones.IngresarUsernameYPassword();

        }

      
        [TestInitialize()]

        public void InicializarTest()
        {
            chromeDrive = new ChromeDriver(ruta);
            chromeDrive.Navigate().GoToUrl(url);
            chromeDrive.Manage().Window.Maximize();
            chromeDrive.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(35);
        }

        [TestCleanup()] 
        public void cleanupDriver()
        {
            chromeDrive.Quit();
        }
    }
}
