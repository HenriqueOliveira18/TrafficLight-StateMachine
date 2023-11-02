using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayne.Lib.StateEngine;

namespace Semaforo.States
{
    class CONFIGURATION
    {
        public static void Config(StateTransitionLookup sl)
        {
            sl.AddTransition<Init, Green>(SemaforoTransition.initToGreen);
            sl.AddTransition<Green, Blinking.Composite>(SemaforoTransition.startBlinking);
            sl.AddTransition<Yellow, Blinking.Composite>(SemaforoTransition.startBlinking);
            sl.AddTransition<Red, Blinking.Composite>(SemaforoTransition.startBlinking);

            sl.AddTransition<Green, Yellow>(SemaforoTransition.greenToYellow);

            sl.AddTransition<Yellow, Red>(SemaforoTransition.yellowToRed);
            sl.AddTransition<Yellow, Green>(SemaforoTransition.yellowToGreen);

            sl.AddTransition<Red, Green>(SemaforoTransition.redToGreen);

            sl.AddTransition<Blinking.Composite, Green>(SemaforoTransition.stopBlinking);
            



        }
    }
}
