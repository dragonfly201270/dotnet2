<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/materialize.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div  align="center">
            <h2 >Employee Search</h2>
        </div>
        <div>

            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Search Employee (ID)" Font-Bold="true" Font-Size="X-Large"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </td>
                </tr>
        </table>
           <div align="center">
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" Width="108px"  />
               <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Home"  Width="108px"/>
            </div>
               <asp:Label ID="Label2" runat="server" ForeColor="#FF3300"></asp:Label>

            <br />



            <asp:GridView ID="GridView1" runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            &nbsp;
        </div>
        <p>
            

        </p>
    </form>
</body>
</html>
