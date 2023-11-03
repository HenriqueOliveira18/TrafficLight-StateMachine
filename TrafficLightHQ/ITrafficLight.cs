using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    interface ITrafficLight
    {
        event EventHandler onStateClick;
        event EventHandler onResetClick;
        event EventHandler onBlinkClick;

        void turnOnGreen();
        void turnOffGreen();
        void turnOnYellow();
        void turnOffYellow();
        void turnOnRed();
        void turnOffRed();
        void blink();
    }
}
