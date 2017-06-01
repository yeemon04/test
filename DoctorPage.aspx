<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="DoctorPage.aspx.vb" Inherits="DoctorPage" title="DatDoc Group/Doctor Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="DIV1" onclick="return DIV1_onclick()" style="z-index: 101; left: 73px; width: 1015px;
        position: absolute; top: -20px; height: 438px; font-size: 11pt;">
        &nbsp;<table>
            <tr>
                <td colspan="2" style="font-weight: bold; font-size: 12pt; height: 21px; text-align: center">
                    <asp:TextBox ID="TextBox1" runat="server" BackColor="Blue" Font-Bold="True" ForeColor="Lavender"
                        ReadOnly="True" Width="421px">PATIENTS LIST AND DOCTOR NAME</asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="font-weight: bold; font-size: 12pt; height: 21px; text-align: center">
                </td>
            </tr>
            <tr>
                <td style="width: 165px; height: 21px">
                    Doctor Name &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; :</td>
                <td style="width: 195px; height: 21px">
                    <asp:Label ID="lblDoctorName" runat="server" Width="260px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 165px; height: 21px">
                    Specialist &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;:</td>
                <td style="width: 195px; height: 21px">
                    <asp:Label ID="lblSepcialityArea" runat="server" Width="262px"></asp:Label></td>
            </tr>
        </table>
        <br />
        &nbsp;&nbsp;
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label><br />
        <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1"
            Font-Bold="False" ForeColor="White" GridLines="None" Height="155px" Width="1007px">
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <Columns>
                <asp:BoundField DataField="NIN" HeaderText="NIN" Visible="False" />
                <asp:BoundField DataField="Fore Name" HeaderText="Fore Name" />
                <asp:BoundField DataField="Sur Name" HeaderText="Sur Name" />
                <asp:BoundField DataField="Date Of Birth" HeaderText="Date Of Birth" />
                <asp:BoundField DataField="Sex" HeaderText="Sex" />
                <asp:BoundField DataField="Marital Status" HeaderText="Marital Status" />
                <asp:BoundField DataField="Preferred Date" HeaderText="Preferred Date" Visible="False" />
                <asp:BoundField DataField="Doctor ID" HeaderText="Doctor ID" Visible="False" />
                <asp:BoundField DataField="Doctor Name" HeaderText="Doctor Name" Visible="False" />
                <asp:BoundField DataField="Specialist" HeaderText="Specialist" Visible="False" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:HyperLinkField DataNavigateUrlFields="NIN" DataNavigateUrlFormatString="./MedicalRecord.aspx?NIN={0}"
                    Text="Edit" />
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <div style="z-index: 101; left: 447px; width: 276px; position: absolute; top: 23px;
            height: 20px">
            &nbsp;
            <div style="z-index: 101; left: 434px; width: 125px; position: absolute; top: 0px;
                height: 29px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HomePage.aspx" Width="119px">Home Page</asp:HyperLink></div>
        </div>
    </div>
</asp:Content>

