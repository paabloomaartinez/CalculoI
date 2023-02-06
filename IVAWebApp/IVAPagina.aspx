<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IVAPagina.aspx.vb" Inherits="IVAWebApp.IVAPagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Total a pagar:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Tipo de IVA:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True">General</asp:ListItem>
            <asp:ListItem>Reducido</asp:ListItem>
            <asp:ListItem>Productos básicos</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="Total sin IVA:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="IVA correspondiente:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
