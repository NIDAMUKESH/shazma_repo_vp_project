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
    public partial class FrmForgetpassword : Form
    {
        public FrmForgetpassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmDashBoard obj = new frmDashBoard();
            obj.Show();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
        }


    }
}
