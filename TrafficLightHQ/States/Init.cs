using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace TrafficLight.States
{
    class Init : InitialState<TrafficLightForm>
    {

        protected override Transition CreatePseudoStateTransition(StateEntry stateEntry)
        {
            return new Transition(this, TransitionEnum.InitToGreen);

        }
    }
}
