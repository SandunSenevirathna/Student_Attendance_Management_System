using OfficeOpenXml;
using Student_Attendance_Management_System.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_Management_System.Main.Setting
{
    public partial class Form1 : Form
    {
        string filePath; // to save file path

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseStudentFile_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

            }


            if (filePath != null)
            {

                using (var excel = new ExcelPackage(new FileInfo(filePath)))
                {
                    // Get the first worksheet in the Excel file
                    var worksheet = excel.Workbook.Worksheets[0];



                    // Loop through the rows in the worksheet
                    for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        // Get the values in the first and second columns
                        string col1 = worksheet.Cells[row, 1].Value.ToString();
                        string col2 = worksheet.Cells[row, 2].Value.ToString();
                        string col3 = worksheet.Cells[row, 3].Value.ToString();


                        Database.insert(@"INSERT INTO `rusl_ssrs`.`user` (`email`,`password`,`userName`) VALUES ('" + col1 + "', '" + col2 + "', '" + col3 + "')");
                        // Insert the values into the database

                    }
                }
            }
        }
    }
}
