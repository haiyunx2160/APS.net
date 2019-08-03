using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace haiyun_project1
{
    public partial class Catalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = _default1.webSiteData;

            _default1.ResetArrays();

            string[] fileList;
            fileList = Directory.GetFiles(filePath, "*.*");

            for (int i = 0; i < fileList.Length; i++)
            {
                StreamReader input = new StreamReader(fileList[i]);
                _default1.pics[i] = input.ReadLine();
                _default1.descrip[i] = input.ReadLine();
                _default1.price[i] = input.ReadLine();
                input.Close();
            }

            for (int i = 0; i < _default1.pics.Length; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < 4; j++)
                {
                    // create a cell object to work with
                    TableCell cell = new TableCell();

                    // depending on the column, we'll add either...
                    // a picture, a description, a price or a button to add the item to the cart
                    if (j == 0)
                    {
                        Image image = new Image();
                        image.ImageUrl = "images/" + _default1.pics[i];
                        image.Height = 100;
                        image.Width = 100;
                        cell.Controls.Add(image);
                    }
                    else if (j == 1)
                    {
                        Label label = new Label();
                        label.Text = _default1.descrip[i];
                        label.Style["font-family"] = "helvetica";
                        label.Style["color"] = "blue";
                        label.Style["background-color"] = "#BFC9DC";

                        cell.Controls.Add(label);
                    }
                    else if (j == 2)
                    {
                        cell.Text = _default1.price[i];
                    }
                    else
                    {
                        // it's easy enough to add a button however
                        // a button we couldn't click would be useless
                        Button btnAddToCart = new Button();
                        btnAddToCart.ID = "btnSelect_" + i + "_" + j;

                        // add the already existing event handler to the button for the current row
                        btnAddToCart.Click += new EventHandler(AddToCart_Click);
                        btnAddToCart.Text = "Add To Cart";
                        cell.Controls.Add(btnAddToCart);
                    }
                    // now add all the cells for the current row
                    row.Cells.Add(cell);
                }

                // finally, add the current row to the table
                Table1.Rows.Add(row);
            }
        }

        // ****************************************************************
        // This event handler is "attached" to Button1 (which is invisible)
        // and it's also attached to each of the buttons at the end of the 
        // catalog row
        protected void AddToCart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.ID;

            string[] idParts = id.Split('_');

            int row = int.Parse(idParts[1]);
            lblRowSelected.Text = "You selected " + _default1.descrip[row];

            if (_default1.numItems > 0)
            {
                bool matchRow = false;
                for (int i = 0; i < _default1.numItems; i++)
                {
                    if (row == _default1.cartInfo[i])
                        matchRow = true;
                }

                if (!matchRow)
                {
                    _default1.cartInfo[_default1.numItems] = row;
                    _default1.numItems++;
                }
            }
            else
            {
                _default1.cartInfo[_default1.numItems] = row;
                _default1.numItems++;
            }
        }
    }
}