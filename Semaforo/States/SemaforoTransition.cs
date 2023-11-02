using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo.States
{
    public enum SemaforoTransition
    {
        initToGreen,
        greenToYellow,
        yellowToRed,
        redToGreen,
        yellowToGreen,
        startBlinking,
        blink,
        stopBlinking
    } 
}
