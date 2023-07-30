using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace winSchoolMS
{
    public partial class frmCourseAllocate : Form
    {
        private string CourseID;
        private string con;

        public frmCourseAllocate()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");
            string QRY = "Insert into tblCourseAllocate (CourseName, Class , Section, FirstName, LastName) Values('" + txtCourseName.Text + "','" + cmbClass.Text + "','" + txtSection.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "')";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtCourseName.Text = "";
            cmbClass.Text = "";

            txtSection.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";

            MessageBox.Show("Data Inserted Sucessfully");
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblCourseAllocate order by CourseID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourseAllocate.DataSource = dt;

            // Check if the subject already exists for the teacher
            string sqlCheckSubject = "SELECT COUNT(*) AS count FROM tblCourseAllocate WHERE CourseName = @CourseName AND FirstName = @FirstName AND LastName = @LastName";
            SqlCommand cmdCheckSubject = new SqlCommand(sqlCheckSubject, con);
            cmdCheckSubject.Parameters.AddWithValue("@CourseName", txtCourseName.Text);
            cmdCheckSubject.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmdCheckSubject.Parameters.AddWithValue("@LastName", txtLastName.Text);

            int count = 0;
            try
            {
                con.Open();
                count = (int)cmdCheckSubject.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // If the subject already exists, do not insert the record
            if (count > 0)
            {
                MessageBox.Show("The subject already exists for the teacher.");
            }
        }

        private bool IsCourseAlreadyAllocated(object selectedClass, string courseID)
        {
            throw new NotImplementedException();
        }

        private void frmCourseAllocate_Load(object sender, EventArgs e)
        {
            //Step 01: SQL Connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblCourseAllocate order by CourseID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourseAllocate.DataSource = dt;

        }

        private void gvCourseAllocate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CourseID = gvCourseAllocate.Rows[e.RowIndex].Cells[0].Value.ToString();
            string CourseName = gvCourseAllocate.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Class = gvCourseAllocate.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Section = gvCourseAllocate.Rows[e.RowIndex].Cells[3].Value.ToString();
            string FirstName = gvCourseAllocate.Rows[e.RowIndex].Cells[4].Value.ToString();
            string LastName = gvCourseAllocate.Rows[e.RowIndex].Cells[5].Value.ToString().Trim().ToLower();

            txtCourseName.Text = CourseName;
            cmbClass.Text = Class;
            txtSection.Text = Section;
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");

            string QRY = $"UPDATE tblCourseAllocate SET  CourseName = '{txtCourseName.Text}', Class = '{cmbClass.Text}', Section = '{txtSection.Text}', FirstName = '{txtFirstName.Text}', LastName = '{txtLastName.Text}' WHERE CourseID = {CourseID}";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtCourseName.Text = "";
            cmbClass.Text = "";
            txtSection.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
           
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblCourseAllocate order by CourseID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourseAllocate.DataSource = dt;
            btnInsert.Enabled = true;


            MessageBox.Show("Data Updated Sucessfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");
            string QRY = "Delete from tblCourseAllocate where CourseID=" + @CourseID;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.Parameters.AddWithValue("@CourseID", CourseID);

            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblCourseAllocate order by CourseID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourseAllocate.DataSource = dt;
            btnInsert.Enabled = true;


            MessageBox.Show("Data Dealeted Sucessfully");
        }
    }
}

