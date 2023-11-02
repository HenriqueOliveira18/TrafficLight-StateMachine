using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace Semaforo.States.Blinking
{
    class OFF : State<Form1>
    {


        public OFF()
        {

        }

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
     
            Timer t = new Timer(this, SemaforoEvent.Timer, 1000, null);
            Console.WriteLine("In OFF");
            ActivateTimer(t);
        }
        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.HandleEvent(stateEngineEvent, ref transition);

            if (stateEngineEvent.Type.Equals(SemaforoEvent.Timer))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, SemaforoTransition.blink);
            }

        }
        protected override void Exit()
        {
            base.Exit();
        }
    }
}
