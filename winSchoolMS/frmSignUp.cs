using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winSchoolMS
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sucessfully account create");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
