using Student_Attendance_Management_System.Login;
using Student_Attendance_Management_System.Main.Collect;
using Student_Attendance_Management_System.Main.Setting;
using Student_Attendance_Management_System.Main.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_Attendance_Management_System.Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-d");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            this.Hide();
            frmUser.ShowDialog();
        }


        private void btnCollect_Click(object sender, EventArgs e)
        {
            frmCollect frmCollect = new frmCollect();
            this.Hide();
            frmCollect.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting frmSetting = new frmSetting();
            this.Hide();
            frmSetting.ShowDialog();
        }
    }
}
