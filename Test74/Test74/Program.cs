using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;

namespace Test74
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
            PWM redLed = new PWM(Pins.GPIO_PIN_20);
            PWM greenLed = new PWM(Pins.GPIO_PIN_19);
            PWM blueLed = new PWM(Pins.GPIO_PIN_18);

            // change the color intensities
            redLed.SetDutyCycle(60);    // 60% red intensity
            greenLed.SetDutyCycle(2);   // 0% green intensity
            blueLed.SetDutyCycle(100); // 100% blue intensity

            

            // go to sleep
            Thread.Sleep(350);

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
         
             // change the color intensities
            redLed.SetDutyCycle(0);    // 60% red intensity
            greenLed.SetDutyCycle(75);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity

            // go to sleep
            Thread.Sleep(350);
                 
        }

    }
}
