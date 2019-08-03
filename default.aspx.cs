using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace haiyun_project1
{
    public partial class _default1 : System.Web.UI.Page
    {
        // declaration of arrays and variables that can be shared
        // across the catalog and cart pages
        public static string webSiteData = HttpContext.Current.Server.MapPath(".") + @"\Data\Products";
        public static int[] cartInfo = new int[10];
        public static int numItems = 0;

        // get a list of files from the \Data\Products folder
        public static string[] countFiles = Directory.GetFiles(webSiteData, "*.*");

        // based on the number of files found, set the sizes of the arrays
        public static string[] pics = new string[countFiles.Length];
        public static string[] descrip = new string[countFiles.Length];
        public static string[] price = new string[countFiles.Length];
        public static string[] qty = new string[countFiles.Length];

        protected void Page_Load(object sender, EventArgs e)
        {
            // Are we loading this page for the first time?
            // ... or is this a post back from a user event (click etc.)
            if (!IsPostBack)
            {
                aaa.Attributes.Add("src", "Catalog.aspx");

                for (int i = 0; i < 3; i++)
                    qty[i] = "1";
            }
        }
     
        
        protected void Cust_Click(object sender, EventArgs e)
        {
            aaa.Attributes.Add("src", "Customers.aspx");
        }

        protected void Prod_Click(object sender, EventArgs e)
        {
            aaa.Attributes.Add("src", "Products.aspx");
        }

        protected void Prom_Click(object sender, EventArgs e)
        {
            aaa.Attributes.Add("src", "Promotions.aspx");
        }
        protected void Wea_Click(object sender, EventArgs e)
        {
            aaa.Attributes.Add("src", "https://www.theweathernetwork.com/ca/weather/ontario/london");
        }

        protected void cata_Click(object sender, EventArgs e)
        {
            aaa.Attributes.Add("src", "Catalog.aspx");
        }

        protected void cart_Click(object sender, EventArgs e)
        {
            aaa.Attributes.Add("src", "Cart.aspx");
        }
        public static void ResetArrays()
        {
            // get a list of files from the \Data\Products folder
            countFiles = Directory.GetFiles(webSiteData, "*.*");

            // based on the number of files found, set the sizes of the arrays
            pics = new string[countFiles.Length];
            descrip = new string[countFiles.Length];
            price = new string[countFiles.Length];
        }
    }
}