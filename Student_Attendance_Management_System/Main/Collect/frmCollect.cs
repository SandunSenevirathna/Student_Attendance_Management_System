using MySqlX.XDevAPI.Relational;
using Student_Attendance_Management_System.Codes;
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
        bool alreadyExists;
        DataTable table = new DataTable();
        string RegistrationNumber, Name, Department;
        public frmCollect()
        {
            InitializeComponent();
            cmbSubjectFill();
            cmbLectureHallFill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();

            //Application.Exit();

        }
        public void cmbSubjectFill()
        {
            List<string> Subjectsize = new List<string>();

            DataTable dt = Database.selectData(@"SELECT *  FROM `subject`");

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Subjectsize.Add(item[1].ToString());
                }
                cmbCourseName.DataSource = Subjectsize;
            }
            else
            {
                lblCourseCode.Text = string.Empty;
               
            }


        }

        public void cmbLectureHallFill()
        {
            List<string> LectureHall = new List<string>();

            DataTable dt = Database.selectData(@"SELECT * FROM `lecturehall`");

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    LectureHall.Add(item[0].ToString());
                }
                cmbLectureHall.DataSource = LectureHall;
            }
            
        }

        private void StudentData()
        {
            if(txtBarcode.Text != string.Empty) 
            {
                DataTable dt =  Database.selectData(@"SELECT  `name`, `department` FROM `student` WHERE `registrationNumber` = '"+txtBarcode.Text+"'");
                dt.CreateDataReader();
                if (dt.Rows.Count == 1)
                {
                    RegistrationNumber = txtBarcode.Text;
                    Name = dt.Rows[0][0].ToString();
                    Department = dt.Rows[0][1].ToString();

                    if (dgvCollect.Rows.Count == 0)
                    {
                        table.Rows.Add(RegistrationNumber, Name, Department , DateTime.Now.ToString("HH:mm"));
                        txtBarcode.SelectAll();
                    }
                    else
                    {
                        alreadyExists = false;

                        for (int i = 0; i < dgvCollect.Rows.Count; ++i) // kalin thiyana
                        {
                            if (dgvCollect.Rows[i].Cells[0].Value.ToString() == txtBarcode.Text)
                            {

                                alreadyExists = true;
                                MessageBox.Show("already exists.");
                                txtBarcode.SelectAll();
                                break;


                            }

                        }

                        if (alreadyExists == false)
                        {
                          table.Rows.Add(RegistrationNumber, Name, Department , DateTime.Now.ToString("HH:mm"));
                          MessageBox.Show("This Lecture  is Added 😀 .");
                          txtBarcode.SelectAll();

                        }



                    }
                }

                else { MessageBox.Show("Invalide Registration Number."); txtBarcode.SelectAll();  }
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-d");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Database.selectData(@"SELECT `subjectCode`  FROM `subject` WHERE `sunjectName` = '" + cmbCourseName.Text + "'");
            if (dt.Rows.Count != 0) { lblCourseCode.Text = dt.Rows[0][0].ToString(); }
        }

        private void frmCollect_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Registration Number");  //0
            table.Columns.Add("Name"); //1
            table.Columns.Add("Department"); //2 
            table.Columns.Add("Time");   // ගැනුම් මිල 3

            dgvCollect.DataSource = table;
            dgvCollect.Columns["Name"].Width = 400;

            txtBarcode.Focus();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            timerBarcode.Interval = (500);
            timerBarcode.Enabled = true;
            timerBarcode.Start();
        }

        private void timerBarcode_Tick(object sender, EventArgs e)
        {
            timerBarcode.Stop();
            StudentData();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if(cmbCourseName.Text != string.Empty && cmbLectureHall.Text != string.Empty)
            {
                btnEnd.Enabled = true;
                btnSearch.Enabled = true;
                txtBarcode.Enabled = true;

                btnAccept.Enabled = false;
                btnClose.Enabled = false;
                btnStart.Enabled = false;
                cmbCourseName.Enabled = false;
                cmbLectureHall.Enabled = false;

                txtBarcode.Focus();

            }

           

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            btnEnd.Enabled = false;
            btnSearch.Enabled = false;
            txtBarcode.Enabled = false;

            btnAccept.Enabled = true;
            btnClose.Enabled = true;
            btnStart.Enabled = true;
            cmbCourseName.Enabled = true;
            cmbLectureHall.Enabled = true;
        }
    }
}
