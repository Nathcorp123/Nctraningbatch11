using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using PhpTravels01.Hooks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace PhpTravels01.SaveToExcel
{
    class ExcelData
    {
      
        string Text;
        string emailText;
        string passwordText;
        By emailPassword = By.XPath("//div[@class='resource-box']//*[text()='user@phptravels.com']");

        public void Credentials()
        {
            IWebElement fetchText = Hooks1.driver.FindElement(emailPassword);
            Text = fetchText.Text;

            //IWebElement UsrLogin = Hooks1.driver.FindElement(By.XPath("//*[text()='user@phptravels.com']"));
            //string LoginText = UsrLogin.Text;

            //StrEmail = LoginText.Substring(6,19);
            //Console.WriteLine(StrEmail);

            //StrPswd = LoginText.Substring(36);
            //Console.WriteLine(StrPswd);

            //Thread.Sleep(2000);
        }

        public void ReadCredentials()
        {
            Credentials();

            string str = Text;



            char[] spearator = { ' ', '\n', '\r' };




            string[] strlist = str.Split(spearator);
            emailText = strlist[1];
            passwordText = strlist[4];
        }

        String FileName = @"C:\Users\Deepika\source\repos\PhpTravels01\PhpTravels01\Feature01\Fdata1.xlsx";

        public void ExcelCode()

        {
           // ReadCredentials();

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(FileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            //first row then col
            xlWorksheet.Cells[2, 1] = emailText;
            xlWorksheet.Cells[2, 2] = passwordText;
          
            xlWorkbook.Save();

            //close 
            xlWorkbook.Close();
          



            //quit 
            xlApp.Quit();
          
        }

       

    }
}


