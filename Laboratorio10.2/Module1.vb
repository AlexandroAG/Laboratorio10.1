﻿Module area
    Sub Main()

        Dim radio As Single
        Dim area As Single
        Dim circunferencia As Single
        Const pi As Single = 3.1415926

        Console.Write("Ingrese el radio: ")
        radio = Convert.ToSingle(Console.ReadLine())

        area = pi * radio ^ 2
        circunferencia = 2 * pi * radio

        Console.WriteLine("El área es: {0}", area)
        Console.WriteLine("La circunferencia es: {0}", circunferencia)

        Console.ReadKey()
    End Sub
End Module
