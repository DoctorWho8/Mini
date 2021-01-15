using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;

/* NOTE: make sure you change the deployment target from the Emulator to your Netduino before running this
 * Netduino sample app.  To do this, select "Project menu > ButtonApp Properties > .NET Micro Framework" and 
 * then change the Transport type to USB (or Serial).
 * Finally, close the ButtonApp properties tab to save these settings. */

namespace ButtonApp
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
           
            OutputPort led = new OutputPort(Pins.GPIO_PIN_17, false);
            Thread.Sleep(350);
            InputPort button = new InputPort(Pins.GPIO_PIN_16, false, Port.ResistorMode.Disabled);
            bool buttonState = false;
            Thread.Sleep(350);
            while (true)
            {
                buttonState = button.Read();
                led.Write(!buttonState);
            }          
        }

    }
}
