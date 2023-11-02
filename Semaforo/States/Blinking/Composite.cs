using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Generic;

namespace Semaforo.States.Blinking
{
    class Composite : CompositeState<Form1>
    {

        public Composite()
            : base()
        {

        }
        protected override void ConfigureCompositeStateMachine()
        {
            CONFIGURATION.Config(StateMachine.StateTransitionLookup);
        }

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
        }
        public override void UnhandledEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.UnhandledEvent(stateEngineEvent, ref transition);
            if (stateEngineEvent.Type.Equals(SemaforoEvent.startBlinkEvent))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, SemaforoTransition.stopBlinking);
            }
            Console.WriteLine("Currently in composite");
        }
        protected override void Exit()
        {
            base.Exit();
        }
    }
}
