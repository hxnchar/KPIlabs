using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCS
{
    class CCSMicrocontroller
    {
        public static bool Authorize(TextBox textBoxLogin, TextBox textBoxPassword, Label wrongDataLabel)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            /*if (!login.Contains('@') || !login.Contains('.'))
            {
                wrongDataLabel.Text = "Використовуйте email в якості логіну";
                wrongDataLabel.Visible = true;
            }
            else if (login == "nobodycares@gmail.com" && password == "TheStrongestPasswordYou'veEverSeen")
                return true;
            else
            {
                wrongDataLabel.Text = "Ви ввели неправильний логін або пароль";
                wrongDataLabel.Visible = true;
                return false;
            }
            return false;*/
            return true;
        }
    }
}
