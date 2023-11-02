using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace Semaforo.States.Blinking
{
    class ON : State<Form1>
    {


        public ON()
        {
        }

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
            Main.blink();
            Timer t = new Timer(this, SemaforoEvent.Timer, 1000, null);
            Console.WriteLine("In ON");

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
            Main.blink();
            base.Exit();
        }
    }
}
