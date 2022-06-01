using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_Assignment
{
    static class Pathfile
    {
        public static string CustomerFront_End = "//*[contains(text(),'Customer - Front-End')]";
        public static string email = "//input[@placeholder='Email']";
        public static string password = "//input[@placeholder='Password']";
        public static string cookie_stop = "//button[@class='cc-btn cc-dismiss waves-effect' and @id='cookie_stop']";
        public static string login_btn = "//div[@class='btn-box pt-3 pb-4']//button[@data-style='zoom-in']";
        public static string flight = "//a[text()='flights']";
        public static string round = "//label[contains(text(),' Round Trip')]";
        public static string flyingfield = "//input[@id='autocomplete']";
        public static string selectflyingfield = "//b[text()='IXR']";
        public static string destinationField = "//input[@id='autocomplete2']";
        public static string selectDestination = "//strong[contains(text(),' Chhatrapati Shivaji Intl')]";
        public static string SelectDepartDate = "//input[@class='depart form-control dateleft border-top-r0']";
        public static string SelectReturnDate = "//input[@id='return']";
        public static string passengerbox = "//div[@id='onereturn']//div[3]//div//div[@class='form-group']";
        public static string selectadults = "//input[@id='fadults']//following-sibling::div[@class='qtyInc']";
        public static string selectchilds = "//input[@id='fchilds']//following-sibling::div[@class='qtyInc']";
        public static string selectinfants = "//input[@id='finfant']//following-sibling::div[@class='qtyInc']";
        public static string search_btn = "//button[@id='flights-search']";
        public static string direct = "//label[text()=' Direct']";
        public static string select_class = "//select[@id='flight_type']//option[@value='economy']";
        public static string vhomepage = "//strong[text()='Demo Credentials for Frontend and Backend']";
        public static string vloginpage ="//p[text()='Please enter your account credentials below']";
        public static string vdashboard = "//img[@alt='user']";
        public static string vsearchpage = "//h2[text()='SEARCH FOR BEST FLIGHTS']";
        public static string vreturn = "//input[@id='return']";
        public static string vflightresult = "data";
        public static string Fprice1 = "//*[@id='data']/ul/li[2]/div/form/div/div[2]/div/button/strong";
        public static string Fprice2 = "//*[@id='data']/ul/li[5]/div/form/div/div[2]/div/button/strong";
        public static string Fprice3 = "//*[@id='data']/ul/li[6]/div/form/div/div[2]/div/button/strong";
        public static string Fprice4 = "//*[@id='data']/ul/li[8]/div/form/div/div[2]/div/button/strong";
        public static string Fprice5 = "//*[@id='data']/ul/li[14]/div/form/div/div[2]/div/button/strong";







    }
}


