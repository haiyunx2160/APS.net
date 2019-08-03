<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="haiyun_project1._default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Haiyun_lab2</title>

    <%-- Link to CCS file --%>
    <link href="Styles/default.css" rel="stylesheet" />
    
    <style type="text/css">
        #aaa {
            height: 502px;
            width: 700px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <div id="panel">
            <asp:Panel ID="Panel1" runat="server">
                <%-- Button controls of different web contents  --%>
                <asp:Button ID="cata" runat="server" Text="Catalog" OnClick="cata_Click" />
                <asp:Button ID="cart" runat="server" Text="Cart" OnClick="cart_Click"  />
                <asp:Button ID="wea" runat="server" Text="Weather" OnClick="Wea_Click" />
                <asp:Button ID="cust" runat="server" Text="Customers" OnClick="Cust_Click"/>
                <asp:Button ID="prod" runat="server" Text="Products" OnClick="Prod_Click" />
                <asp:Button ID="prom" runat="server" Text="promotions" OnClick="Prom_Click" />

            </asp:Panel>
            <%-- the frame to output web content --%>
            <iframe id="aaa" runat="server"></iframe>
        <%-- secondary image --%>
         <asp:Image ID="Image1" runat="server" imageUrl="~/Images/subpic.png" Height="517px" />
        
        </div>
         <p>
             &nbsp;</p>
    </form>
    
</body>
</html>