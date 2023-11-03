using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace TrafficLight.States.Blinking
{
    class Composite : CompositeState<TrafficLightForm>
    {
        protected override void ConfigureCompositeStateMachine()
        {
            Configuration.Config(StateMachine.StateTransitionLookup);
        }


        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
        }

        public override void UnhandledEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.UnhandledEvent(stateEngineEvent, ref transition);

            // Enter if the 'Stop Blinking' button is pressed
            if (stateEngineEvent.Type.Equals(EventsEnum.BlinkClick))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, TransitionEnum.StopBlinking);
            }
        }

        protected override void Exit()
        {
            base.Exit();
        }
    }
}
