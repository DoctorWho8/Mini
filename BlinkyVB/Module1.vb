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
            led6.Write(False)
            led5.Write(False)
            led3.Write(False)
            led4.Write(False)
            led.Write(True)
            Thread.Sleep(250)
            led.Write(False)
            Thread.Sleep(250)
            led0.Write(True)
            Thread.Sleep(250)
            led0.Write(False)
            led1.Write(True)
            Thread.Sleep(250)
            led1.Write(False)
            led2.Write(True)
            Thread.Sleep(250)
            led2.Write(False)
            led3.Write(True)
            Thread.Sleep(250)
            led3.Write(False)
            led4.Write(True)
            Thread.Sleep(250)
            led4.Write(False)
            led5.Write(True)
            Thread.Sleep(250)
            led5.Write(False)
            led6.Write(True)
            Thread.Sleep(250)
            led6.Write(False)

        Loop

    End Sub

End Module
