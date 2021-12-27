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
using SauProject.pages;

namespace SauProject.metod
{
    public class Validaciones
    {
       

        public void ValidarTituloPage()
        {
            Home pages = new Home();
            Assert.IsNull(pages.titulo);
        }

        public void IngresarUsernameYPassword()
        {
            Home pages = new Home();
            pages.username.SendKeys("standard_user");
            pages.password.SendKeys("secret_sauce");
            pages.login_button.Click();
        }

    }
}
