using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace TrafficLight.States.Blinking
{
    class On : State<TrafficLightForm>
    {
        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
            Main.blink();
            Timer t = new Timer(this, EventsEnum.Timer, 1000, null);

            ActivateTimer(t);
        }

        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.HandleEvent(stateEngineEvent, ref transition);

            if (stateEngineEvent.Type.Equals(EventsEnum.Timer))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, TransitionEnum.Blick);
            }
        }

        protected override void Exit()
        {
            Main.blink();
            base.Exit();
        }
    }
}
