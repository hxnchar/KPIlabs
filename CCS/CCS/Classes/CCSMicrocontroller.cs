using System.Windows.Forms;

namespace CCS
{
    class CCSMicrocontroller
    {
        private int minTemperature;
        private int maxTemperature;
        private int currentTemperature;
        private int currentHumidity { get; }
        private int Humidity { get; }
        public int Temperature;
        private Sensors _sensors;
        private Environment environment;
        private ConditionerController cc;

        public int CurrentTemperature()
        {
            currentTemperature = _sensors.ReadTemperature();
            return currentTemperature;
        }

        public CCSMicrocontroller(Environment environment)
        {
            this.environment = environment;
            _sensors = new Sensors(environment);
            cc = new ConditionerController(environment);
        }

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

        public void AutoControl()
        {
            
        }

        public void ManualControl()
        {
            if (CurrentTemperature() < Temperature) cc.Heat();
            else if (currentTemperature == Temperature) cc.Off();
            else if (currentTemperature > Temperature) cc.Cool();
        }
    }
}
