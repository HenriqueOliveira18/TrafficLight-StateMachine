using System.Windows.Forms;
using Wayne.Lib.StateEngine;

namespace TrafficLight.States
{
    class Configuration
    {
        public static void Config(StateTransitionLookup sl)
        {
            sl.AddTransition<Init, Green>(TransitionEnum.InitToGreen);

            sl.AddTransition<Green, Yellow>(TransitionEnum.GreenToYellow);

            sl.AddTransition<Yellow, Green>(TransitionEnum.YellowToGreen);
            sl.AddTransition<Yellow, Red>(TransitionEnum.YellowToRed);

            sl.AddTransition<Red, Green>(TransitionEnum.RedToGreen);
            
            sl.AddTransition<Green, Blinking.Composite>(TransitionEnum.StartBlinking);
            sl.AddTransition<Yellow, Blinking.Composite>(TransitionEnum.StartBlinking);
            sl.AddTransition<Red, Blinking.Composite>(TransitionEnum.StartBlinking);
            sl.AddTransition<Blinking.Composite, Green>(TransitionEnum.StopBlinking);

        }
    }
}
