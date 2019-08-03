using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace haiyun_project1
{
    public partial class Products : System.Web.UI.Page
    {
        public static string webSitePics = HttpContext.Current.Server.MapPath(".") + @"\Pictures";
        string webSiteData = HttpContext.Current.Server.MapPath(".") + @"\data\products\";
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] fileList = Directory.GetFiles(webSitePics, "*.*");
                ListBox1.Items.Clear();

                for (int i = 0; i < fileList.Length; i++)
                {
                    string fileName = Path.GetFileName(fileList[i]);
                    ListBox1.Items.Add(fileName);
                }
            }
        }

        protected void new_Click(object sender, EventArgs e)
        {
            TextBox4.Text = "";
            TextBox3.Text = "";
            TextBox6.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox5.Text = "";
            

        }

        protected void add_Click(object sender, EventArgs e)
        {
            StreamWriter output = new StreamWriter(webSiteData + TextBox1.Text + ".txt");
            output.WriteLine(TextBox4.Text);
            output.WriteLine(TextBox3.Text);
            output.WriteLine(TextBox6.Text);
            output.WriteLine(TextBox2.Text);
            output.WriteLine(TextBox5.Text);
            output.Close();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                StreamWriter output = new StreamWriter(webSiteData + TextBox1.Text + ".txt");
                output.WriteLine(TextBox4.Text);
                output.WriteLine(TextBox3.Text);
                output.WriteLine(TextBox6.Text);
                output.WriteLine(TextBox2.Text);
                output.WriteLine(TextBox5.Text);
                output.Close();
            }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            if (File.Exists(webSiteData + TextBox1.Text + ".txt"))
            {
                File.Delete(webSiteData + TextBox1.Text + ".txt");
                flushData();
            }
        }
        private void flushData()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        
        }

        protected void find_Click(object sender, EventArgs e)
        {
            if (File.Exists(webSiteData + TextBox1.Text + ".txt"))
            {
                StreamReader input = new StreamReader(webSiteData + TextBox1.Text + ".txt");
                TextBox4.Text = input.ReadLine();
                TextBox3.Text = input.ReadLine();
                TextBox6.Text = input.ReadLine();
                TextBox2.Text = input.ReadLine();
                TextBox5.Text = input.ReadLine();

                input.Close();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No file found')", true);
            }
        }
        protected void lstPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/Pictures/" + ListBox1.SelectedItem;
            TextBox4.Text = ListBox1.SelectedValue;
         

        }

    }
}