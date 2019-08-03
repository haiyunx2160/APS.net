<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="haiyun_project1.Catalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Catalog</title>
    <link rel="stylesheet" type="text/css" href="styles/Catalog.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server" CssClass="CellStyle" Height="123px" Width="567px" BackColor="#FFCCCC" BorderStyle="Dotted">
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Button" style="visibility:hidden" OnClick="AddToCart_Click" />
        <br />
        <br />
        <asp:Label ID="lblRowSelected" runat="server" CssClass="Labels" Text="...select a button" ForeColor="#FF0066"></asp:Label>
    </form>
</body>
</html>
