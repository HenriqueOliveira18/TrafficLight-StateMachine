using Wayne.Lib.StateEngine;

namespace TrafficLight.States.Blinking
{
    class Configuration
    {
        public static void Config(StateTransitionLookup sl)
        {
            sl.AddTransition<Init, On>(BasicTransitionType.Init);
            sl.AddTransition<On, Off>(TransitionEnum.Blick);
            sl.AddTransition<Off, On>(TransitionEnum.Blick);
        }
    }
}
