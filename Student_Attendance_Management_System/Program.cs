
using Student_Attendance_Management_System.Login;
using Student_Attendance_Management_System.Main.Collect;
using Student_Attendance_Management_System.Main.Setting;
using Student_Attendance_Management_System.Main.Users;
using Student_Attendance_Management_System.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLectures());
            Application.Run(new frmCollect());
            //Application.Run(new frmMenu());
            //Application.Run(new frmSearch(t));
            //Application.Run(new frmLogin());
        }
    }
}
