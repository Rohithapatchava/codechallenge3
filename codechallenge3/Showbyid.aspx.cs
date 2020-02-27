using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace codechallenge3
{
    public partial class Showbyid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Adodatalayer ad1 = new Adodatalayer();
            int idno = Convert.ToInt32(TextBox1.Text);
            var singlestudent = ad1.GetaStudent(idno);
            GridView1.DataSource = singlestudent;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Adodatalayer ad1 = new Adodatalayer();
            int idno = Convert.ToInt32(TextBox2.Text);
            var singlestudent = ad1.Getafaculty(idno);
            GridView2.DataSource = singlestudent;
            GridView2.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Adodatalayer ad1 = new Adodatalayer();
            int idno = Convert.ToInt32(TextBox3.Text);
            var singlestudent = ad1.Getacourse(idno);
            GridView3.DataSource = singlestudent;
            GridView3.DataBind();
        }
    }
}