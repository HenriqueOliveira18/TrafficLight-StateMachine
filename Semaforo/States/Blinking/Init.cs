using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace Semaforo.States.Blinking
{
    class Init : InitialState<Form1>
    {


        public Init() {

        }

        protected override Transition CreatePseudoStateTransition(StateEntry stateEntry)
        {
            Console.WriteLine("In Init");
            return new Transition(this, BasicTransitionType.Init);
        }

    }
}
