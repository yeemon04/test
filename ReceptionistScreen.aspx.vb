Imports System.IO

Partial Class ReceptionistScreen
    Inherits System.Web.UI.Page
    Dim str, tf, strType, acceptapp, accUserType As String
    Dim strR As StreamReader
    Dim count As Integer
    Dim AFSearch As Boolean = False
    Dim acceptNIN As String
    Dim dt, dt2 As New Data.DataTable
    Dim objApp As New DataSetTableAdapters.DatDocLocalDatabaseTableAdapter
    Dim view_rep As New DataSetTableAdapters.View_ReceptionistTableAdapter

    Public Sub Gridview(ByVal datatable As Data.DataTable)
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

    End Sub
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'rdo1.Enabled = False
        'btnOK.Enabled = False
        'lblErrorMessage.Text = ""
        strType = Request.QueryString("paraType")
        Appinfo()
        'acceptapp = Request.QueryString("AppointmentNo")
        'NotUpdateAppointment = acceptapp
        'If acceptapp <> "" Then
        '    Dim acceptSInfo, acceptSTInfo As String
        '    acceptSInfo = Session("acceptSearchInfo")
        '    acceptSTInfo = Session("acceptSearchType")
        '    Searching(acceptSInfo, acceptSTInfo)
        '    rdo1.Enabled = True
        '    btnOK.Enabled = True
        'End If
    End Sub

    Public Sub Searching(ByVal searchinfo As String, ByVal searchType As String)
        'acceptSearchinfo = searchinfo
        'aptSearchType = searchType
        'Dim n As String
        'Dim dob As String
        'Gridview(dt2)
        'Dim countforPatient As Integer
        'Dim intGridViewcount As Integer = dt.Rows.Count
        'For i As Integer = 0 To dt.Rows.Count - 1
        '    If searchType = "Patient Sur Name" Then
        '        tf = dt.Rows(i).Item(3)
        '        n = acceptSearchinfo.Substring(0, 1)
        '    ElseIf searchType = "Patient Fore Name" Then
        '        tf = dt.Rows(i).Item(2)
        '        n = acceptSearchinfo.Substring(0, 1)
        '    ElseIf searchType = "Patient's Month of Birth" Then
        '        tf = Month(dt.Rows(i).Item(4))
        '        dob = acceptSearchinfo
        '    End If
        '    If searchType = "Patient Sur Name" Or searchType = "Patient Fore Name" Then
        '        If n.ToUpper.Equals(tf.Substring(0, 1)) Then
        '            countforPatient += 1
        '            dr2 = dt2.NewRow 'to add new row in data table
        '            dr2.Item(0) = dt.Rows(i).Item(0)
        '            dr2.Item(1) = dt.Rows(i).Item(1)
        '            dr2.Item(2) = dt.Rows(i).Item(2)
        '            dr2.Item(3) = dt.Rows(i).Item(3)
        '            dr2.Item(4) = dt.Rows(i).Item(4)
        '            dr2.Item(5) = dt.Rows(i).Item(5)
        '            dr2.Item(6) = dt.Rows(i).Item(6)
        '            dr2.Item(7) = dt.Rows(i).Item(7)
        '            dr2.Item(8) = dt.Rows(i).Item(8)
        '            dr2.Item(9) = dt.Rows(i).Item(9)
        '            dr2.Item(10) = dt.Rows(i).Item(10)
        '            dr2.Item(11) = dt.Rows(i).Item(11)
        '            dr2.Item(12) = dt.Rows(i).Item(12)
        '            dr2.Item(13) = dt.Rows(i).Item(13)
        '            dr2.Item(14) = dt.Rows(i).Item(14)
        '            dt2.Rows.Add(dr2)
        '        Else
        '            lblErrorMessage.Visible = True
        '            lblErrorMessage.Text = "Data do not found. Please search again"
        '            txtsearch.Text = ""
        '            txtsearch.Focus()
        '        End If

        '    ElseIf searchType = "Patient's Month of Birth" Then
        '        If dob = tf Then
        '            countforPatient += 1
        '            dr2 = dt2.NewRow 'to add new row in data table
        '            dr2.Item(0) = dt.Rows(i).Item(0)
        '            dr2.Item(1) = dt.Rows(i).Item(1)
        '            dr2.Item(2) = dt.Rows(i).Item(2)
        '            dr2.Item(3) = dt.Rows(i).Item(3)
        '            dr2.Item(4) = dt.Rows(i).Item(4)
        '            dr2.Item(5) = dt.Rows(i).Item(5)
        '            dr2.Item(6) = dt.Rows(i).Item(6)
        '            dr2.Item(7) = dt.Rows(i).Item(7)
        '            dr2.Item(8) = dt.Rows(i).Item(8)
        '            dr2.Item(9) = dt.Rows(i).Item(9)
        '            dr2.Item(10) = dt.Rows(i).Item(10)
        '            dr2.Item(11) = dt.Rows(i).Item(11)
        '            dr2.Item(12) = dt.Rows(i).Item(12)
        '            dr2.Item(13) = dt.Rows(i).Item(13)
        '            dr2.Item(14) = dt.Rows(i).Item(14)
        '            dt2.Rows.Add(dr2)
        '        Else
        '            lblErrorMessage.Visible = True
        '            lblErrorMessage.Text = "Data do not found. Please search again"
        '            txtsearch.Text = ""
        '            txtsearch.Focus()
        '        End If
        '    End If
        'Next
        'gv1.Visible = True
        'If dt2.Rows.Count <> 0 Then
        '    lblErrorMessage.Text = ""
        'End If
        'gv1.DataSource = dt2
        'gv1.DataBind()
        'Session("acceptSearchType") = aptSearchType
        'Session("acceptSearchInfo") = acceptSearchinfo
    End Sub

    Public Sub Appinfo()
        strType = Request.QueryString("ParaType")
        str = Request.QueryString("ParaNIN")
        If strType = "Receptionist" Then
            btnShowAll.Enabled = True
            dt = view_rep.GetData()
        Else
            btnShowAll.Enabled = False
            dt = view_rep.View_Receptionist_SelectPatientNIN(str)
        End If
        gv1.DataSource = dt
        'gv1.Visible = False
    End Sub

    Protected Sub ddlSearchBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlSearchBy.SelectedIndexChanged
        lblErrorMessage.Text = ""
        If ddlSearchBy.Text = "Patient Fore Name" Then
            lblmessage.Text = "Please enter Patient Fore Name"
            lblmessage.Visible = True
        ElseIf ddlSearchBy.Text = "Patient Sur Name" Then
            lblmessage.Text = "Please enter Patient Sur Name"
            lblmessage.Visible = True
        ElseIf ddlSearchBy.Text = "Patient's Month of Birth" Then
            lblmessage.Text = "Please enter Patient's Month of Birth"
            lblmessage.Visible = True
        End If
    End Sub
    'Public Sub Updatearrive()
    '    For i As Integer = 0 To dt2.Rows.Count - 1
    '        If dt2.Rows(i).Item(7) = Today.Date Then
    '            lblErrorMessage.Text = ""
    '            If NotUpdateAppointment = dt.Rows(i).Item(0) Then
    '                dt.Rows(i).Item(13) = "Arrive"
    '            End If
    '        Else
    '            lblErrorMessage.Text = "You are allowed to register your arrival for today only."
    '            lblErrorMessage.Visible = True
    '        End If
    '    Next
    '    SaveData()
    'End Sub

    'Public Sub Updatetextfile()
    '    For cancelcount As Integer = 0 To dt.Rows.Count - 1
    '        If NotUpdateAppointment = dt.Rows(cancelcount).Item(0) Then
    '            dt.Rows(cancelcount).Delete()
    '            acceptNIN = Session("NIN")

    '            For ii As Integer = 0 To gv1.Rows.Count - 1
    '                If NotUpdateAppointment = dt2.Rows(ii).Item(0) Then
    '                    dt2.Rows(ii).Delete()
    '                    gv1.DataSource = dt2
    '                    gv1.DataBind()
    '                    SaveData()
    '                    Exit Sub

    '                End If
    '            Next
    '        End If
    '    Next


    'End Sub

    'Public Sub Updateexitfile2()
    '    For cancelcount As Integer = 0 To dt.Rows.Count - 1
    '        If acceptNIN = dt.Rows(cancelcount).Item(1) Then
    '            dt.Rows(cancelcount).Delete()
    '            acceptNIN = Session("NIN")
    '            For ii As Integer = 0 To gv1.Rows.Count - 1
    '                If acceptNIN = dt2.Rows(ii).Item(1) Then
    '                    dt2.Rows(ii).Delete()
    '                    gv1.DataSource = dt2
    '                    gv1.DataBind()
    '                    SaveData()
    '                    Exit Sub

    '                End If
    '            Next
    '        Else
    '            lblErrorMessage.Text = "Your appointment is already canceled."
    '            lblErrorMessage.Visible = True
    '        End If
    '    Next


    'End Sub

    Protected Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'acceptNIN = Session("NIN")
        'lblErrorMessage.Text = ""
        'aptUserType = Session("UserType")
        'If rdo1.SelectedValue = "Arrive" Then
        '    lblErrorMessage.Text = ""
        '    For countNIN As Integer = 0 To dt2.Rows.Count - 1
        '        If aptUserType = "Patient" Then
        '            dt2 = gv1.DataSource
        '            For ii As Integer = 0 To gv1.Rows.Count - 1
        '                If acceptNIN = dt2.Rows(ii).Item("NIN") Then
        '                    If dt2.Rows(ii).Item(7) = Today.Date Then

        '                        dt2.Rows(ii).Item("Status") = "Arrive"
        '                        gv1.DataSource = dt2
        '                        gv1.DataBind()
        '                    Else
        '                        lblErrorMessage.Text = "You are allowed to register your arrival for today only."
        '                        lblErrorMessage.Visible = True
        '                        Exit Sub
        '                    End If

        '                End If
        '                lblErrorMessage.Text = ""
        '            Next
        '            For a As Integer = 0 To gv1.Rows.Count - 1
        '                If acceptNIN = dt2.Rows(a).Item("NIN") Then
        '                    If dt2.Rows(a).Item(7) = Today.Date Then

        '                        Updatearrive()
        '                    Else
        '                        lblErrorMessage.Text = "You are allowed to register your arrival for today only."
        '                        lblErrorMessage.Visible = True
        '                        Exit Sub
        '                    End If
        '                End If
        '            Next

        '        End If
        '        If aptUserType = "Receptionist" Then
        '            dt2 = gv1.DataSource
        '            For ii As Integer = 0 To gv1.Rows.Count - 1
        '                If NotUpdateAppointment = dt2.Rows(ii).Item(0) Then

        '                    If dt2.Rows(ii).Item(7) = Today.Date Then

        '                        dt2.Rows(ii).Item("Status") = "Arrive"
        '                        gv1.DataSource = dt2
        '                        gv1.DataBind()
        '                    Else
        '                        lblErrorMessage.Text = "You are allowed to register your arrival for today only."
        '                        lblErrorMessage.Visible = True
        '                        Exit Sub
        '                    End If
        '                End If
        '            Next
        '            Updatearrive()
        '        End If
        '    Next

        'ElseIf rdo1.SelectedValue = "Cancel" Then
        '    lblErrorMessage.Text = ""
        '    If aptUserType = "Patient" Then
        '        For ii As Integer = 0 To gv1.Rows.Count - 1
        '            If acceptNIN = dt2.Rows(ii).Item("NIN") Then
        '                Updateexitfile2()
        '                Exit Sub
        '            End If
        '        Next
        '    End If

        '    If aptUserType = "Receptionist" Then
        '        Updatetextfile()
        '    End If
        'Else
        '    lblErrorMessage.Text = "Please choose radio button"
        'End If


    End Sub

    'Private Sub SaveData()
    '    Dim STWriter As New IO.StreamWriter(Server.MapPath("") & "\App_Data\DatDoc Local Database.txt")
    '    Dim i As Integer
    '    For i = 0 To dt.Rows.Count - 1
    '        Dim strTemp As String
    '        strTemp = dt.Rows(i).Item(0).ToString & "," & dt.Rows(i).Item(1).ToString & "," & dt.Rows(i).Item(2).ToString & "," & dt.Rows(i).Item(3).ToString & "," & dt.Rows(i).Item(4).ToString & "," & dt.Rows(i).Item(5).ToString & "," & dt.Rows(i).Item(6).ToString & "," & dt.Rows(i).Item(7).ToString & "," & dt.Rows(i).Item(8).ToString & "," & dt.Rows(i).Item(9).ToString & "," & dt.Rows(i).Item(10).ToString & "," & dt.Rows(i).Item(11).ToString & "," & dt.Rows(i).Item(12).ToString & "," & dt.Rows(i).Item(13).ToString & "," & dt.Rows(i).Item(14).ToString
    '        STWriter.WriteLine(strTemp)
    '    Next
    '    STWriter.Close()
    'End Sub

    Protected Sub btnShowAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        Page_Load(sender, e)
        gv1.Visible = True
        gv1.Enabled = False
    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtsearch.Text = "" Then
            lblmessage.Text = "Please choose one keyword"
            lblmessage.Visible = True
            txtsearch.Focus()
        Else
            AFSearch = True
            gv1.Enabled = True
            '            Appinfo()
            Searching(txtsearch.Text, ddlSearchBy.Text)
        End If
    End Sub
End Class


