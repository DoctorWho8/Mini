using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;

/* NOTE: make sure you change the deployment target from the Emulator to your Netduino before running this
 * Netduino sample app.  To do this, select "Project menu > AdvancedButtonApp Properties > .NET Micro Framework" and 
 * then change the Transport type to USB or Serial.  Finally, close the AdvancedButtonApp properties tab to save these settings. */

namespace AdvancedButtonApp
{
    public class Program
    {
        static OutputPort led = new OutputPort(Pins.GPIO_PIN_17, false);

        public static void Main()
        {
            // write your code here
            InterruptPort button = new InterruptPort(Pins.GPIO_PIN_16, false, Port.ResistorMode.Disabled, Port.InterruptMode.InterruptEdgeBoth);
            button.OnInterrupt += new NativeEventHandler(button_OnInterrupt);

            Thread.Sleep(Timeout.Infinite);
        }

        static void button_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            led.Write(data2 == 0);
        }

    }
}
