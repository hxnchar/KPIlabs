using System;

namespace CCS
{
    public class Environment
    {
        public int Temperature;
        public int Humidity;
        public int DefaultTemperature = 20;
        public int DefaultHumidity;
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
                    Temperature -= Temperature- DefaultTemperature != 0 ?
                         ((Temperature - DefaultTemperature) / Math.Abs(Temperature - DefaultTemperature)):0;
                    break;
                case State.Increase:
                    Temperature++;
                    break;
                case State.Decrease:
                    Temperature--;
                    break;
            }
        }
        
        public void UpdateHumidity()
        {
            switch (HumState)
            {
                case State.Calm:
                    Humidity -=
                        ((Humidity - DefaultHumidity) / Math.Abs(Humidity - DefaultHumidity));
                    break;
                case State.Increase:
                    Humidity++;
                    break;
                case State.Decrease:
                    Humidity--;
                    break;
            }
        }
    }
}