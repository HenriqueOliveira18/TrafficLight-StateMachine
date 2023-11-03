using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight.States
{
    enum TransitionEnum
    {
        InitToGreen,
        GreenToYellow,
        YellowToRed,
        YellowToGreen,
        RedToGreen,
        StartBlinking,
        Blick,
        StopBlinking,
    }
}
