Imports Microsoft.SPOT
Imports Microsoft.SPOT.Hardware
Imports SecretLabs.NETMF.Hardware
Imports SecretLabs.NETMF.Hardware.NetduinoMini

Module Module1

    Sub Main()
        ' write your code here
        Dim led As New OutputPort(Pins.GPIO_PIN_20, False)
        Dim led0 As New OutputPort(Pins.GPIO_PIN_19, False)
        Dim led1 As New OutputPort(Pins.GPIO_PIN_18, False)
        Dim led2 As New OutputPort(Pins.GPIO_PIN_17, False)
        Dim led3 As New OutputPort(Pins.GPIO_PIN_16, False)
        Dim led4 As New OutputPort(Pins.GPIO_PIN_15, False)
        Dim led5 As New OutputPort(Pins.GPIO_PIN_14, False)
        Dim led6 As New OutputPort(Pins.GPIO_PIN_13, False)
        Do
            led3.Write(True)
            led4.Write(True)
            led5.Write(True)
            led6.Write(True)
            Thread.Sleep(1000)
            led3.Write(False)
            led4.Write(False)
            led5.Write(False)
            led6.Write(False)
            led.Write(True)
            led3.Write(True)
            Thread.Sleep(750)
            led.Write(False)
            led3.Write(False)
            Thread.Sleep(750)
            led0.Write(True)
            led4.Write(True)
            Thread.Sleep(750)
            led0.Write(False)
            led4.Write(False)
            Thread.Sleep(750)
            led1.Write(True)
            led5.Write(True)
            Thread.Sleep(750)
            led1.Write(False)
            led5.Write(False)
            Thread.Sleep(750)
            led2.Write(True)
            led6.Write(True)
            Thread.Sleep(750)
            led2.Write(False)
            led6.Write(False)
            Thread.Sleep(750)
            led3.Write(True)
            led4.Write(True)
            led5.Write(True)
            led6.Write(True)
            Thread.Sleep(1000)
            led3.Write(False)
            led4.Write(False)
            led5.Write(False)
            led6.Write(False)
            Thread.Sleep(1000)
        Loop
    End Sub

End Module
