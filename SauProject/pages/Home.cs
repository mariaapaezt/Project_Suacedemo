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
       

        public string xpath_titulo = "//div[contains(@class,'login_logo')]";
        public string xpath_username = "user-name";
        public string xpath_password = "password";
        public string xpath_login_button = "input[contains(@id,'login-button')]";
        public IWebElement titulo;
        public IWebElement username;
        public IWebElement password;
        public IWebElement login_button;


        public void Credenciales(IWebDriver chromeDriver)
        {
            
             titulo = chromeDriver.FindElement(By.CssSelector(xpath_titulo));
             username = chromeDriver.FindElement(By.Name(xpath_username));
             password = chromeDriver.FindElement(By.Name(xpath_password));
             login_button = chromeDriver.FindElement(By.CssSelector(xpath_login_button));
        }

        public void ValidarTituloPage(IWebDriver chromeDriver)
        {
            Credenciales(chromeDriver);
            Assert.IsNotNull(titulo);
        }

        public void IngresarUsernameYPassword(IWebDriver chromeDriver)
        {
            Credenciales(chromeDriver);
            username.SendKeys("standard_user");
            password.SendKeys("secret_sauce");
            login_button.Click();
        }
    }

}
