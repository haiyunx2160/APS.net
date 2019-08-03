using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace haiyun_project1
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateCartGrid();
            CalculateTotal();
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.ID;

            string[] idParts = id.Split('_');
            
            int row = int.Parse(idParts[1]);
            lblRowSelected.Text = "You selected row " + idParts[1];

            _default1.qty[_default1.cartInfo[row]] = "1";

            // delete the cart item from the Main.cartInfo array
            // ... then rebuild the cart grid
            for (int i = row; i < _default1.numItems; i++)
                _default1.cartInfo[i] = _default1.cartInfo[i + 1];

            _default1.numItems--;
            CreateCartGrid();
            CalculateTotal();
        }

        private void CreateCartGrid()
        {
            Table1.Rows.Clear();
            for (int i = 0; i < _default1.numItems; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < 5; j++)
                {
                    // create a cell object to work with
                    TableCell cell = new TableCell();

                    // depending on the column, we'll add either...
                    // a picture, a description, a price or a button to add the item to the cart
                    if (j == 0)
                    {
                        Image image = new Image();
                        image.ImageUrl = "images/" + _default1.pics[_default1.cartInfo[i]];
                        image.Height = 100;
                        image.Width = 100;
                        cell.Controls.Add(image);
                    }
                    else if (j == 1)
                    {
                        Label label = new Label();
                        label.Text = _default1.descrip[_default1.cartInfo[i]];
                        label.Style["font-family"] = "helvetica";
                        label.Style["color"] = "blue";
                        label.Style["background-color"] = "#BFC9DC";

                        cell.Controls.Add(label);
                    }
                    else if (j == 2)
                    {
                        //cell.Text = Main.price[Main.cartInfo[i]];
                        Label label = new Label();
                        label.Text = _default1.price[_default1.cartInfo[i]];
                        label.Style["font-family"] = "helvetica";
                        label.Style["color"] = "blue";
                        label.Style["background-color"] = "#BFC9DC";

                        cell.Controls.Add(label);
                    }
                    else if (j == 3)
                    {
                        // it's easy enough to add a button however
                        // a button we couldn't click would be useless
                        Button btnAddToCart = new Button();
                        btnAddToCart.ID = "btnSelect_" + i + "_" + j;

                        // add the alraedy existing event handler to the button for the current row
                        btnAddToCart.Click += new EventHandler(AddToCart_Click);
                        btnAddToCart.Text = "Remove";
                        cell.Controls.Add(btnAddToCart);
                    }
                    else
                    {
                        TextBox text = new TextBox();
                        text.Text = _default1.qty[_default1.cartInfo[i]];
                        text.Style["font-family"] = "helvetica";
                        text.Style["color"] = "blue";
                        text.Style["background-color"] = "white";
                        text.Style["width"] = "20px";
                        text.Style["border"] = "solid 1px #002594";

                        cell.Controls.Add(text);
                    }
                    // now add all the cells for the current row
                    row.Cells.Add(cell);
                }

                // finally, add the current row to the table
                Table1.Rows.Add(row);
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < _default1.numItems; i++)
            {
                TableRow row = Table1.Rows[i];
                decimal rowPrice = 0;

                for (int j = 0; j < 5; j++)
                {
                    TableCell cell = row.Cells[j];

                    if (j == 2)
                    {
                        Control ctrl = cell.Controls[0];
                        Label lbl = (Label)ctrl;
                        string price = lbl.Text;
                        rowPrice = decimal.Parse(price);
                    }
                    else if (j == 4)
                    {
                        Control ctrl = cell.Controls[0];
                        TextBox txt = (TextBox)ctrl;
                        string qty = txt.Text;
                        _default1.qty[_default1.cartInfo[i]] = qty;

                        decimal rowTotal = rowPrice * decimal.Parse(qty);
                        total += rowTotal;
                    }
                }
            }

            LblTotal.Text = total.ToString("$##,##0.##");
        }

        protected void btnRecalculate_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }
    }
}