<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="haiyun_project1.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart</title>
    <link rel="stylesheet" type="text/css" href="styles/Cart.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server" CssClass="CellStyle" Height="123px" Width="567px" BackColor="#CDECFE" BorderStyle="Dotted">
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Button" style="visibility:hidden" OnClick="AddToCart_Click" />
        <br />
        <br />
        <asp:Label ID="lblRowSelected" runat="server" CssClass="Labels" Text="...select a button" ForeColor="#FF0066"></asp:Label>
        <br />
        <asp:Label ID="LblTotal" runat="server" CssClass="LabelTotal" Text="0.00"></asp:Label>
        <asp:Button ID="btnRecalculate" runat="server" Text="Total" OnClick="btnRecalculate_Click" />
    </form>
</body>
</html>
