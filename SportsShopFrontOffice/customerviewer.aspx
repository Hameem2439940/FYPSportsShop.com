<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerviewer.aspx.cs" Inherits="customerviewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CustomerID
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Username
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            EmailAddress
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Postcode
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="btnCreate_Click" Text="Create" />
        </div>
    </form>
</body>
</html>
