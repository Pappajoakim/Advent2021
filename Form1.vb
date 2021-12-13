Public Class Form1
    Public Datan(25, 1) As Integer
    Public D(1, 1) As Integer
    Public CheckBig(25, 1) As String
    Public AntalRätt As Integer
    Public AntalFlash As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FileName As String
        Dim TextRad As String
        TextBox1.Text = "J:\Program\Adventofcode\2021\input3.txt"
        FileName = TextBox1.Text
        TextBox2.Text = ""
        Dim AntalRader As Integer
        Dim Rad As Integer
        Dim Kolumn As Integer
        Dim Bang As Integer

        AntalRader = 0
        AntalRätt = 0
        AntalFlash = 0
        Rad = 0
        Kolumn = 0
        Bang = 0

        ' antal rader i texten
        AntalRader = System.IO.File.ReadAllLines(FileName).Length
        ReDim D(AntalRader, 13)
        Dim ObjReader As New System.IO.StreamReader(FileName)
        Do While ObjReader.Peek() <> -1
            TextRad = ObjReader.ReadLine()
            For I = 0 To 11
                D(Rad, I) = Mid(TextRad, I + 1, 1)
            Next
            Rad = Rad + 1
        Loop


        For I = 0 To 11
            TextBox2.Text = TextBox2.Text + summera(I)
        Next
        Stop
        'TextBox2.Text = Convert.ToInt32(TextBox2.Text)

        Label2.Text = "Klart"
    End Sub

    Function summera(ByVal X As Integer) As String
        Dim Noll As Integer
        Dim Ett As Integer
        Noll = 0
        Ett = 0
        For I = 0 To 1000
            If D(I, X) = "0" Then
                Ett = Ett + 1
            Else
                Noll = Noll + 1
            End If
        Next
        'Stop
        If Ett > Noll Then
            summera = "1"
        Else
            summera = "0"
        End If
        'summera = Str(Ett) + "," + Str(Noll)
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.PerformClick()
    End Sub

    Function AddOne()
        For I = 0 To 9
            For X = 0 To 9
                Datan(I, X) = Datan(I, X) + 1
            Next X
        Next I

    End Function

    Function Nolla()
        For I = 0 To 9
            For X = 0 To 9
                If Datan(I, X) < 0 Then
                    Datan(I, X) = 0
                    AntalFlash = AntalFlash + 1
                End If
            Next X
        Next I
    End Function
    Function Blast()
        For Ra = 0 To 9
            For Ko = 0 To 9
                If Datan(Ra, Ko) > 9 Then
                    Select Case Ra
                        Case 0
                            If Ko = 0 Then
                                Datan(Ra + 1, Ko) = Datan(Ra + 1, Ko) + 1
                                Datan(Ra + 1, Ko + 1) = Datan(Ra + 1, Ko + 1) + 1
                                Datan(Ra, Ko + 1) = Datan(Ra, Ko + 1) + 1
                            ElseIf Ko = 9 Then
                                Datan(Ra + 1, Ko) = Datan(Ra + 1, Ko) + 1
                                Datan(Ra + 1, Ko - 1) = Datan(Ra + 1, Ko - 1) + 1
                                Datan(Ra, Ko - 1) = Datan(Ra, Ko - 1) + 1
                            Else
                                Datan(Ra + 1, Ko) = Datan(Ra + 1, Ko) + 1
                                Datan(Ra + 1, Ko + 1) = Datan(Ra + 1, Ko + 1) + 1
                                Datan(Ra + 1, Ko - 1) = Datan(Ra + 1, Ko - 1) + 1
                                Datan(Ra, Ko + 1) = Datan(Ra, Ko + 1) + 1
                                Datan(Ra, Ko - 1) = Datan(Ra, Ko - 1) + 1
                            End If
                        Case 9
                            If Ko = 0 Then
                                Datan(Ra - 1, Ko) = Datan(Ra - 1, Ko) + 1
                                Datan(Ra - 1, Ko + 1) = Datan(Ra - 1, Ko + 1) + 1
                                Datan(Ra, Ko + 1) = Datan(Ra, Ko + 1) + 1
                            ElseIf Ko = 9 Then
                                Datan(Ra - 1, Ko) = Datan(Ra - 1, Ko) + 1
                                Datan(Ra - 1, Ko - 1) = Datan(Ra - 1, Ko - 1) + 1
                                Datan(Ra, Ko - 1) = Datan(Ra, Ko - 1) + 1
                            Else
                                Datan(Ra - 1, Ko) = Datan(Ra - 1, Ko) + 1
                                Datan(Ra - 1, Ko + 1) = Datan(Ra - 1, Ko + 1) + 1
                                Datan(Ra - 1, Ko - 1) = Datan(Ra - 1, Ko - 1) + 1
                                Datan(Ra, Ko + 1) = Datan(Ra, Ko + 1) + 1
                                Datan(Ra, Ko - 1) = Datan(Ra, Ko - 1) + 1
                            End If
                        Case Else
                            If Ko = 0 Then
                                Datan(Ra - 1, Ko) = Datan(Ra - 1, Ko) + 1
                                Datan(Ra - 1, Ko + 1) = Datan(Ra - 1, Ko + 1) + 1
                                Datan(Ra, Ko + 1) = Datan(Ra, Ko + 1) + 1
                                Datan(Ra + 1, Ko) = Datan(Ra + 1, Ko) + 1
                                Datan(Ra + 1, Ko + 1) = Datan(Ra + 1, Ko + 1) + 1
                            ElseIf Ko = 9 Then
                                Datan(Ra - 1, Ko) = Datan(Ra - 1, Ko) + 1
                                Datan(Ra - 1, Ko - 1) = Datan(Ra - 1, Ko - 1) + 1
                                Datan(Ra, Ko - 1) = Datan(Ra, Ko - 1) + 1
                                Datan(Ra + 1, Ko) = Datan(Ra + 1, Ko) + 1
                                Datan(Ra + 1, Ko - 1) = Datan(Ra + 1, Ko - 1) + 1
                            Else
                                Datan(Ra - 1, Ko) = Datan(Ra - 1, Ko) + 1
                                Datan(Ra - 1, Ko + 1) = Datan(Ra - 1, Ko + 1) + 1
                                Datan(Ra - 1, Ko - 1) = Datan(Ra - 1, Ko - 1) + 1
                                Datan(Ra, Ko + 1) = Datan(Ra, Ko + 1) + 1
                                Datan(Ra, Ko - 1) = Datan(Ra, Ko - 1) + 1
                                Datan(Ra + 1, Ko) = Datan(Ra + 1, Ko) + 1
                                Datan(Ra + 1, Ko + 1) = Datan(Ra + 1, Ko + 1) + 1
                                Datan(Ra + 1, Ko - 1) = Datan(Ra + 1, Ko - 1) + 1
                            End If
                    End Select
                    Datan(Ra, Ko) = -100
                    AntalRätt = AntalRätt + 1
                    Call Blast()
                End If
            Next
        Next
    End Function




    Function Day1() As Object
        Dim TextLine As String
        Dim FileName As String
        FileName = TextBox1.Text
        Dim AntalRader As Integer
        Dim Depth1 As Integer
        Dim Depth2 As Integer
        Dim Depth3 As Integer
        Dim AntalRätt As Integer
        Dim Deeper As Integer
        Dim PrevDepth As Integer
        AntalRader = 0
        AntalRätt = 0
        Deeper = 0
        Label1.Text = 0
        Dim ObjReader As New System.IO.StreamReader(FileName)
        Do While ObjReader.Peek() <> -1
            Depth3 = ObjReader.ReadLine()
            AntalRader = AntalRader + 1
        Loop
        Dim Depth(AntalRader) As Integer
        AntalRader = 0
        Dim ObjReader2 As New System.IO.StreamReader(FileName)
        Do While ObjReader2.Peek() <> -1
            Depth(AntalRader) = ObjReader2.ReadLine()
            AntalRader = AntalRader + 1
        Loop
        For I = 0 To 1997
            Depth1 = Depth(I) + Depth(I + 1) + Depth(I + 2)
            Depth2 = Depth(I + 1) + Depth(I + 2) + Depth(I + 3)
            If Depth1 < Depth2 Then
                AntalRätt = AntalRätt + 1
            End If
            If I = 1996 Then Stop
        Next



        Label1.Text = AntalRätt
        Label2.Text = "Klart"


    End Function
    Function Day2() As Object
        Dim FileName As String
        FileName = TextBox1.Text
        Dim AntalRader As Integer
        Dim ForW As Integer
        Dim Aim As Integer
        Dim Depth3 As Integer
        Dim AntalRätt As Integer
        AntalRader = 0
        AntalRätt = 0
        ForW = 0
        Aim = 0
        Depth3 = 0
        ' sätter in texten i en array
        Dim ObjReader As New System.IO.StreamReader(FileName)
        Do While ObjReader.Peek() <> -1
            ObjReader.ReadLine()
            AntalRader = AntalRader + 1
        Loop
        Dim Depth(AntalRader) As String
        AntalRader = 0
        Dim ObjReader2 As New System.IO.StreamReader(FileName)
        Do While ObjReader2.Peek() <> -1
            Depth(AntalRader) = ObjReader2.ReadLine()
            AntalRader = AntalRader + 1
        Loop


        For I = 0 To Depth.Length - 2
            Select Case Strings.Left(Depth(I), 1)
                Case "f"
                    ForW = ForW + Strings.Right(Depth(I), 1)
                    Depth3 = Depth3 + (Strings.Right(Depth(I), 1) * Aim)
                Case "d"
                    Aim = Aim + Strings.Right(Depth(I), 1)
                Case "u"
                    Aim = Aim - Strings.Right(Depth(I), 1)
                Case Else
                    MsgBox("fel värde")

            End Select
            'If I = 998 Then Stop

        Next



        TextBox2.Text = ForW * Depth3
        Label2.Text = "Klart"
    End Function
    Function day11()
        Dim FileName As String
        Dim TextRad As String
        FileName = TextBox1.Text
        Dim AntalRader As Integer
        Dim Rad As Integer
        Dim Kolumn As Integer
        Dim Bang As Integer

        AntalRader = 0
        AntalRätt = 0
        AntalFlash = 0
        Rad = 0
        Kolumn = 0
        Bang = 0
        ' sätter in texten i en array
        Dim ObjReader As New System.IO.StreamReader(FileName)
        Do While ObjReader.Peek() <> -1
            ObjReader.ReadLine()
            AntalRader = AntalRader + 1
        Loop
        AntalRader = 0
        Dim ObjReader2 As New System.IO.StreamReader(FileName)

        For I = 0 To 9
            TextRad = ObjReader2.ReadLine()
            For X = 0 To 9
                Datan(I, X) = Mid(TextRad, X + 1, 1)
            Next X
        Next I


        For I = 1 To 1000
            'Stop
            Call Function() AddOne()
            Call Blast()
            Call Nolla()
            If AntalFlash = 100 Then
                MsgBox(I)
                Stop
            Else
                AntalFlash = 0
            End If
        Next

        TextBox2.Text = AntalRätt
        Label2.Text = "Klart"
    End Function

    Function day12()
        Dim FileName As String
        Dim TextRad As String
        FileName = TextBox1.Text
        Dim AntalRader As Integer
        Dim Rad As Integer
        Dim Kolumn As Integer
        Dim Bang As Integer

        AntalRader = 0
        AntalRätt = 0
        AntalFlash = 0
        Rad = 0
        Kolumn = 0
        Bang = 0

        ' sätter in texten i en array
        Dim ObjReader As New System.IO.StreamReader(FileName)
        Do While ObjReader.Peek() <> -1
            TextRad = ObjReader.ReadLine()
            AntalRader = AntalRader + 1
            Bang = InStr(TextRad, "-")
            Datan(AntalRader - 1, 0) = Strings.Left(TextRad, Bang - 1)
            Datan(AntalRader - 1, 1) = Strings.Right(TextRad, Strings.Len(TextRad) - Bang)
        Loop
        ' checking vilka som kan besökas flera gånger.
        Stop
        For I = 0 To 25
            If Char.IsUpper(Strings.Chr(Strings.Asc(Datan(I, 0)))) = True Then
                CheckBig(I, 0) = "Y"
            Else
                CheckBig(I, 0) = "N"
            End If
            If Char.IsUpper(Strings.Chr(Strings.Asc(Datan(I, 1)))) = True Then
                CheckBig(I, 1) = "Y"
            Else
                CheckBig(I, 1) = "N"
            End If
        Next



        TextBox2.Text = AntalRätt
        Label2.Text = "Klart"
    End Function
End Class
