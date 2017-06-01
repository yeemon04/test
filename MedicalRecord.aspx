<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="MedicalRecord.aspx.vb" Inherits="MedicalRecord" title="DatDoc Group/Patient Medical Record" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="z-index: 101; left: 76px; width: 711px; position: absolute; top: 38px;
        height: 385px">
    <table style="width: 629px; height: 390px;">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; color: #0000ff">
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label></td>
        </tr>
        <tr style="color: #0000ff">
            <td align="center" colspan="2" style="font-weight: bold; color: #0000ff">
                PATIENT'S MEDICAL RECORD</td>
        </tr>
        <tr>
            <td style="width: 197px; height: 37px; font-size: 11pt;">
                NIN</td>
            <td style="width: 197px; height: 37px; font-size: 11pt;">
                <asp:TextBox ID="txtNIN_Number" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox>&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 197px; height: 35px; font-size: 11pt;">
                Fore Name</td>
            <td style="width: 197px; height: 35px; font-size: 11pt;">
                <asp:TextBox ID="txtFirstName" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 197px; height: 34px; font-size: 11pt;">
                Sur Name</td>
            <td style="width: 197px; height: 34px; font-size: 11pt;">
                <asp:TextBox ID="txtFamilyName" runat="server" Height="29px" ReadOnly="True" Width="145px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 197px; height: 34px; font-size: 11pt;">
                DOB</td>
            <td style="width: 197px; height: 34px; font-size: 11pt;">
                <asp:TextBox ID="txtDOB" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 197px; height: 32px; font-size: 11pt;">
                Marital Status</td>
            <td style="width: 197px; height: 32px; font-size: 11pt;">
                <asp:TextBox ID="txtGender" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 197px; height: 33px; font-size: 11pt;">
                Gender</td>
            <td style="width: 197px; height: 33px; font-size: 11pt;">
                <asp:TextBox ID="txtStatus" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 197px; font-size: 11pt; height: 35px;">
                Medical Record</td>
            <td style="width: 197px; font-size: 11pt; height: 35px;">
                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="145px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 197px; height: 35px">
                <asp:Label ID="lblStatus" runat="server" Visible="False"></asp:Label></td>
            <td style="width: 14px; height: 35px">
                <asp:Label ID="Label1" runat="server" ForeColor="Red" Visible="False" Width="436px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 197px; height: 30px">
            </td>
            <td style="width: 14px; height: 30px">
                <asp:Button ID="btnRecord" runat="server" Text="Record" Height="30px" Width="90px" />&nbsp;</td>
        </tr>
    </table>
        <div style="z-index: 101; left: 782px; width: 231px; position: absolute; top: -39px;
            height: 26px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DoctorPage.aspx" Width="106px">Doctor Page</asp:HyperLink>
            &nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/HomePage.aspx" Width="107px">Home Page</asp:HyperLink></div>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

