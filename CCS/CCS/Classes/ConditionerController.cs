namespace CCS
{
    class ConditionerController
    {
        private Environment _environment;

        public ConditionerController(Environment environment)
        {
            _environment = environment;
        }

        public void Heat()
        {
            _environment.TempState = Environment.State.Increase;
        }

        public void Cool()
        {
            _environment.TempState = Environment.State.Decrease;
        }

        public void Off()
        {
            _environment.TempState = Environment.State.Calm;
        }
    }
}
