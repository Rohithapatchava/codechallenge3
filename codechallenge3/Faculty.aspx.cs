using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace codechallenge3
{
    public partial class Faculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Adodatalayer ad1 = new Adodatalayer();
            int idno = Convert.ToInt32(TextBox1.Text);
            string name = (TextBox2.Text);
            string age = (TextBox3.Text);
            string dept = (TextBox4.Text);
            var insert = ad1.InsertFacultydata(idno, name, age, dept);
            GridView1.DataSource = insert;
            GridView1.Dispose();

        }
    }
}