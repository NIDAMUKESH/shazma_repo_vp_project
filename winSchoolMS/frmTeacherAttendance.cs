using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winproject
{
    public partial class frmTeacherAttendance : Form
      {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");
        SqlCommand cmd;
        private object dr;

        public frmTeacherAttendance()
        {
            InitializeComponent();
        }

        

        private void frmTeacherAttendance_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");
            SqlCommand cmd;
            cmbFullName.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TeacherID , FatherName, Email from tblTeacherInformationDetails";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                cmbFullName.Items.Add(dr["TeacherID, FatherName, Email"].ToString());
            }
            con.Close();


        }

        private void cmbFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select TeacherID, FatherName, Email  from tblTeacherInformationDetails Where TeacherID =  ");
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                string Email = (string) dr ["Email"].ToString();
                txtTeacher_Id.Text = TeacherID ;
            }
        }
    }
}
