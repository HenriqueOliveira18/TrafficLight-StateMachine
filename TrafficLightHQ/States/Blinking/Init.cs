using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace TrafficLight.States.Blinking
{
    class Init : InitialState<TrafficLightForm>
    {


        public Init()
        {

        }

        protected override Transition CreatePseudoStateTransition(StateEntry stateEntry)
        {
            return new Transition(this, BasicTransitionType.Init);
        }

    }
}
