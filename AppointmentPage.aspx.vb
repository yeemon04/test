Imports System.IO

Partial Class AppointmentPage
    Inherits System.Web.UI.Page
    Dim dayp As Date
    Dim dayc As Date
    Dim getcday, getpday As Integer
    Dim getparacday, getparapday As String
    Dim doctorID As String
    Dim Password As String
    Dim AppointmentNo As String
    Dim strNIN, strType As String
    Dim dt As New Data.DataTable
    Dim objPat As New DataSetTableAdapters.NationalDatabaseTableAdapter
    Dim objDatdoc As New DataSetTableAdapters.DatDocLocalDatabaseTableAdapter


    Public Sub ClearData()
        txtNIN.Text = ""
        lblForeName.Text = ""
        lblSurName.Text = ""
        ddlMaritalStatus.SelectedIndex = 0
        lblSex.Text = ""
        lblDateOfBirth.Text = ""
        ddlSpecialist.SelectedIndex = 0
        lblDoctorName.Text = ""
        ddlpreferredDate.SelectedIndex = 0
        txtDiagnosis.Text = ""
        lblAppointmentNo.Text = ""
    End Sub

    Private Sub autoID()
      
        If AppointmentNo = "" Then
            lblAppointmentNo.Text = "App-000001"
        Else
            lblAppointmentNo.Text = "App-" & Format(Microsoft.VisualBasic.Right(AppointmentNo, 6) + 1, "000000")
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        autoID()
        Label4.Text = Today.Date
        InsertDate()

        strNIN = Request.QueryString("ParaNIN")
        strType = Request.QueryString("ParaType")
        If strType = "Patient" Then
            txtNIN.Enabled = False
            txtNIN.Text = strNIN
            fillpatient()
        ElseIf strType = "Receptionist" Then
            txtNIN.Enabled = True
        ElseIf strType = "Doctor" Then
            txtNIN.Enabled = False
        End If
    End Sub

    Public Sub InsertDate()
        Dim day As String
        Dim cday As Integer
        For cday = 0 To 41
            day = Today.AddDays(cday)
            ddlpreferredDate.Items.Add(day)
        Next cday
    End Sub

    Private Sub fillpatient()
        txtNIN.Text = strNIN
        dt = objPat.NationalDatabase_Select_NIN(txtNIN.Text)
        lblForeName.Text = dt.Rows(0).Item(1)
        lblSurName.Text = dt.Rows(0).Item(2)
        lblDateOfBirth.Text = dt.Rows(0).Item(4)
        lblSex.Text = dt.Rows(0).Item(5)
        ddlMaritalStatus.Text = dt.Rows(0).Item(3)
    End Sub

    Protected Sub ddlSpecialist_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlSpecialist.SelectedIndexChanged
        lblmessage2.Visible = False
        If ddlSpecialist.SelectedItem.Text = "ENT" Or ddlSpecialist.SelectedItem.Text = "Pedictric Specialist" Then
            lblDoctorName.Text = "Dr.Susan Klam"
            Label2.Text = "CC"
            Label3.Text = "D-004"
        ElseIf ddlSpecialist.SelectedItem.Text = "Oncology" Or ddlSpecialist.SelectedItem.Text = "Hematology" Then
            lblDoctorName.Text = "Dr.Neil O'Conneral"
            Label2.Text = "DD"
            Label3.Text = "D-005"
        ElseIf ddlSpecialist.SelectedItem.Text = "Pulmonary" Then
            lblDoctorName.Text = "Dr.Lily Vilcam"
            Label2.Text = "FF"
            Label3.Text = "D-002"
        ElseIf ddlSpecialist.SelectedItem.Text = "Urologist" Then
            lblDoctorName.Text = "Dr.Kevin Collen"
            Label3.Text = "D-001"
            Label2.Text = "AA"
        ElseIf ddlSpecialist.SelectedItem.Text = "Surgeon" Or ddlSpecialist.SelectedItem.Text = "Plastic Surgery" Then
            lblDoctorName.Text = "Dr.Frank Galler"
            Label2.Text = "EE"
            Label3.Text = "D-003"
        ElseIf ddlSpecialist.SelectedItem.Text = "Endocrinology" Or ddlSpecialist.SelectedItem.Text = "Metabolism" Or ddlSpecialist.SelectedItem.Text = "Internal Medicine" Then
            lblDoctorName.Text = "Dr.Ben Dellin"
            Label2.Text = "GG"
            Label3.Text = "D-007"
        ElseIf ddlSpecialist.SelectedItem.Text = "Dentist" Then
            lblDoctorName.Text = "Dr.Rose Miller"
            Label2.Text = "BB"
            Label3.Text = "D-006"
        End If
    End Sub

    Protected Sub txtNIN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNIN.TextChanged
        fillpatient()
    End Sub

    Protected Sub btnAppoint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAppoint.Click
        objDatdoc.Appointment_Insert(lblAppointmentNo.Text, txtNIN.Text, Label3.Text, Today.Date, ddlpreferredDate.Text, txtDiagnosis.Text, "Not Arrived Yet")
        lblmessagesave.Visible = True
        lblmessagesave.Text = "Appointment Information Is Successfully Saved!!!"
    End Sub

    Protected Sub btnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearData()
        lblmessagesave.Visible = False
        txtNIN.Enabled = True
        lblmessage2.Text = ""
        lblmessage.Text = ""
    End Sub
End Class
