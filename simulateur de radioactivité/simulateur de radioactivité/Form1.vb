Public Class Form1
    Dim zzz As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ListBox1.Items.Clear()
            Dim etape As Integer = 0
            Dim nbnoyaux As ULong = TextBox1.Text
            TextBox3.Text = etape
            TextBox2.Text = nbnoyaux
            Do
                For i As Integer = 1 To nbnoyaux
                    Dim bool As Boolean = Int(Rnd() * 2)
                    Select Case bool
                        Case 1
                            nbnoyaux = nbnoyaux - 1
                            TextBox2.Text = nbnoyaux
                        Case Else

                    End Select
                Next
                zzz = "Etape: " + etape.ToString + "   " + "Nombre restant: " + nbnoyaux.ToString
                ListBox1.Items.Add(zzz)
                etape = etape + 1
                TextBox3.Text = etape
                Refresh()
                TextBox2.Refresh()
                TextBox3.Refresh()
                ListBox1.Refresh()
            Loop While nbnoyaux <> 0
        Catch ex As Exception
            MsgBox("vous devez inserer un nombre de noyaux")
        End Try
    End Sub

End Class
