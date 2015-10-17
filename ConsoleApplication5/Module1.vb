Module Module1


    Function GetMax(ByRef box() As Integer) As Integer
        Dim max As Integer
        max = box(0)
        For i As Integer = 1 To box.GetUpperBound(0)
            If max < box(i) Then
                max = box(i)
            End If
        Next
        Return max
    End Function
    Function GetMix(ByRef box() As Integer) As Integer
        Dim mix As Integer
        mix = box(0)
        For i As Integer = 1 To box.GetUpperBound(0)
            If mix > box(i) Then
                mix = box(i)
            End If
        Next
        Return mix
    End Function

    Sub Main()
        Dim c, num As Integer
        Console.WriteLine("請設定上限數：")
        num = val(console.ReadLine())
        Dim AHQ(num - 1) As Integer
        For c = 0 To AHQ.GetUpperBound(0)
            Console.Write("輸入任意數字: ", (c + 1).ToString())
            AHQ(c) = Val(Console.ReadLine())

        Next

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("輸入數字中最大值 : {0}", GetMax(AHQ).ToString())
        Console.WriteLine("輸入數字中最小值 : {0}", GetMix(AHQ).ToString())
        Console.ReadLine()
    End Sub
End Module
