using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Threading;


namespace Testonadd
{


    class Program
    {

        static void Main()
        {
            String baseURL = "https://shop.foodness.it/prodotti/bio/bevanda-dorzo-bio/";
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseURL);
            // IWebElement drpProdotti = driver.FindElement(By.CssSelector("#pa_compatibilita>option:nth-child(2)"));

            Thread.Sleep(20000);
            //add a option present in a select element 
            for (int i=1; i< 5; i++)
            {
                IWebElement drpProdotti = driver.FindElement(By.CssSelector("#pa_compatibilita>option:nth-child(" + i + ")"));
                if (drpProdotti.Displayed)
                {
                    Console.WriteLine("L'elemento nella selezione in posizione: " + i + " con valore: " + drpProdotti.GetAttribute("value"));
                }
            }
            





        }

    }
}

