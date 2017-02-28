' Coded by Júlio Gomes
' Version 1
' Date 10/11/2016
' @ColdDar13
Public Class Form1

    ' Cronômetro principal sendo limitado com as condições
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text -= 1
        If Label3.Text = 0 Then
            Label2.Text -= 1
            Label3.Text = "59"
        End If

        If Label2.Text = 0 Then
            Label1.Text -= 1
            Label2.Text = "59"
        End If

        If Label1.Text = 0 Then
            Label1.Text = "00"
        End If

        If Label1.Text = -1 Then
            Label2.Text = "00"
            Label3.Text = "00"
            Label1.Text = "00"
            Timer1.Stop()
            My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.WaitToComplete) ' Se o cronômetro zerar , tocar som de fim de tempo '
        End If
    End Sub

    ' Caso o botão seja pressionado , inicia-se a partida '
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    ' Caso o botão abaixo seja pressionado incrementa +1 na contagem de pontos do time 1 '
    Private Sub Maisgol1_Click(sender As Object, e As EventArgs) Handles Maisgol1.Click
        Dim var As Integer
        var = 0 ' variável var começa valendo 0 '
        var = (Gol1.Text) + 1 ' incrementa + 1 ao valor que estiver em Gol1.Text '
        Me.Gol1.Text = var ' Guarda o novo valor em var '
    End Sub

    ' Caso o botão abaixo seja pressionado decrementa -1 na contagem de pontos do time 1 '
    Private Sub menosgol1_Click(sender As Object, e As EventArgs) Handles menosgol1.Click
        Dim var As Integer
        var = 0 ' variável var começa valendo 0 '
        var = (Gol1.Text) - 1  'decrementa -1 ao valor que estiver em Gol1.Text '
        Me.Gol1.Text = var 'Guarda o novo valor '
        If Gol1.Text < 0 Then ' Condição para não subtrair menos que 0 , ou seja , se o valor for menor que zero (o que não existe em uma partida) , demonstrar o 00 '
            Gol1.Text = "00"
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Gol1.Text = "00"
    End Sub

    Private Sub MenosGol2_Click(sender As Object, e As EventArgs) Handles MenosGol2.Click
        Dim var As Integer
        var = 0
        var = (gol2.Text) - 1
        Me.gol2.Text = var
        If gol2.Text < 0 Then
            gol2.Text = "00"
        End If
    End Sub

    Private Sub MaisGol2_Click(sender As Object, e As EventArgs) Handles MaisGol2.Click
        Dim var As Integer
        var = 0
        var = (gol2.Text) + 1
        Me.gol2.Text = var
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        gol2.Text = "00"
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
    End Sub


    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Label33.Text = TimeOfDay
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Label1.Text = "10"
        Label2.Text = "00"
        Label3.Text = "60"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class