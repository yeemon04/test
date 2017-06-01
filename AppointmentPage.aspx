<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AppointmentPage.aspx.vb" Inherits="AppointmentPage" title="DatDoc Group/Appointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="z-index: 101; left: 76px; width: 769px; position: absolute; top: 1px;
        height: 465px">

        <table>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Consultation Appointment with Specialist" style="text-align: center" BackColor="#8080FF" Font-Bold="True" Height="40px" Width="537px"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 29px">
                    <asp:Label ID="lblmessagesave" runat="server" ForeColor="Red" Visible="False" Width="703px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    NIN</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:TextBox ID="txtNIN" runat="server" Width="145px" Height="25px"></asp:TextBox>
                    <asp:Label ID="lblmessage" runat="server" ForeColor="Red" Visible="False"></asp:Label></td>
            </tr>
            <tr style="color: #000000">
                <td style="width: 263px; font-size: 11pt;">
                    Fore Name</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:Label ID="lblForeName" runat="server" BorderColor="Black" BorderWidth="1px" Height="25px" Width="145px"></asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    Sur Name</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:Label ID="lblSurName" runat="server" BorderColor="Black" BorderWidth="1px" Height="25px" Width="145px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    Marital Status</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:DropDownList ID="ddlMaritalStatus" runat="server" Height="25px" Width="145px">
                        <asp:ListItem Value="Signle"></asp:ListItem>
                        <asp:ListItem Value="Married"></asp:ListItem>
                        <asp:ListItem Value="Divorced"></asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    Date Of Birth</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:Label ID="lblDateOfBirth" runat="server" BorderColor="Black" BorderWidth="1px" Height="25px" Width="145px"></asp:Label></td>
            </tr>
            
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    Gender</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:Label ID="lblSex" runat="server" BorderColor="Black" BorderWidth="1px" Height="25px" Width="145px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    Specialist</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:DropDownList ID="ddlSpecialist" runat="server" Height="25px" Width="145px" AutoPostBack="True">
                        <asp:ListItem>Choose Specific Type</asp:ListItem>
                        <asp:ListItem>Surgeon</asp:ListItem>
                        <asp:ListItem>ENT</asp:ListItem>
                        <asp:ListItem>Dentist</asp:ListItem>
                        <asp:ListItem>Pulmonary</asp:ListItem>
                        <asp:ListItem>Urologist</asp:ListItem>
                        <asp:ListItem>Plastic Surgery</asp:ListItem>
                        <asp:ListItem>Pedictric Specialist</asp:ListItem>
                        <asp:ListItem>Oncology</asp:ListItem>
                        <asp:ListItem>Hematology</asp:ListItem>
                        <asp:ListItem>Endocrinology</asp:ListItem>
                        <asp:ListItem>Metabolism</asp:ListItem>
                        <asp:ListItem>Internal Medicine</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    Doctor Name</td>
                <td style="width: 532px; font-size: 11pt;">
                    &nbsp;<asp:Label ID="lblDoctorName" runat="server" BorderColor="Black" BorderWidth="1px"
                        Height="25px" Width="138px"></asp:Label>
                    <asp:Label ID="lblmessage2" runat="server" ForeColor="Red" Height="23px" Width="407px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                </td>
                <td style="width: 532px; font-size: 11pt;">
                    Up to SIX weeks ahead of the current date</td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    Prefered Date</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:DropDownList ID="ddlpreferredDate" runat="server">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    Diagnosis</td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:TextBox ID="txtDiagnosis" runat="server" Height="77px" Width="190px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 263px; font-size: 11pt;">
                    </td>
                <td style="width: 532px; font-size: 11pt;">
                    <asp:Label ID="lblAppointmentNo" runat="server" BorderColor="Black" BorderWidth="1px" Height="25px"
                        Width="145px" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 263px">
                </td>
                <td style="width: 532px">
                    <asp:Button ID="btnAppoint" runat="server" Text="Appoint" />
                    <asp:Button ID="btnReset" runat="server" Text="Reset" /></td>
            </tr>
            <tr>
                <td style="width: 263px; height: 21px;">
                    </td>
                <td style="width: 532px; height: 21px">
                </td>
            </tr>
        </table>
        <br />
        <div style="z-index: 101; left: 713px; width: 297px; position: absolute; top: 4px;
            height: 30px">

        <asp:HyperLink ID="hplRegisterArrival" runat="server" NavigateUrl="~/ReceptionistScreen.aspx" Width="157px">RegisterArrival/Cancel</asp:HyperLink>
            &nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HomePage.aspx" Width="95px">Home Page</asp:HyperLink></div>
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