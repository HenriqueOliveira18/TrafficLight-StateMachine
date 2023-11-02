using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo.States
{
    public enum SemaforoEvent
    {
        buttonClick,
        resetButtonClick,
        startBlinkEvent,
        Timer,
    }
}
