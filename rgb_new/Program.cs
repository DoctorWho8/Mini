using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;

namespace pwm_rgb
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

            // change the color intensities
            redLed.SetDutyCycle(0);    // 60% red intensity
            greenLed.SetDutyCycle(75);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity

            // go to sleep
            Thread.Sleep(350);
            
            // change the color intensities
            redLed.SetDutyCycle(0);    // 50% red intensity
            greenLed.SetDutyCycle(0);   // 0% green intensity
            blueLed.SetDutyCycle(75); // 100% blue intensity

            // go to sleep
            Thread.Sleep(350);

            // change the color intensities
            redLed.SetDutyCycle(75);    // 60% red intensity
            greenLed.SetDutyCycle(0);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity
            
            // go to sleep
            Thread.Sleep(350);

            // change the color intensities
            redLed.SetDutyCycle(0);    // 60% red intensity
            greenLed.SetDutyCycle(0);   // 0% green intensity
            blueLed.SetDutyCycle(100); // 100% blue intensity
            // go to sleep

            Thread.Sleep(350);

            // change the color intensities
            redLed.SetDutyCycle(0);    // 60% red intensity
            greenLed.SetDutyCycle(100);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity
            // go to sleep

            // change the color intensities
            redLed.SetDutyCycle(20);    // 60% red intensity
            greenLed.SetDutyCycle(0);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity
            // go to sleep

            Thread.Sleep(350);


            // change the color intensities
            redLed.SetDutyCycle(0);    // 60% red intensity
            greenLed.SetDutyCycle(75);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity

            // go to sleep
            Thread.Sleep(350);

            // change the color intensities
            redLed.SetDutyCycle(0);    // 50% red intensity
            greenLed.SetDutyCycle(0);   // 0% green intensity
            blueLed.SetDutyCycle(75); // 100% blue intensity

            // go to sleep
            Thread.Sleep(350);

            // change the color intensities
            redLed.SetDutyCycle(75);    // 60% red intensity
            greenLed.SetDutyCycle(0);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity

            // go to sleep
            Thread.Sleep(350);

            // change the color intensities
            redLed.SetDutyCycle(0);    // 60% red intensity
            greenLed.SetDutyCycle(0);   // 0% green intensity
            blueLed.SetDutyCycle(100); // 100% blue intensity
            // go to sleep

            Thread.Sleep(350);

            // change the color intensities
            redLed.SetDutyCycle(0);    // 60% red intensity
            greenLed.SetDutyCycle(100);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity
            // go to sleep

            // change the color intensities
            redLed.SetDutyCycle(20);    // 60% red intensity
            greenLed.SetDutyCycle(0);   // 0% green intensity
            blueLed.SetDutyCycle(0); // 100% blue intensity
            // go to sleep

             Thread.Sleep(350);
            
            // change the color intensities
             redLed.SetDutyCycle(50);    // 60% red intensity
             greenLed.SetDutyCycle(50);   // 0% green intensity
             blueLed.SetDutyCycle(0); // 100% blue intensity
             // go to sleep

             Thread.Sleep(350);                 
        //    Thread.Sleep(Timeout.Infinite);
        }


    }
}