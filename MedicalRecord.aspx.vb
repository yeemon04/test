Imports System.IO

Partial Class MedicalRecord
    Inherits System.Web.UI.Page
    Dim National As New StreamReader(Server.MapPath("") & "\App_Data\DatDoc Local Database.txt")
    Dim str As String
    Dim split() As String
    Dim Parameter As String
    Dim StrPatient As Patient
    Dim PatientArray() As Patient
    Dim ArrayIndexNo As Integer

    Public Structure Patient
        Public NIN As String
        Public ForeName As String
        Public SurName As String
        Public DOB As String
        Public Gender As String
        Public MaritalStatus As String
        Public MedicalRecord As String
        Public Status As String
    End Structure

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Parameter = Request.QueryString("NIN")
        txtNIN_Number.Text = Parameter
        Try
            str = National.ReadLine()
            While (str <> Nothing)
                ReDim Preserve PatientArray(ArrayIndexNo)
                split = str.Split(System.Convert.ToChar(","))
                StrPatient.NIN = split(1)
                StrPatient.ForeName = split(2)
                StrPatient.SurName = split(3)
                StrPatient.DOB = split(4)
                StrPatient.Gender = split(5)
                StrPatient.MaritalStatus = split(6)
                StrPatient.Status = split(13)

                If Parameter = StrPatient.NIN Then
                    txtFirstName.Text = StrPatient.ForeName
                    txtFamilyName.Text = StrPatient.SurName
                    txtDOB.Text = StrPatient.DOB
                    txtGender.Text = StrPatient.Gender
                    txtStatus.Text = StrPatient.MaritalStatus
                    lblStatus.Text = StrPatient.Status
                End If
                ArrayIndexNo += 1
                str = National.ReadLine()
            End While
        Catch ex As Exception
        End Try
        National.Close()
    End Sub

    Protected Sub btnRecord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        If lblStatus.Text = "Arrive" Then
            If TextBox1.Text = "" Then
                Label1.Text = "Please Record Patient's medical information"
                Label1.Visible = True
            Else
                Dim MedicalRecord As New StreamWriter(Server.MapPath("") & "\App_Data\MedicalRecord.txt", True)
                Dim strTemp As String
                strTemp = txtNIN_Number.Text & "," & TextBox1.Text
                MedicalRecord.WriteLine(strTemp)
                MedicalRecord.Close()
                Label1.Text = ""
                lblMessage.Text = "Medical Record is sent to DacDot Group"
                lblMessage.Visible = True
            End If
        Else
            lblMessage.Text = "Cannot Record Medical Information because the patient does not arrive yet!"
            lblMessage.Visible = True
        End If
    End Sub
End Class
