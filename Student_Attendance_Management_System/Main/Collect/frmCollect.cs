using Student_Attendance_Management_System.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_Management_System.Main.Collect
{
    public partial class frmCollect : Form
    {
        public frmCollect()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //frmMenu frmMenu =  new frmMenu();
            //this.Hide();
            //frmMenu.ShowDialog();

            Application.Exit();

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = "• Date : " + DateTime.Now.ToString("yyyy-MM-dd") + "  • Time : " + DateTime.Now.ToString("HH:mm:ss");

        }
    }
}
