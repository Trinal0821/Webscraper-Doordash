using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace DoordashWebscraper
{
    public partial class Form1 : Form
    {
        private ChromeDriver driver;
        List<String> csv = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Scrape()
        {
            //Create the chromeDriver and go to the doordash merchant login webpage
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            StringBuilder builder = new StringBuilder();
            driver.Navigate().GoToUrl("https://identity.doordash.com/auth?client_id=1643580605860775164&redirect_uri=https%3A%2F%2Fmerchant-portal.doordash.com%2Fauth_callback&scope=*&prompt=none&response_type=code&layout=merchant_web_v2&state=ab3eda82-d4f4-4460-9a30-165db828d4f9&allowRedirect=true&failureRedirect=%2Fmerchant%2Flogin");

            //find the username and password and login
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            var username = driver.FindElement(By.Id("FieldWrapper-2"));
            username.SendKeys(usernameTextbox.Text);
            var password = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div/div/div/div/div[1]/form/div[1]/div[1]/div/div[2]/div/div/div[2]/div/div[1]/input"));
            password.SendKeys(passwordTextbox.Text);
            var login = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div/div/div/div/div[1]/form/div[1]/div[2]/button/div/div/div/span"));
            login.Click();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            Scrape();
        }
    }

    
}
