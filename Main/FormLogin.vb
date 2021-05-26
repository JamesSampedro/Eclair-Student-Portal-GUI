Imports System.Data.OleDb
Public Class FormLogin

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        MsgBox("Login Success!", MsgBoxStyle.Information)
        Me.Hide()
        FormAdminMenu.Show()
    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserType.SelectedIndexChanged
        If cmbUserType.SelectedIndex = 0 Then
            btnAdminLogin.Enabled = True
            btnStudentLogin.Enabled = False

        ElseIf cmbUserType.SelectedIndex = 1 Then
            btnAdminLogin.Enabled = False
            btnStudentLogin.Enabled = True

        End If
    End Sub
End Class