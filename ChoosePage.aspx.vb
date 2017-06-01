Imports System.IO
Partial Class ChoosePage
    Inherits System.Web.UI.Page
    Dim objPat As New DataSetTableAdapters.NationalDatabaseTableAdapter
    Dim str As String
    Dim Parameter, strType As String
    Dim dt As New Data.DataTable


    Protected Sub lbAppointment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbAppointment.Click
        Server.Transfer("AppointmentPage.aspx?ParaNIN=" & Parameter & "&ParaType=" & strType)
        Response.Redirect("AppointmentPage.aspx")
    End Sub

    Protected Sub lbRegister_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbRegister.Click
        Server.Transfer("ReceptionistScreen.aspx?ParaNIN=" & Parameter & "&ParaType=" & strType)
        Server.Transfer("ReceptionistScreen.aspx")
        End Sub
    'Public Structure Patient
    '    Public NIN As String
    '    Public ForeName As String
    '    Public SurName As String
    '    Public DOB As String
    '    Public Gender As String
    '    Public MaritalStatus As String
    '    '  Public MedicalRecord As String

    'End Structure


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Parameter = Request.QueryString("ParaNIN")
        strType = Request.QueryString("ParaType")
        txtNIN_Number.Text = Parameter
        dt = objPat.NationalDatabase_Select_NIN(txtNIN_Number.Text)
        txtFirstName.Text = dt.Rows(0).Item(1)
        txtFamilyName.Text = dt.Rows(0).Item(2)
        txtDOB.Text = dt.Rows(0).Item(4)
        txtGender.Text = dt.Rows(0).Item(5)
        txtStatus.Text = dt.Rows(0).Item(3)

    End Sub

    'Public Sub DispalyMedicalHistory()
    '    Parameter = Request.QueryString("ParaNIN")
    '    Try
    '        Str = Medical.ReadLine()
    '        While (str <> Nothing)
    '            ReDim Preserve PatientArray(ArrayIndexNo)
    '            split = str.Split(System.Convert.ToChar(","))
    '            StrPatient.NIN = split(1)
    '            'StrPatient.MedicalRecord = split(1)
    '            'If Parameter = StrPatient.NIN Then
    '            '    lstboxMedicalRecord.Items.Add(StrPatient.MedicalRecord)
    '            'End If
    '            ArrayIndexNo += 1
    '            str = Medical.ReadLine()
    '        End While
    '    Catch ex As Exception
    '    End Try
    '    Medical.Close()
    'End Sub

End Class

