<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="HomePage.aspx.vb" Inherits="HomePage" title="DatDoc Group/Home Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function DIV1_onclick() {

}

// ]]>
</script>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div style="z-index: 101; left: 166px; width: 583px; position: absolute; top: 51px;
        height: 161px">
        <table id="TABLE1" onclick="return TABLE1_onclick()" style="width: 582px; height: 174px">
            <tr>
                <td colspan="2" style="width: 21px; height: 33px">
                    <asp:Label ID="lblUserType" runat="server" Font-Names="Arial" Font-Size="small"
                        ForeColor="#000000" Text="User Type" Width="140px"></asp:Label></td>
                <td style="width: 308px; height: 33px">
                    <asp:DropDownList ID="ddlusertype" runat="server" Font-Size="small" Width="208px">
                        <asp:ListItem Selected="True">------Choose User Type------</asp:ListItem>
                        <asp:ListItem>Patient</asp:ListItem>
                        <asp:ListItem>Doctor</asp:ListItem>
                        <asp:ListItem>Receptionist</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2" style="width: 21px; height: 33px">
                    <asp:Label ID="lblUserName" runat="server" Font-Names="Arial" Font-Size="small" 
                        ForeColor="#000000" Text="User Name" Width="182px"></asp:Label>
                </td>
                <td style="width: 308px; height: 33px; text-align: left">
                    <asp:TextBox ID="txtUserNAme" runat="server" Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="width: 21px; height: 33px">
                    <asp:Label ID="lblpassword" runat="server" Font-Names="Arial" Font-Size="small"
                        ForeColor="Black" Text="National Insurance Number (NIN) " Width="254px"></asp:Label></td>
                <td style="width: 308px; height: 33px">
                    <asp:TextBox ID="txtNIN" runat="server" EnableTheming="True" TextMode="Password"
                        Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="width: 21px; height: 33px">
                </td>
                <td style="width: 308px; height: 33px">
                    &nbsp;<asp:Button ID="btnLogIn" runat="server" Font-Size="small" OnClick="btnLogIn_Click"
                        Text="Log In" Width="90px" />
                    &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Button ID="btnCancel" runat="server" Font-Size="small" OnClick="btnCancel_Click"
                        Text="Cancel" Width="83px" /></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 17px">
                    </td>
            </tr>
        </table>
    </div>
    <br />
    <br />
    <br />
    <div style="z-index: 102; left: 168px; width: 400px; position: absolute; top: 14px;
        height: 34px">
        <asp:Label ID="lblmessage" runat="server" ForeColor="Red" Width="397px"></asp:Label></div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

