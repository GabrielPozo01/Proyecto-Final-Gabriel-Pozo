using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;



using Proyecto_final_automatizado;

namespace MyExecutableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejecutar las pruebas automatizadas
            var testClass = new LoginAndRegisterTests();
            testClass.EdgeDriverInitialize();
            testClass.Login_With_Valid_Credentials_Should_Succeed();
            testClass.Register_New_User_Should_Succeed();
            testClass.EdgeDriverCleanup();
        }
    }
}





