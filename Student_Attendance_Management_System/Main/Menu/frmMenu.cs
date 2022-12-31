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
    }
}
