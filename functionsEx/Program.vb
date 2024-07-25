Imports System

Module Program
    Dim strList As New List(Of String)()
    Sub Main()
        Dim el As String
        Add()
        Add1(4, 6)
        MaxN(7, 10, 11)
        'Dim max As Decimal = MaxNb(5, 7, 9)
        Console.WriteLine("Max with a function {0}", MaxNb(5, 7, 9))
        ListSub()
        DisplaySu()
        Console.WriteLine("Element to search:")
        el = Console.ReadLine()
        Dim ind As Integer = Search(el)
        If ind >= 0 Then
            Console.WriteLine("{0} is found at {1}", el, ind)
        Else
            Console.WriteLine("Element is not found")
        End If
    End Sub
    Sub Add()
        Dim n1, n2 As Decimal
        n1 = 7
        n2 = 8
        Console.WriteLine("The sum is " & n1 + n2)
    End Sub
    Sub Add1(ByVal n1 As Decimal, ByVal n2 As Decimal)
        Console.WriteLine("Sum with parameters is " & n1 + n2)
    End Sub
    Sub MaxN(ByVal n1 As Decimal, ByVal n2 As Decimal, ByVal n3 As Decimal)
        If n1 > n2 And n1 > n3 Then
            Console.WriteLine("Max is {0}", n1)
        ElseIf n2 > n1 And n2 > n3 Then
            Console.WriteLine("Max is {0}", n2)
        Else
            Console.WriteLine("Max is {0}", n3)
        End If
    End Sub
    Function MaxNb(ByVal n1 As Decimal, ByVal n2 As Decimal, ByVal n3 As Decimal) As Decimal
        If n1 > n2 And n1 > n3 Then
            Return n1
        ElseIf n2 > n1 And n2 > n3 Then
            Return n2
        Else
            Return n3
        End If
    End Function
    Sub ListSub()
        Dim str As String
        For i = 0 To 4
            Console.Write("String element: ")
            str = Console.ReadLine()
            strList.Add(str)
        Next
    End Sub
    Sub DisplaySu()
        Console.Clear()
        Console.WriteLine("List elements:")
        For Each str As String In strList
            Console.WriteLine(str)
        Next
    End Sub
    Function Search(ByVal searchValue As String) As Integer
        'Dim found As Boolean = False
        Dim index As Integer
        index = strList.IndexOf(searchValue)
        If index >= 0 Then
            Return index
        Else
            Return -1
        End If
    End Function
End Module
