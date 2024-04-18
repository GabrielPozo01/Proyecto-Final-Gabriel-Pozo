using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Proyecto_final_automatizado
{
    [TestClass]
    public class LoginAndRegisterTests
    {
        

        private EdgeDriver _driver;

        [TestInitialize]
        public void EdgeDriverInitialize()
        {
            
            var options = new EdgeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            _driver = new EdgeDriver(options);
        }

        [TestMethod]
        public void Login_With_Valid_Credentials_Should_Succeed()
        {
            
            _driver.Url = "http://localhost:5187/Inicio/IniciarSesion";

            Thread.Sleep(5000);

            _driver.FindElement(By.Name("correo")).SendKeys("juan@example.com");
            _driver.FindElement(By.Name("clave")).SendKeys("000");
            _driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Contains("Index"));

            
            Assert.IsTrue(_driver.Url.Contains("Index"), "El inicio de sesión no fue exitoso.");
        }

        [TestMethod]
        public void Register_New_User_Should_Succeed()
        {
            
            _driver.Url = "http://localhost:5187/Inicio/Registrarse";

            Thread.Sleep(5000);

            _driver.FindElement(By.Name("NombreUsuario")).SendKeys("gabriel pozo");
            _driver.FindElement(By.Name("Correo")).SendKeys("gabriel@example.com");
            _driver.FindElement(By.Name("Clave")).SendKeys("123");
            _driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Contains("Index"));

            
            Assert.IsTrue(_driver.Url.Contains("Index"), "El registro no fue exitoso.");
        }

        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            
            _driver.Quit();
        }
    }
}

