using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace codechallenge3
{
    public partial class Updatestudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Adodatalayer ad1 = new Adodatalayer();
            int idno = Convert.ToInt32(TextBox1.Text);
            string date = (TextBox2.Text);
            var update = ad1.UpdateStudent(idno, date);
            GridView1.DataSource = update;
            GridView1.Dispose();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Adodatalayer ad1 = new Adodatalayer();
            int idno = Convert.ToInt32(TextBox3.Text);
            string dept = (TextBox4.Text);
            var update = ad1.Updatefaculty(idno, dept);
            GridView1.DataSource = update;
            GridView1.Dispose();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Adodatalayer ad1 = new Adodatalayer();
            int idno = Convert.ToInt32(TextBox5.Text);
            string cname = (TextBox6.Text);
            var update = ad1.Updatecourse(idno, cname);
            GridView1.DataSource = update;
            GridView1.Dispose();
        }
    }
}