<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="css/materialize.min.css" rel="stylesheet" />
    <%--<link href="css/bootstrap-theme.min.css" rel="stylesheet" />--%>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h2>Employee Details</h2>
        </div>
        <div style="height: 483px; margin-top: 33px" align="left">

            <asp:Label ID="Label5" runat="server" ForeColor="#ff3300"></asp:Label>


            <br />
            <br />
            <br />
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" Text="First Name" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label6" runat="server" Text="Last Name" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label3" runat="server" Text="Address" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label4" runat="server" Text="City" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>&nbsp;</asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" Width="108px" />
                        <asp:Button ID="Button2" runat="server" align="right" OnClick="Button2_Click" Text="Search" Style="float: inherit" Width="108px" />
                        <asp:Button ID="Button3" runat="server" align="right" OnClick="Button3_Click" Text="List Employee" Style="float: inherit" Width="108px" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            &nbsp;&nbsp;
    
        <br />
            <br />
            <br />

            <br />
            <br />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
