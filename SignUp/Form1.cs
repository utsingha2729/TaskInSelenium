using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Form1 : Form
    {
        ChromeDriver Driverobj;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Driverobj = new ChromeDriver();
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            Driverobj.Url = "https://freeonlinesurveys.com";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            IWebElement ElementObj = Driverobj.FindElement(By.ClassName("home-hero-button"));
            ElementObj.Click();
        }

        private void btnSendCredentials_Click(object sender, EventArgs e)
        {
            //Text Boxes
            IWebElement ElementObj = Driverobj.FindElement(By.Id("email"));
            ElementObj.SendKeys("abc@gmail.com");
            IWebElement ElementObj1 = Driverobj.FindElement(By.Id("name"));
            ElementObj1.SendKeys("Utkarsh Singhal");
            IWebElement ElementObj2 = Driverobj.FindElement(By.Id("password"));
            ElementObj2.SendKeys("XYZ@12345");

            //Drop Down
            SelectElement SelectionObj = new SelectElement(Driverobj.FindElement(By.Id("position")));
            SelectionObj.SelectByText("Personal/Student");

            //SelectionObj.SelectByIndex(2);

            IList<IWebElement> ListSize = SelectionObj.Options;

            int iListSize = ListSize.Count;

            for (int i = 0; i < iListSize; i++)
            {
                String SelectedValue = SelectionObj.Options.ElementAt(i).Text;

                //MessageBox.Show("Value of Selected item is : " + SelectedValue);

                if (SelectedValue.Equals(0))
                {
                    SelectionObj.SelectByIndex(i);
                    break;
                }
            }

        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {
            IWebElement ElementObj = Driverobj.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div[3]/div/div/div/form/div/button[2]"));
            ElementObj.Click();
        }
    }
}
