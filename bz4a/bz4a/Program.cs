﻿using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoMini;


namespace bz4a
{
    public class Program
    {
        public static void Main()
        {
            // write your code here


            OutputPort i0 = new OutputPort(Pins.GPIO_PIN_20, false); //J1
            OutputPort i1 = new OutputPort(Pins.GPIO_PIN_19, false); //J2
            OutputPort i2 = new OutputPort(Pins.GPIO_PIN_18, false); //J3
            OutputPort i3 = new OutputPort(Pins.GPIO_PIN_17, false); //K3
            OutputPort i4 = new OutputPort(Pins.GPIO_PIN_16, false); //K2
            OutputPort i5 = new OutputPort(Pins.GPIO_PIN_15, false); //K1
           // OutputPort i6 = new OutputPort(Pins.GPIO_PIN_14, false);
           // OutputPort i7 = new OutputPort(Pins.GPIO_PIN_13, false);
            while (true)
            {
                Thread.Sleep(750);
                i0.Write(false);
                i1.Write(false);
                i2.Write(false);
                i3.Write(false);
                i4.Write(false);
                i5.Write(false);
             //   i6.Write(false);
             //   i7.Write(false);
                Thread.Sleep(750);
                i0.Write(true);
                i1.Write(true);
                i2.Write(true);
                i3.Write(true);
                i4.Write(true);
                i5.Write(true);
              //  i6.Write(true);
              //  i7.Write(true);
                Thread.Sleep(750);
                i0.Write(false);
                i1.Write(false);
                i2.Write(false);
                i3.Write(false);
                Thread.Sleep(500);
                i0.Write(false);
                i1.Write(false);
                i2.Write(false);
                i3.Write(false);
                 i4.Write(false);
                 i5.Write(false);
                // i6.Write(false);
                // i7.Write(false);
                Thread.Sleep(750);
                   i0.Write(false);
                   i1.Write(false);
                   i2.Write(false);
                   i3.Write(false);
                   i4.Write(false);
                   i5.Write(false);
                   Thread.Sleep(750);
                   //   i0.Write(true);
                   //   i1.Write(true);
                   //  i2.Write(true);
                   //  i3.Write(true);
                   //  i4.Write(false);
                   //  i5.Write(false);
                   //  i6.Write(false);
                   //   i7.Write(false);
                   //   Thread.Sleep(750);
                   //    i0.Write(false);
                   //   i1.Write(false);
                   //  i2.Write(true);
                   //  i3.Write(true);
                   //  i4.Write(false);
                   // Thread.Sleep(250);
                   // i0.Write(false);
                   // i1.Write(false);
                   // i2.Write(false);
                   // i3.Write(false);
                   // i4.Write(false);
                   // Thread.Sleep(750);
                   // i4.Write(true);
                   // i5.Write(true);
                   // i6.Write(false);
                   // i7.Write(false);
                   //  Thread.Sleep(500);
                   //  i0.Write(false);
                   // i1.Write(false);
                   // i2.Write(false);
                   // i3.Write(false);
                   // i4.Write(false);
                   // Thread.Sleep(250);
                   //  i0.Write(true);
                   //  i1.Write(true);
                   //  i2.Write(true);
                   //  i3.Write(false);
                   //  i4.Write(false);
                   //  i5.Write(false);
                   //  i6.Write(false);
                   //  i7.Write(false);
                   // Thread.Sleep(75);
                   // i0.Write(false);
                   // i1.Write(false);
                   // i2.Write(false);
                   // i3.Write(false);
                   // Thread.Sleep(250);
                   //  i0.Write(true);
                   // i1.Write(true);
                   // i2.Write(false);
                   // i3.Write(false);
                   // i4.Write(false);
                   // i5.Write(true);
                   // i6.Write(false);
                   // i7.Write(false);
                   // Thread.Sleep(250);
                   //  i0.Write(true);
                   //  i1.Write(true);
                   // i2.Write(true);
                   // i3.Write(true);
                   // Thread.Sleep(575);
                   // i0.Write(true);
                   // i1.Write(true);
                   // i2.Write(true);
                   // i3.Write(false);
                   // Thread.Sleep(575);
                   // i0.Write(false);
                   // i1.Write(false); 
                   // i2.Write(false);
                   // i3.Write(false);
                   // i4.Write(false);
                   //   Thread.Sleep(575);
                   // i0.Write(true);
                   // i1.Write(true);
                   // i2.Write(true);
                   // i3.Write(true); 
                   // Thread.Sleep(575);
                   //  i0.Write(true);
                   //  i1.Write(false);
                   //  i2.Write(true);
                   //  i3.Write(false);
                   //    Thread.Sleep(575);
                   //  i0.Write(true);
                   //  i1.Write(false);
                   //  i2.Write(true);
                   //  i3.Write(true);
                   //      Thread.Sleep(575);
                   //  i0.Write(true);
                   //  i1.Write(true);
                   //  i2.Write(false);
                   //  i3.Write(false);
                 Thread.Sleep(800);

            }
        }

    }
}
