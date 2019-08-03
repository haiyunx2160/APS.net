<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="haiyun_project1.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/product.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Panel ID="Panel1" CssClass="Panels" runat="server">
        <!-- textboxes and labels to collect data-->
            <asp:Table ID="Table1" runat="server">
           <asp:TableRow>
               <asp:TableCell>
               <asp:Label ID="Label4" CssClass="Labels" runat="server" Text="Picture"></asp:Label>
               </asp:TableCell>
               <asp:TableCell>
            <asp:TextBox ID="TextBox4" CssClass="TextBoxes" runat="server"></asp:TextBox>
               </asp:TableCell>
               </asp:TableRow> 


                <asp:TableRow>
               <asp:TableCell> 
            <asp:Label ID="Label3" CssClass="Labels" runat="server" Text="Description"></asp:Label>
                   </asp:TableCell>
               <asp:TableCell>
            <asp:TextBox ID="TextBox3" CssClass="TextBoxes" runat="server"></asp:TextBox>
                    </asp:TableCell>
               </asp:TableRow> 

                 <asp:TableRow>
               <asp:TableCell>
             <asp:Label ID="Label6" CssClass="Labels" runat="server" Text="Price"></asp:Label>
                    </asp:TableCell>
               <asp:TableCell>
            <asp:TextBox ID="TextBox6" CssClass="TextBoxes" runat="server"></asp:TextBox>
                     </asp:TableCell>
               </asp:TableRow> 

                <asp:TableRow>
               <asp:TableCell>
            <asp:Label ID="Label1" CssClass="Labels" runat="server" Text="Product#"></asp:Label>
                   </asp:TableCell>
               <asp:TableCell>
            <asp:TextBox ID="TextBox1" CssClass="TextBoxes" runat="server"></asp:TextBox>
                   </asp:TableCell>
               </asp:TableRow>

                 <asp:TableRow>
               <asp:TableCell>
            <asp:Label ID="Label2" CssClass="Labels" runat="server" Text="Manufact code"></asp:Label>
                   </asp:TableCell>
               <asp:TableCell>
            <asp:TextBox ID="TextBox2" CssClass="TextBoxes" runat="server"></asp:TextBox>
                   </asp:TableCell>
               </asp:TableRow>

                <asp:TableRow>
               <asp:TableCell>
            <asp:Label ID="Label5" CssClass="Labels" runat="server" Text="QOH"></asp:Label>
                    </asp:TableCell>
               <asp:TableCell>
            <asp:TextBox ID="TextBox5" CssClass="TextBoxes" runat="server"></asp:TextBox>
                   </asp:TableCell>
               </asp:TableRow>
            </asp:Table>
        <!--functionals buttons store and alter data-->
            <asp:Button ID="new" CssClass="Buttons" runat="server" Text="New" OnClick="new_Click" />
            <asp:Button ID="add" CssClass="Buttons" runat="server" Text="Add" OnClick="add_Click" />
            <asp:Button ID="update" CssClass="Buttons" runat="server" Text="Update" OnClick="update_Click" />
            <asp:Button ID="delete" CssClass="Buttons" runat="server" Text="Delete" OnClick="delete_Click" />
            <asp:Button ID="find" CssClass="Buttons" runat="server" Text="Find" OnClick="find_Click" />
       
             </asp:Panel>
            </div>
      
        <div id="list">
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstPictures_SelectedIndexChanged"></asp:ListBox>
            </div>
        <!--image control showing product image-->
            <div id="image">
            <asp:Image ID="Image1" runat="server" />
        
        </div>
    </form>
</body>
</html>
