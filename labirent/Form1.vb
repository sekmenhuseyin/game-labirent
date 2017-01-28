Public Class Form1
    'ONUR SALMAN a teþekkürler

#Region "global deðiþkenler"
    Dim labirent(19, 19) As Char
    Dim amac(3) As Integer
    Dim lbl() As Label
    Dim yol As String
    Dim labirent_secimi As String

#End Region

#Region "prosedürler"

    Private Sub labirentciz()
        Dim adet, i, j As Integer, k As Integer = 0, p As Integer = 0
        adet = 400
        ReDim lbl(adet)

        For i = 0 To adet - 1
            lbl(i) = New Label()
            lbl(i).Name = "lbl" & i & 1
            Me.Controls.Add(lbl(i))
            lbl(i).Width = 17
            lbl(i).Height = 17

            If (labirent(Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 20))), i Mod 20) = "1") Then
                lbl(i).Image = Image.FromFile(yol + "\duvar.jpg")
            Else
                lbl(i).Image = Image.FromFile(yol + "\bos.jpg")
            End If

            p = i Mod 20
            lbl(i).Top = k * 17
            lbl(i).Left = p * 17

            If (p = 19) Then
                k += 1
            End If
        Next
    End Sub

    Private Sub yolyaz(ByVal dizi(,) As Integer)
        Dim i, j As Integer
        listBox1.Items.Add(dizi.GetLength(1) - 2 & " ADIMDA ÇÖZÜM")
        For i = 0 To dizi.GetLength(1) - 1
            listBox1.Items.Add(dizi(0, i) & "-" & dizi(1, i))
            lbl(dizi(0, i) * 20 + dizi(1, i)).Image = Image.FromFile(yol + "\ayak.jpg")
        Next

        MessageBox.Show("çözüm")

        For i = 1 To dizi.GetLength(1) - 1
            lbl(dizi(0, i) * 20 + dizi(1, i)).Image = Image.FromFile(yol + "\bos.jpg")
        Next

    End Sub

    Private Sub coz(ByVal x As Integer, ByVal y As Integer, ByVal yol(,) As Integer)

        Dim yeniyol(,) As Integer
        yeniyol = yol
        labirentoku()

        Dim i, j As Integer
        For i = 0 To yol.GetLength(1) - 1
            labirent(yol(0, i), yol(1, i)) = "1"
        Next

        Dim yeni(250, 250) As Integer
        For i = 0 To yeniyol.GetUpperBound(0)
            For j = 0 To yeniyol.GetUpperBound(1)
                yeni(i, j) = yeniyol(i, j)
            Next
        Next

        ReDim yeniyol(2, yol.GetLength(1) + 1)
        For i = 0 To yeniyol.GetUpperBound(0)

            For j = 0 To yeniyol.GetUpperBound(1)
                yeniyol(i, j) = yeni(i, j)
            Next
        Next

        yeniyol(0, yol.GetLength(1)) = x
        yeniyol(1, yol.GetLength(1)) = y

        If ((x = amac(2)) And (y = amac(3))) Then
            yolyaz(yeniyol)
        Else
            labirent(x, y) = Convert.ToChar("1")
            If (x >= 1) Then
                If (labirent(x - 1, y) = Convert.ToChar("0")) Then
                    coz(x - 1, y, yeniyol)
                End If
            End If
            If (x <= 18) Then
                If (labirent(x + 1, y) = Convert.ToChar("0")) Then

                    coz(x + 1, y, yeniyol)
                End If
            End If
            If (y >= 1) Then
                If (labirent(x, y - 1) = Convert.ToChar("0")) Then

                    coz(x, y - 1, yeniyol)
                End If
            End If
            If (x <= 18) Then
                If (labirent(x, y + 1) = Convert.ToChar("0")) Then
                    coz(x, y + 1, yeniyol)
                End If
            End If
        End If

    End Sub

    Private Sub labirentoku()

        Dim k As Integer = 0
        FileSystem.FileOpen(1, yol + labirent_secimi, OpenMode.Input)

        Do
            Dim i As Integer
            Dim satir() As Char
            satir = FileSystem.LineInput(1).ToCharArray()
            For i = 0 To 19
                labirent(k, i) = satir(i)
                If (satir(i) = "s") Then

                    amac(0) = k
                    amac(1) = i
                    labirent(k, i) = "0"
                End If
                If (satir(i) = "f") Then

                    amac(2) = k
                    amac(3) = i
                    labirent(k, i) = "0"
                End If
            Next
            k += 1
        Loop While (FileSystem.EOF(1) = False)
        FileSystem.FileClose(1)
    End Sub

#End Region

#Region "eventler"
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim k(1, 0) As Integer
        coz(amac(0), amac(1), k)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        yol = System.IO.Directory.GetCurrentDirectory()
        labirent_secimi = "\lbrnt.txt"
        labirentoku()
        labirentciz()
    End Sub
#End Region
End Class
