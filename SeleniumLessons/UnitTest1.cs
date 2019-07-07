using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumLessons
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DriverManager driverManager = new DriverManager();
            //Менеджер драйверов из дополнительной библиотеки WebDriverManager
            driverManager.SetUpDriver(new ChromeConfig());
            //Функция настройки драйвера для текущего окружения - new ChromeConfig()- объект настроек драйвера из неймспейса WebDriverManager.DriverConfigs.Impl

            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://otus.ru/");
            IWebElement element = driver.FindElement(By.CssSelector("button.header2__auth.js-open-modal"));
            //функция поиска одного элемента
            element.Click();
            //Click() - функция клика по элементу. Находится в интерфейсе IWebElement
            ReadOnlyCollection<IWebElement> inputsOnPage = driver.FindElements(By.CssSelector("div.new-log-reg input[name='email']"));//>>
            //ReadOnlyCollection - коллекция элементов, которую нельзя изменять
            //<IWebElement> - интерфейс, который должны реализовывать элементы, с которыми коллекция может работать
            //driver.FindElements() - функция поиска нескольких элементов на странице по определенному локатору, возвращает неизменяемый список элементов
            //By.CssSelector/By.XPath - статические функции которые нам возвращают объект типа By, создаваемый на основе Css или Xpath локатора
            inputsOnPage[0].SendKeys("email@email.ru");

           
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            Cat cat = new Cat(); //вызываем конструктор без параметров Cat()
            Cat secondCat = new Cat("Igor"); //вызываем конструктор с параметром Cat(string name)
            Cat thirdCat = new Cat("Masha","Dvorovaya","Yellow"); //вызываем конструктор с тремя параметрами Cat(string name,string poroda,string color)
            //Что находится внутри объектов можно посмотреть дебаггером
            //ставим точку останова и правой кнопкой мыши по этой функции и нажимаем - отладить тесты

        }
    }
}
