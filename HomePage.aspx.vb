Imports System.IO

Partial Class HomePage
    Inherits System.Web.UI.Page
    Dim i As Integer
    Dim objDoc As New DataSetTableAdapters.DoctorTableAdapter
    Dim objRep As New DataSetTableAdapters.RecepitionistTableAdapter
    Dim objPat As New DataSetTableAdapters.NationalDatabaseTableAdapter
    Dim dtlogin As New Data.DataTable
    Dim ForeName, SurName As String

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ddlusertype.SelectedIndex = 0
        txtNIN.Text = ""
        txtUserNAme.Text = ""
    End Sub


    Protected Sub btnLogIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Dim i As Integer = dtlogin.Rows.Count

        If ddlusertype.Text = "" Then
            lblmessage.Text = "Please choose User Type from the combo box"
        ElseIf txtUserNAme.Text = "" Then
            lblmessage.Text = "Please enter User Name"
        ElseIf txtNIN.Text = "" Then
            lblmessage.Text = "Please enter National Insurance Number"
        Else
            If ddlusertype.Text = "Doctor" Then
                dtlogin = objDoc.GetData()
                For i = 0 To dtlogin.Rows.Count - 1
                    If txtUserNAme.Text = dtlogin.Rows(i).Item(2) And txtNIN.Text = dtlogin.Rows(i).Item(1) Then
                        Response.Redirect("DoctorPage.aspx")
                        Exit Sub
                    ElseIf txtUserNAme.Text <> dtlogin.Rows(i).Item(2) Or txtNIN.Text <> dtlogin.Rows(i).Item(1) Then
                        lblmessage.Text = "User Name and National Insurance Number do not match!!"
                        'txtNIN.Focus()
                        'txtNIN.Text = ""
                        'Exit Sub
                    End If
                Next
            ElseIf ddlusertype.Text = "Receptionist" Then
                dtlogin = objRep.GetData()
                For i = 0 To dtlogin.Rows.Count - 1
                    If txtUserNAme.Text = dtlogin.Rows(i).Item(1) And txtNIN.Text = dtlogin.Rows(i).Item(0) Then
                        Response.Redirect("ReceptionistScreen.aspx")
                        Exit Sub
                    ElseIf txtUserNAme.Text <> dtlogin.Rows(i).Item(1) Or txtNIN.Text <> dtlogin.Rows(i).Item(0) Then
                        lblmessage.Text = "User Name and National Insurance Number do not match!!"
                        'txtNIN.Focus()
                        'txtNIN.Text = ""
                        ' Exit Sub
                    End If
                Next
            ElseIf ddlusertype.Text = "Patient" Then
                dtlogin = objPat.GetData()
                For i = 0 To dtlogin.Rows.Count - 1
                    ForeName = dtlogin.Rows(i).Item(1) & " " & dtlogin.Rows(i).Item(2)
                    'SurName = dtlogin.Rows(i).Item(2)
                    If txtUserNAme.Text = ForeName And txtNIN.Text = dtlogin.Rows(i).Item(0) Then
                        Server.Transfer("ChoosePage.aspx?ParaNIN=" & txtNIN.Text & "&ParaType=" & ddlusertype.Text)
                        Response.Redirect("ChoosePage.aspx")
                        Exit Sub
                    ElseIf txtUserNAme.Text <> dtlogin.Rows(i).Item(1) & " " & dtlogin.Rows(i).Item(2) Or txtNIN.Text <> dtlogin.Rows(i).Item(0) Then
                        lblmessage.Text = "User Name and National Insurance Number do not match!!"
                        'txtNIN.Focus()
                        'txtNIN.Text = ""
                        'Exit Sub
                    End If
                Next
            End If
        End If





    End Sub
End Class








