using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace codechallenge3
{
    public class Adodatalayer
    {
        string constr = " ";
        public Adodatalayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet InsertStudentdata(int id, string name, string course, string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Sid", id);
                    cmd.Parameters.AddWithValue("@Sname", name);
                    cmd.Parameters.AddWithValue("@Scourse", course);
                    cmd.Parameters.AddWithValue("@Startdate", date);
                    cmd.CommandText = "InsertStudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch (Exception e)
            {


            }
            return ds;

        }
        public DataSet InsertFacultydata(int id, string name, string age, string dept)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@fid", id);
                    cmd.Parameters.AddWithValue("@fname", name);
                    cmd.Parameters.AddWithValue("@fage", age);
                    cmd.Parameters.AddWithValue("@fdept", dept);
                    cmd.CommandText = "InsertFaculty";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch (Exception e)
            {


            }
            return ds;

        }
        public DataSet InsertCoursedata(int id, string name, string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Cid", id);
                    cmd.Parameters.AddWithValue("@Cname", name);
                    cmd.Parameters.AddWithValue("@Startdate", date);
                  
                    cmd.CommandText = "Insertcourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch (Exception e)
            {


            }
            return ds;


        }
        public DataSet UpdateStudent(int id, string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Sid", id);
                    cmd.Parameters.AddWithValue("@StartDate", date);
                    cmd.CommandText = "UpdateStudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet Updatefaculty(int id, string dept)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@fid", id);
                    cmd.Parameters.AddWithValue("@fdept", dept);
                    cmd.CommandText = "Updatefaculty";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet Updatecourse(int id, string dept)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Cid", id);
                    cmd.Parameters.AddWithValue("@Cname", dept);
                    cmd.CommandText = "Updatecourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet GetaStudent(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Sid", id);
                    cmd.CommandText = "Showstudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet Getafaculty(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@fid", id);
                    cmd.CommandText = "showfaculty";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet Getacourse(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Cid", id);
                    cmd.CommandText = "showcourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public DataSet Deletestudent(int id)

        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Sid", id);

                    cmd.CommandText = "Deletestudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet Deletefaculty(int id)

        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@fid", id);

                    cmd.CommandText = "Deletefaculty";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public DataSet Deletecourse(int id)

        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Cid", id);

                    cmd.CommandText = "Deletecourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet GetaStudent()
        {
            DataSet ds = new DataSet();
            string sqlquery = "select * from Student";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }
            }
            catch (Exception Ex)
            {


            }
            return ds;
        }
        public DataSet GetaFaculty()
        {
            DataSet ds = new DataSet();
            string sqlquery = "select * from Faculty";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }
            }
            catch (Exception Ex)
            {


            }
            return ds;
        }
        public DataSet GetaCourse()
        {
            DataSet ds = new DataSet();
            string sqlquery = "select * from Course";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }
            }
            catch (Exception Ex)
            {


            }
            return ds;
        }

    }
}