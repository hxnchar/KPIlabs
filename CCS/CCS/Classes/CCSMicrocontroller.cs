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
            /*if (код)
                авторизация ретурн тру
            else*/
            {
                wrongDataLabel.Visible = true;
                return false;
            }
                
        }
    }
}
