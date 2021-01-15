using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;

namespace Test47
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
            OutputPort led0 = new OutputPort(Pins.GPIO_PIN_16, false);
            OutputPort led1 = new OutputPort(Pins.GPIO_PIN_15, false);
            OutputPort led = new OutputPort(Pins.GPIO_PIN_14, false);
           Thread.Sleep(125);
            InputPort button = new InputPort(Pins.GPIO_PIN_13, false, Port.ResistorMode.Disabled);
            bool buttonState = false;
            Thread.Sleep(125);
            while (true)
            {
                Thread.Sleep(424);
                buttonState = button.Read();
                led.Write(!buttonState);
                Thread.Sleep(776);
                led0.Write(true);
                Thread.Sleep(350);
                led1.Write(true);
                Thread.Sleep(450);
                led0.Write(false);
                Thread.Sleep(450);
                led1.Write(false);
                Thread.Sleep(424);
                buttonState = button.Read();
                led.Write(!buttonState);
            }
        }

    }
}
