using System.Linq;
using System.Windows.Forms;

namespace CCS
{
    class CCSMicrocontroller
    {
        private int minTemperature;
        private int maxTemperature;
        private int currentTemperature;
        private int currentHumidity;
        public bool enabled;
        public int Humidity;
        public int Temperature;
        private Sensors _sensors;
        private Environment environment;
        private ConditionerController cc;
        private HumidicatorController hc;

        public int CurrentTemperature()
        {
            currentTemperature = _sensors.ReadTemperature();
            return currentTemperature;
        }
        
        public int CurrentHumidity()
        {
            currentHumidity = _sensors.ReadHumidity();
            return currentHumidity;
        }

        public CCSMicrocontroller(Environment environment)
        {
            Temperature = environment.DefaultTemperature;
            Humidity = environment.DefaultHumidity;
            this.environment = environment;
            _sensors = new Sensors(environment);
            cc = new ConditionerController(environment);
            hc = new HumidicatorController(environment);
        }

        public static bool CheckAutorization(TextBox textBoxLogin, TextBox textBoxPassword, Label wrongDataLabel)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            if (!login.Contains('@') || !login.Contains('.'))
            {
                wrongDataLabel.Text = "Використовуйте email в якості логіну";
                wrongDataLabel.Visible = true;
            }
            else if (login == "nobodycares@gmail.com" && password == "TheStrongestPasswordYou'veEverSeen")
                return true;
            /*if (login == "admin" && password == "admin")
                return true;*/
            else
            {
                wrongDataLabel.Text = "Ви ввели неправильний логін або пароль";
                wrongDataLabel.Visible = true;
                return false;
            }
            return false;
        }
        
        public void Control()
        {
            if (enabled)
            {
                if (CurrentTemperature() < Temperature) cc.Heat();
                else if (currentTemperature == Temperature) cc.Off();
                else if (currentTemperature > Temperature) cc.Cool();
                if (CurrentHumidity() < Humidity) hc.IncreaseHumidity();
                else if (currentHumidity == Humidity) hc.Off();
                else if (currentHumidity > Humidity) hc.DecreaseHumidity();
            }
            else
            {
                cc.Off();
                hc.Off();
            }
        }
    }
}
