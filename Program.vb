Imports System.ComponentModel.DataAnnotations
Imports System.Console

Module Program
    Sub Main()
        Dim area, lenght, width, height, cst, a1, a2, a3 As Integer
        cst = 2

        WriteLine("enter the specs of rectangle(length,width,height in order)")

        lenght = ReadLine()
        width = ReadLine()
        height = ReadLine()
        a1 = lenght * width * cst
        a2 = lenght * height * cst
        a3 = width * height * cst
        area = a1 + a2 + a3

        WriteLine(area)
        ReadKey()
    End Sub
End Module
