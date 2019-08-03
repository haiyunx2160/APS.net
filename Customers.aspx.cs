using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace haiyun_project1
{
    public partial class Customers : System.Web.UI.Page
    {
        string webSiteData = HttpContext.Current.Server.MapPath(".") + @"\data\customers\";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnNewCustomer_Click(object sender, EventArgs e)
        {
            flushData();
        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
              StreamWriter output = new StreamWriter(webSiteData + txtCustomerNumber.Text + ".txt");
            output.WriteLine(txtFirstName.Text);
            output.WriteLine(txtLastName.Text);
            output.WriteLine(txtAddress.Text);
            output.WriteLine(txtCity.Text);
            output.WriteLine(txtProvince.Text);
            output.WriteLine(txtPostal.Text);
            output.Close();
        }

        protected void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerNumber.Text != "")
            {
                StreamWriter output = new StreamWriter(webSiteData + txtCustomerNumber.Text + ".txt");
                output.WriteLine(txtFirstName.Text);
                output.WriteLine(txtLastName.Text);
                output.WriteLine(txtAddress.Text);
                output.WriteLine(txtCity.Text);
                output.WriteLine(txtProvince.Text);
                output.WriteLine(txtPostal.Text);
                output.Close();
            }
        }

        protected void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (File.Exists(webSiteData + txtCustomerNumber.Text + ".txt"))
            {
                File.Delete(webSiteData + txtCustomerNumber.Text + ".txt");
                flushData();
            }
        }

        protected void btnFindCustomer_Click(object sender, EventArgs e)
        {
            if (File.Exists(webSiteData + txtCustomerNumber.Text + ".txt"))
            {
                StreamReader input = new StreamReader(webSiteData + txtCustomerNumber.Text + ".txt");
                txtFirstName.Text = input.ReadLine();
                txtLastName.Text = input.ReadLine();
                txtAddress.Text = input.ReadLine();
                txtCity.Text = input.ReadLine();
                txtProvince.Text = input.ReadLine();
                txtPostal.Text = input.ReadLine();
                input.Close();
            }
        }

        private void flushData()
        {
            txtCustomerNumber.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtPostal.Text = "";
        }
    }
}