using OfficeOpenXml;
using Student_Attendance_Management_System.Codes;
using Student_Attendance_Management_System.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_Management_System.Main.Setting
{
    public partial class frmSetting : Form
    {
        string filePath; // to save file path



        public frmSetting()
        {
            InitializeComponent();
        }

        private void SetFilePath()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

            }

            
        }

        
        private void btnBrowseStudentFile_Click(object sender, EventArgs e)
        {
            SetFilePath();
           

            if (filePath != null)
            {

                using (var excel = new ExcelPackage(new FileInfo(filePath)))
                {
                    // Get the first worksheet in the Excel file
                    var worksheet = excel.Workbook.Worksheets[0];

                    if(worksheet.Dimension.End.Column == 4)
                    {
                        Database.insert(@"DELETE FROM `student` WHERE 1");


                        // Loop through the rows in the worksheet
                        for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                        {
                            // Get the values in the first and second columns
                            string col1 = worksheet.Cells[row, 1].Value.ToString();
                            string col2 = worksheet.Cells[row, 2].Value.ToString();
                            string col3 = worksheet.Cells[row, 3].Value.ToString();
                            string col4 = worksheet.Cells[row, 4].Value.ToString();



                            Database.insert(@"INSERT INTO `student`(`registrationNumber`, `name`, `department`, `batch`) VALUES ('" + col1 + "', '" + col2 + "', '" + col3 + "', '" + col4 + "')");
                            // Insert the values into the database

                        }

                    }
                    else
                    {
                        MessageBox.Show("Student Table and this Worksheets Column count not match.");
                    }

                    
                    
                }
            }
        }


        private void btnBrowsePositionFile_Click(object sender, EventArgs e)
        {
            SetFilePath();


            if (filePath != null)
            {

                using (var excel = new ExcelPackage(new FileInfo(filePath)))
                {
                    // Get the first worksheet in the Excel file
                    var worksheet = excel.Workbook.Worksheets[0];

                    if (worksheet.Dimension.End.Column == 1)
                    {
                        Database.insert(@"DELETE FROM `position` WHERE 1");

                        // Loop through the rows in the worksheet
                        for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                        {
                            // Get the values in the first and second columns
                            string col1 = worksheet.Cells[row, 1].Value.ToString();


                            Database.insert(@"INSERT INTO `position`(`position`) VALUES ('" + col1 + "')");
                            // Insert the values into the database


                        }
                    }
                    else
                    {
                        MessageBox.Show("Position Table and this Worksheets Column count not match.");
                    }



                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmSetting frmoverlay = new frmSetting();

            try
            {

                using (frmPosition frm = new frmPosition())
                {

                    frmoverlay.StartPosition = FormStartPosition.Manual;
                    frmoverlay.FormBorderStyle = FormBorderStyle.None;
                    frmoverlay.Opacity = .70d;
                    frmoverlay.BackColor = Color.Black;
                    frmoverlay.WindowState = FormWindowState.Maximized;
                    frmoverlay.TopMost = true;
                    frmoverlay.Location = this.Location;
                    frmoverlay.ShowInTaskbar = false;
                    frmoverlay.Show();

                    frmoverlay.grpSpreadSheet.Visible = false;
                    frmoverlay.btnLectures.Visible = false;
                    frmoverlay.btnStudent.Visible = false;
                    frmoverlay.btnBatch.Visible = false;
                    frmoverlay.btnPosition.Visible = false;
                    frmoverlay.btnSubjects.Visible = false;
                    frmoverlay.btnClose.Visible = false;
                    frmoverlay.imgSetting.Visible = false;
                    frmoverlay.lblSetting.Visible = false;



                    frm.Owner = frmoverlay;
                    frm.ShowDialog();
                    frmoverlay.Dispose();

                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { frmoverlay.Dispose(); }
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            frmSetting frmoverlay = new frmSetting();

            try
            {

                using (frmBatch frm = new frmBatch())
                {

                    frmoverlay.StartPosition = FormStartPosition.Manual;
                    frmoverlay.FormBorderStyle = FormBorderStyle.None;
                    frmoverlay.Opacity = .70d;
                    frmoverlay.BackColor = Color.Black;
                    frmoverlay.WindowState = FormWindowState.Maximized;
                    frmoverlay.TopMost = true;
                    frmoverlay.Location = this.Location;
                    frmoverlay.ShowInTaskbar = false;
                    frmoverlay.Show();

                    frmoverlay.grpSpreadSheet.Visible = false;
                    frmoverlay.btnLectures.Visible = false;
                    frmoverlay.btnStudent.Visible = false;
                    frmoverlay.btnBatch.Visible = false;
                    frmoverlay.btnPosition.Visible = false;
                    frmoverlay.btnSubjects.Visible = false;
                    frmoverlay.btnClose.Visible = false;
                    frmoverlay.imgSetting.Visible = false;
                    frmoverlay.lblSetting.Visible = false;



                    frm.Owner = frmoverlay;
                    frm.ShowDialog();
                    frmoverlay.Dispose();



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { frmoverlay.Dispose(); }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudents frmStudentsfrm = new frmStudents();
            this.Hide();
            frmStudentsfrm.ShowDialog();
        }
    }
}
