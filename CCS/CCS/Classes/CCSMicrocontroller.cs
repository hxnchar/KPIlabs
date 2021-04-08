using System.Windows.Forms;

namespace CCS
{
    class CCSMicrocontroller
    {
        private int minTemperature;
        private int maxTemperature;
        private int currentTemperature { get; }
        private int currentHumidity { get; }
        private int Humidity { get; }
        private int Temperture { get; }
        

        public static bool CheckAutorization(TextBox textBoxLogin, TextBox textBoxPassword, Label wrongDataLabel)
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
