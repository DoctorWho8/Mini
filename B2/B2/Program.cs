using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;

namespace B2
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
            OutputPort led5 = new OutputPort(Pins.GPIO_PIN_15, false);
            OutputPort led6 = new OutputPort(Pins.GPIO_PIN_14, false);
            OutputPort led7 = new OutputPort(Pins.GPIO_PIN_13, false);
            while (true)
            {
                // Thread.Sleep(100);
                 led0.Write(true);
                 Thread.Sleep(575);
                 led1.Write(false);
                 Thread.Sleep(575);
                 led2.Write(false);
                 Thread.Sleep(575);
                 led3.Write(false);
                 Thread.Sleep(575);
                 led0.Write(false);
                  Thread.Sleep(575);
                  led1.Write(true);
                  Thread.Sleep(575);
                  led2.Write(false);
                  Thread.Sleep(575);
                  led3.Write(false);
                  Thread.Sleep(575);
                led0.Write(true);
                Thread.Sleep(575);
                led1.Write(true);
                Thread.Sleep(575);
                led2.Write(true);
                Thread.Sleep(575);
                led3.Write(false);
                Thread.Sleep(575);
                led0.Write(true);
                Thread.Sleep(575);
                led1.Write(true);
                Thread.Sleep(575);
                led2.Write(true);
                Thread.Sleep(575);
                led3.Write(true);
                Thread.Sleep(575);
                led4.Write(true);
                Thread.Sleep(575);
                led5.Write(true);
                Thread.Sleep(575);
                led6.Write(true);
                Thread.Sleep(575);
                led7.Write(true);
                Thread.Sleep(575);
                led0.Write(false);
                Thread.Sleep(575);
                led1.Write(false);
                Thread.Sleep(575);
                led2.Write(false);
                Thread.Sleep(575);
                led3.Write(false);
                Thread.Sleep(575);
                led4.Write(false);
                Thread.Sleep(575);
                led5.Write(false);
                Thread.Sleep(575);
                led6.Write(false);
                Thread.Sleep(575);
                led7.Write(false);
                Thread.Sleep(575);
                led4.Write(true);
                Thread.Sleep(575);
                led5.Write(true);
                Thread.Sleep(575);
                led6.Write(true);
                Thread.Sleep(575);
                led7.Write(true);
                Thread.Sleep(445);
                led4.Write(false);
                Thread.Sleep(575);
                led5.Write(false);
                Thread.Sleep(575);
                led6.Write(false);
                Thread.Sleep(575);
                led7.Write(false);


                            }

        }
    }
}
