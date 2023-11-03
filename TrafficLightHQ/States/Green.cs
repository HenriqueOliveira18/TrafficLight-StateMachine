using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace TrafficLight.States
{
    class Green : State<TrafficLightForm>
    {
        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
            Main.turnOnGreen();
        }

        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.HandleEvent(stateEngineEvent, ref transition);

            if (stateEngineEvent.Type.Equals(EventsEnum.StateClick))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, TransitionEnum.GreenToYellow); 
            }
            if (stateEngineEvent.Type.Equals(EventsEnum.ResetClick))
            {
                stateEngineEvent.Handled = true;
            }
            if (stateEngineEvent.Type.Equals(EventsEnum.BlinkClick))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, TransitionEnum.StartBlinking);
            }
        }

        protected override void Exit()
        {
            Main.turnOffGreen();
            base.Exit();
        }
    }
}