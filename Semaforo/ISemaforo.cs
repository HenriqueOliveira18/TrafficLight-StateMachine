using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semaforo
{
    internal interface ISemaforo
    {

        event EventHandler onBtnClick;
        event EventHandler onResetBtnClick;
        event EventHandler onStartBlinkClick;
        void turnOnGreen();
        void turnOffGreen();
        void turnOnYellow();
        void turnOffYellow();
        void turnOnRed();
        void turnOffRed();

        void blink();

    }
}
