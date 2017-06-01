<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ReceptionistScreen.aspx.vb" Inherits="ReceptionistScreen" title="DatDoc Group/Register Arrival/Cancel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="z-index: 101; left: 66px; width: 1015px; position: absolute; top: 1px;
        height: 166px">
        <div style="z-index: 101; left: 1px; width: 1009px; position: absolute; top: 169px;
            height: 303px">
            &nbsp;<br />
            <br />
            <br />
            <br />
            <div style="z-index: 102; left: 0px; width: 559px; position: absolute; top: -17px;
                height: 24px; font-size: 12pt;">
                &nbsp;
                Do You Want to:<asp:RadioButtonList ID="rdo1" runat="server">
                    <asp:ListItem>Arrive</asp:ListItem>
                    <asp:ListItem>Cancel</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="btnOK" runat="server" Text="OK" Width="90px" Height="30px" /><br />
                <br />
            <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" Height="155px" 
                Width="1007px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" ForeColor="White" GridLines="None" CellSpacing="1" Font-Bold="False">
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            </asp:GridView>
                &nbsp;<br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
        </div>
        <table style="width: 1031px; height: 113px">
            <tr>
                <td colspan="5" style="height: 30px">
                    <asp:Label ID="lblheader" runat="server" BackColor="#8080FF" Font-Bold="True" Font-Size="Larger"
                        Text="Searching for Register Arrival/ Cancel" Width="722px"></asp:Label></td>
                <td colspan="1" style="height: 30px">
                    <div style="z-index: 101; left: 770px; width: 248px; position: absolute; top: 1px;
                        height: 29px">
                        <asp:HyperLink ID="hplAppointmentPage" runat="server" NavigateUrl="~/AppointmentPage.aspx" Width="139px">AppointmentPage</asp:HyperLink>&nbsp;
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HomePage.aspx" Width="87px">Home Page</asp:HyperLink></div>
                </td>
            </tr>
            <tr>
                <td colspan="4" style="height: 17px">
                    <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Width="702px"></asp:Label></td>
                <td style="width: 314px; height: 17px">
                </td>
                <td style="width: 306px; height: 17px">
                </td>
            </tr>
            <tr>
                <td style="width: 218px; height: 2px; font-size: 11pt;">
                    Search By</td>
                <td style="width: 219px; height: 2px; font-size: 11pt;">
                    <asp:DropDownList ID="ddlSearchBy" runat="server" AutoPostBack="True" Height="27px">
                        <asp:ListItem Value="Choose one keyword"></asp:ListItem>
                        <asp:ListItem Value="Patient Fore Name"></asp:ListItem>
                        <asp:ListItem Value="Patient Sur Name"></asp:ListItem>
                        <asp:ListItem Value="Patient's Month of Birth"></asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 577px; height: 2px; font-size: 11pt;">
                    <asp:Label ID="lblmessage" runat="server"></asp:Label></td>
                <td style="width: 511px; height: 2px; font-size: 11pt;">
                    <asp:TextBox ID="txtsearch" runat="server" Height="25px"></asp:TextBox>&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="Search" Height="30px" Width="90px" />
                    </td>
                <td style="width: 314px; height: 2px">
                    &nbsp; &nbsp;&nbsp;<asp:Button ID="btnShowAll" runat="server" Text="Show All" Height="30px" Width="90px" /></td>
                <td style="width: 306px; height: 2px">
                </td>
            </tr>
        </table>
        <asp:Label ID="Label2" runat="server" Width="368px"></asp:Label><br />
        <br />
        <br />
        <br />
        <br />
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
</asp:Content>

