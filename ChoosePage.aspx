<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ChoosePage.aspx.vb" Inherits="ChoosePage" title="DatDoc Group/Choose Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function DIV1_onclick() {

}

// ]]>
</script>

    <div style="z-index: 102; left: 79px; width: 814px; position: absolute; top: 3px;
        height: 276px">
        <table style="width: 121px; height: 247px;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" ForeColor="yellow" Text="Patient Personal Record is shown in  below. If anything wrong, Please contact DatDoc."
                        Width="685px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 110px; height: 29px; font-size: 11pt;">
                    NIN</td>
                <td style="font-size: 11pt; width: 218px; height: 29px">
                    <asp:TextBox ID="txtNIN_Number" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
                <td style="width: 1px; height: 29px; font-size: 11pt;">
                    </td>
            </tr>
            <tr>
                <td style="width: 110px; height: 29px; font-size: 11pt;">
                    Fore Name</td>
                <td style="font-size: 11pt; width: 218px; height: 29px">
                    <asp:TextBox ID="txtFirstName" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
                <td style="width: 1px; height: 29px; font-size: 11pt;">
                    </td>
            </tr>
            <tr>
                <td style="width: 110px; height: 29px; font-size: 11pt;">
                    Sur Name</td>
                <td style="font-size: 11pt; width: 218px; height: 29px">
                    <asp:TextBox ID="txtFamilyName" runat="server" Height="29px" ReadOnly="True" Width="145px"></asp:TextBox></td>
                <td style="width: 1px; height: 29px; font-size: 11pt;">
                    </td>
            </tr>
            <tr>
                <td style="width: 110px; height: 28px; font-size: 11pt;">
                    DOB</td>
                <td style="font-size: 11pt; width: 218px; height: 28px">
                    <asp:TextBox ID="txtDOB" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
                <td style="width: 1px; height: 28px; font-size: 11pt;">
                    </td>
            </tr>
            <tr>
                <td style="width: 110px; height: 29px; font-size: 11pt;">
                    Gender</td>
                <td style="font-size: 11pt; width: 218px; height: 29px">
                    <asp:TextBox ID="txtGender" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
                <td style="width: 1px; height: 29px; font-size: 11pt;">
                    </td>
            </tr>
            <tr>
                <td style="width: 110px; height: 29px; font-size: 11pt;">
                    Marital Status</td>
                <td style="font-size: 11pt; width: 218px; height: 29px">
                    <asp:TextBox ID="txtStatus" runat="server" Height="28px" ReadOnly="True" Width="145px"></asp:TextBox></td>
                <td style="width: 1px; height: 29px; font-size: 11pt;">
                    </td>
            </tr>
        </table>
        <div id="DIV1" style="z-index: 101; left: 890px; width: 121px; position: absolute;
            top: -5px; height: 30px" onclick="return DIV1_onclick()">
            <div style="z-index: 101; left: 864px; width: 38px; position: absolute; top: 0px;
                height: 29px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HomePage.aspx" Width="146px">Login for Appointment</asp:HyperLink></div>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/HomePage.aspx" Width="110px">Home Page</asp:HyperLink></div>
    </div>
    <br />
    <div style="z-index: 101; left: 255px; width: 216px; position: absolute; top: 289px;
        height: 1px">
        &nbsp;<asp:LinkButton ID="lbAppointment" runat="server" BorderStyle="Outset" Width="95px" ForeColor ="#000000">Appointment</asp:LinkButton>
        &nbsp; &nbsp;
        <asp:LinkButton ID="lbRegister" runat="server" BorderStyle="Outset" Width="63px" ForeColor ="#000000">Register</asp:LinkButton><br />
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
</asp:Content>

