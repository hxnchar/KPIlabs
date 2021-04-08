namespace CCS
{
    class HumidicatorController
    {
        private Environment _environment;

        public HumidicatorController(Environment environment)
        {
            _environment = environment;
        }

        public void IncreaseHumidity()
        {
            _environment.HumState = Environment.State.Increase;
        }

        public void DecreaseHumidity()
        {
            _environment.HumState = Environment.State.Decrease;
        }

        public void Off()
        {
            _environment.HumState = Environment.State.Calm;
        }
    }
}
