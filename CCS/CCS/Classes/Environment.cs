using System;

namespace CCS
{
    public class Environment
    {
        public int Temperature;
        public int Humidity;
        public int DefaultTemperature;
        public State TempState;
        public State HumState;
        private static Random _random;

        public enum State
        {
            Calm,
            Increase,
            Decrease
        }

        public Environment()
        {
            _random = new Random();
            TempState = State.Calm;
            HumState = State.Calm;
        }

        public void UpdateTemperature()
        {
            switch (TempState)
            {
                case State.Calm:
                    Temperature -=
                        2 * ((Temperature - DefaultTemperature) / Math.Abs(Temperature - DefaultTemperature));
                    break;
            }
        }
    }
}