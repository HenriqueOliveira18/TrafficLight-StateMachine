using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayne.Lib.StateEngine;

namespace Semaforo.States.Blinking
{
    class CONFIGURATION
    {
            public static void Config(StateTransitionLookup sl)
            {
                sl.AddTransition<Init, ON>(BasicTransitionType.Init);
                sl.AddTransition<ON, OFF>(SemaforoTransition.blink);
                sl.AddTransition<OFF, ON>(SemaforoTransition.blink);

              
        }
    }
}

