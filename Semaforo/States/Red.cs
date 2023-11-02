using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace Semaforo.States
{
    class Red: State<Form1>
    
    {

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
            Main.turnOnRed();
        }

        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.HandleEvent(stateEngineEvent, ref transition);

            if (stateEngineEvent.Type.Equals(SemaforoEvent.buttonClick))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, SemaforoTransition.redToGreen);
            }
            if (stateEngineEvent.Type.Equals(SemaforoEvent.resetButtonClick))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, SemaforoTransition.redToGreen);
            }
            if (stateEngineEvent.Type.Equals(SemaforoEvent.startBlinkEvent))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, SemaforoTransition.startBlinking);
            }

        }
        protected override void Exit()
        {
            Main.turnOffRed();
            base.Exit();
        }
    }
}
