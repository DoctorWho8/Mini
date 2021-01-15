using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;

namespace Test32
{
    public class Program
    {
        public static void Main()
        {
            // write your code here

            OutputPort led0 = new OutputPort(Pins.GPIO_PIN_20, false);
            OutputPort led1 = new OutputPort(Pins.GPIO_PIN_19, false);
            OutputPort led = new OutputPort(Pins.GPIO_PIN_18, false);
            OutputPort Test1 = new OutputPort(Pins.GPIO_PIN_16, false);
            OutputPort Test2 = new OutputPort(Pins.GPIO_PIN_15, false);
            OutputPort Test3 = new OutputPort(Pins.GPIO_PIN_14, false);
            OutputPort Test4 = new OutputPort(Pins.GPIO_PIN_13, false);
            Thread.Sleep(175);
            InputPort button = new InputPort(Pins.GPIO_PIN_17, false, Port.ResistorMode.Disabled);
            bool buttonState = false;
          //  Thread.Sleep(175);
            while (true)
            {
                buttonState = button.Read();
                led.Write(!buttonState);
                Thread.Sleep(225);
                led0.Write(true);
                Thread.Sleep(875);
                led1.Write(true);
                Thread.Sleep(375);
                led0.Write(false);
                Thread.Sleep(375);
                led1.Write(false);
                Thread.Sleep(770);
                Test1.Write(true);
                Thread.Sleep(300);
                Test1.Write(false);
                Test2.Write(true);
                Thread.Sleep(300);
                Test2.Write(false);
                Test2.Write(true);
                Thread.Sleep(300);
                Test2.Write(false);
                Thread.Sleep(220);
                Test3.Write(true);
                Thread.Sleep(300);
                Test3.Write(true);
                Thread.Sleep(300);
                Test4.Write(true);
                Thread.Sleep(300);
                Test4.Write(false);

            }
        }

    }
}
