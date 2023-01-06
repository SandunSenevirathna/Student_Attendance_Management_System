using Student_Attendance_Management_System.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_Management_System.Main.Setting
{
    public partial class frmStudents : Form
    {
       

        public frmStudents()
        {
            InitializeComponent();
            cmbBatchFill();
            dgvFill();
           
        }

        private void dgvFill()
        {
            DataTable table = Database.selectData("SELECT * FROM `student`  ");
            dgvStudent.DataSource = table;

            dgvStudent.Columns["registrationNumber"].HeaderText = "Registration Number";
            dgvStudent.Columns["name"].HeaderText = "Student Name";
            dgvStudent.Columns["department"].HeaderText = "Department";
            dgvStudent.Columns["batch"].HeaderText = "Batch";

           
        }

        private void ButtonEnter(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }

            if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }

            if (e.KeyCode == Keys.Escape)
            {
                ClearText();
            }

            if (e.KeyCode == Keys.Delete)
            {
                delete();
            }
        }
        private void ButtonPressWithoutSymbols(KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\\') || (e.KeyChar == '\'') || (e.KeyChar == ';') || (e.KeyChar == '"') || (e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void AutoFillText()
        {
            DataTable dt = Database.selectData(@"SELECT  `name`, `department`, `batch` FROM `student` WHERE `registrationNumber` = '" + txtRegistrationNumber.Text + "'");
            if (dt.Rows.Count == 1)
            {
                txtStudentName.Text = dt.Rows[0][0].ToString();
                txtDepartment.Text = dt.Rows[0][1].ToString();
                cmbBatch.Text = dt.Rows[0][2].ToString();

                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }

            else
            {
                txtStudentName.Clear();
                txtDepartment.Clear();
                cmbBatch.Text = null;

                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void ClearText() 
        {
            txtRegistrationNumber.Clear();
            txtStudentName.Clear();
            txtDepartment.Clear();
            cmbBatch.Text = string.Empty;

            txtRegistrationNumber.SelectAll();

        }

        private void cmbBatchFill()
        {
            List<string> size = new List<string>();

            DataTable dt = Database.selectData(@"SELECT *  FROM `batch` ");

            foreach (DataRow item in dt.Rows)
            {
                size.Add(item[0].ToString());

            }
            cmbBatch.DataSource = size;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            IUD();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IUD();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();

        }

        private void txtRegistrationNumber_TextChanged(object sender, EventArgs e)
        {
            AutoFillText();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvStudent.Rows[index];

                txtRegistrationNumber.Text = selectedRow.Cells[0].Value.ToString();
                txtRegistrationNumber.SelectAll();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete()
        {
            Database.insert(@"DELETE FROM `student` WHERE `registrationNumber`='" + txtRegistrationNumber.Text + "'");
            dgvFill();
            ClearText();
        }
        private void IUD() // Insert, Update, Delete = IUP
        {
            if(txtRegistrationNumber.Text != string.Empty && txtStudentName.Text != string.Empty && txtDepartment.Text != string.Empty && cmbBatch.Text != string.Empty)
            {

                if (btnInsert.Enabled == true)
                {
                    Database.insert(@"INSERT INTO `student`(`registrationNumber`, `name`, `department`, `batch`) VALUES ('"+txtRegistrationNumber.Text+"','"+txtStudentName.Text+"','"+txtDepartment.Text+"','"+cmbBatch.Text+"')");
                    dgvFill();
                    ClearText();


                }

                if (btnUpdate.Enabled == true)
                {
                    Database.insert(@"
                        UPDATE `student` SET 
                        
                        `name`='"+txtStudentName.Text+"'," +
                        "`department`='"+txtDepartment.Text+"'," +
                        "`batch`='"+cmbBatch.Text+"' " +
                        "WHERE `registrationNumber`='"+txtRegistrationNumber.Text+"'" +
                    "");
                    dgvFill();
                    ClearText();

                }

            }
            else
            {
                MessageBox.Show("Try again.");
                txtRegistrationNumber.SelectAll();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmSetting frmSetting = new frmSetting();
            this.Hide();
            frmSetting.ShowDialog();
        }


        private void txtRegistrationNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }

            if (e.KeyCode == Keys.Escape)
            {
                ClearText();
            }

            if (e.KeyCode == Keys.Delete)
            {
                delete();
            }
        }

        private void txtStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            ButtonEnter(e);
        }

        private void txtDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            ButtonEnter(e);
        }

        private void cmbBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IUD();
            }

            if (e.KeyCode == Keys.Delete)
            {
                delete();
            }

            if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }

            if (e.KeyCode == Keys.Escape)
            {
                ClearText();
            }
        }

        private void txtRegistrationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ButtonPressWithoutSymbols(e);
        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ButtonPressWithoutSymbols(e);

        }

        private void txtDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            ButtonPressWithoutSymbols(e);

        }

    }
}
