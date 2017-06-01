Imports System.IO

Partial Class DoctorPage
    Inherits System.Web.UI.Page
    Dim str As String
    Dim strR As StreamReader
    Dim register As String
    Dim tablefield As String
    Dim count As Integer

    Structure Appointment
        Public AppointmentNo As String
        Public NIN As String
        Public ForeName As String
        Public SurName As String
        Public DateOfBirth As String
        Public Sex As String
        Public MaritalStatus As String
        Public PreferredDate As String
        Public AppointmentDate As String
        Public DoctorID As String
        Public Doctorname As String
        Public Specialist As String
        Public Diagnosis As String
        Public Status As String
        Public Password As String
    End Structure

    Dim strappointment As Appointment
    Dim arrAppointment() As Appointment
    Dim intArrIndex As Integer
    Dim dt As New Data.DataTable
    Dim dr As Data.DataRow

    Public Sub createdatatable(ByVal datatable As Data.DataTable)
        datatable.Columns.Clear()
        datatable.Columns.Add("AppointmentNo")
        datatable.Columns.Add("NIN")
        datatable.Columns.Add("Fore Name")
        datatable.Columns.Add("Sur Name")
        datatable.Columns.Add("Date Of Birth")
        datatable.Columns.Add("Sex")
        datatable.Columns.Add("Marital Status")
        datatable.Columns.Add("Preferred Date")
        datatable.Columns.Add("Appointment Date")
        datatable.Columns.Add("Doctor ID")
        datatable.Columns.Add("Doctor Name")
        datatable.Columns.Add("Specialist")
        datatable.Columns.Add("Diagnosis")
        datatable.Columns.Add("Status")
        datatable.Columns.Add("Password")
    End Sub

    Public Sub doctorinfo()  'to show the doctor name and speciality area in the doctor screen even the appointed patient does not exist
        'Dim strr As New StreamReader(Server.MapPath("") & "\App_Data\DoctorRecord.txt")
        'Dim str, specialist, name, password As String
        'Dim strSplit() As String
        'Dim pw As String = Request.QueryString("Password")
        'Try
        '    str = strr.ReadLine()
        '    While (str <> Nothing)
        '        strSplit = str.Split(System.Convert.ToChar(","))
        '        str = strr.ReadLine()
        '        name = strSplit(2)
        '        specialist = strSplit(10)
        '        password = strSplit(1)
        '        If password = pw Then
        '            lblDoctorName.Text = name
        '            lblSepcialityArea.Text = specialist
        '        End If
        '    End While
        'Catch ex As Exception
        'End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'doctorinfo()
        'createdatatable(dt)
        'dt.Rows.Clear()
        ''strR = New StreamReader(Server.MapPath("") & "\App_Data\DatDoc Local Database.txt")
        'Dim strType, strDoctorID As String
        'strType = Request.QueryString("paraType")
        'strDoctorID = Request.QueryString("Password")
        'Dim strSplit() As String
        'Try
        '    str = strR.ReadLine()
        '    While (str <> Nothing)
        '        count += 1
        '        ReDim Preserve arrAppointment(intArrIndex)
        '        strSplit = str.Split(System.Convert.ToChar(","))
        '        strappointment.AppointmentNo = strSplit(0)
        '        strappointment.NIN = strSplit(1)
        '        strappointment.ForeName = strSplit(2)
        '        strappointment.SurName = strSplit(3)
        '        strappointment.DateOfBirth = strSplit(4)
        '        strappointment.MaritalStatus = strSplit(6)
        '        strappointment.Sex = strSplit(5)
        '        strappointment.PreferredDate = strSplit(7)
        '        strappointment.AppointmentDate = strSplit(8)
        '        strappointment.DoctorID = strSplit(9)
        '        strappointment.Doctorname = strSplit(10)
        '        strappointment.Specialist = strSplit(11)
        '        strappointment.Diagnosis = strSplit(12)
        '        strappointment.Status = strSplit(13)
        '        strappointment.Password = strSplit(14)
        '        arrAppointment(intArrIndex) = strappointment
        '        Dim todaydate As String = Today.Date

        '        If todaydate = strSplit(7) Then 'to show patients list only for today
        '            If strappointment.Password = strDoctorID Then
        '                lblMessage.Visible = False
        '                lblDoctorName.Text = strSplit(10)  ' to show the doctor name in the doctor screen if appointed patient exists
        '                lblSepcialityArea.Text = strSplit(11) '' to show the speciality area in the doctor screen if appointed patient exists
        '                dr = dt.NewRow 'to add new row in data table
        '                dr.Item(0) = strappointment.AppointmentNo
        '                dr.Item(1) = strappointment.NIN
        '                dr.Item(2) = strappointment.ForeName
        '                dr.Item(3) = strappointment.SurName
        '                dr.Item(6) = strappointment.MaritalStatus
        '                dr.Item(4) = strappointment.DateOfBirth
        '                dr.Item(5) = strappointment.Sex
        '                dr.Item(7) = strappointment.PreferredDate
        '                dr.Item(8) = strappointment.AppointmentDate
        '                dr.Item(9) = strappointment.DoctorID
        '                dr.Item(10) = strappointment.Doctorname
        '                dr.Item(11) = strappointment.Specialist
        '                dr.Item(12) = strappointment.Diagnosis
        '                dr.Item(13) = strappointment.Status
        '                dr.Item(14) = strappointment.Password
        '                dt.Rows.Add(dr)
        '            End If
        '        End If
        '        intArrIndex += 1
        '        str = strR.ReadLine()
        '    End While
        '    gv1.DataSource = dt
        '    gv1.DataBind()
        '    If dt.Rows.Count = 0 Then
        '        lblMessage.Text = "There is no appointment"
        '        lblMessage.Visible = True
        '    End If
        '    If str = Nothing Then
        '    End If
        'Catch ex As Exception
        'End Try
        'strR.Close()
    End Sub
End Class

