using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;

/* NOTE: make sure you change the deployment target from the Emulator to your Netduino before running this
 * Netduino sample app.  To do this, select "Project menu > Blinky Properties > .NET Micro Framework" and 
 * then change the Transport type to USB (or to serial, it depends on the device.) 
 * Finally, close the Blinky properties tab to save these settings. */

namespace Blinky
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
            OutputPort led0 = new OutputPort(Pins.GPIO_PIN_20, false);
            OutputPort led1 = new OutputPort(Pins.GPIO_PIN_19, false);
            OutputPort led2 = new OutputPort(Pins.GPIO_PIN_18, false);
            OutputPort led3 = new OutputPort(Pins.GPIO_PIN_17, false);
            OutputPort led4 = new OutputPort(Pins.GPIO_PIN_16, false);
            while (true)
            {
                Thread.Sleep(100);
                led0.Write(true);
                Thread.Sleep(975);
                led0.Write(false);
                Thread.Sleep(575);
                led1.Write(true);
                Thread.Sleep(575);
                led2.Write(true);
                Thread.Sleep(575);
                led3.Write(true);
                Thread.Sleep(575);
                led4.Write(false);
                Thread.Sleep(575);
                led0.Write(false);
                Thread.Sleep(875);
                led1.Write(false);
                Thread.Sleep(575);
                led2.Write(false);
                Thread.Sleep(575);
                led3.Write(false);
                Thread.Sleep(575);
                led4.Write(false);
                Thread.Sleep(875);
             }

        }

    }
}
