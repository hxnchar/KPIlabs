using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
