using MySqlX.XDevAPI.Relational;
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

namespace Student_Attendance_Management_System.Main.Collect
{
    public partial class frmSearch : Form
    {
        frmCollect search;
        public frmSearch(frmCollect Collect)
        {
            InitializeComponent();
            search = Collect; 
            dgvFill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void txtRegistrationNumber_TextChanged(object sender, EventArgs e)
        {
            DataTable table = Database.selectData(@"SELECT  * FROM `student` WHERE `registrationNumber` LIKE '" + txtRegistrationNumber.Text + "%' OR `name` LIKE '" + txtRegistrationNumber.Text+"%' ");
            dgvStudent.DataSource = table;

            dgvStudent.Columns["registrationNumber"].HeaderText = "Registration Number";
            dgvStudent.Columns["name"].HeaderText = "Student Name";
            dgvStudent.Columns["department"].HeaderText = "Department";
            dgvStudent.Columns["batch"].HeaderText = "Batch";
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvStudent.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvStudent.Rows[index];
            search.txtBarcode.Clear();
            search.txtBarcode.Text = selectedRow.Cells[0].Value.ToString();

            search.txtBarcode.Focus();
            Close();
        }

        private void txtRegistrationNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }

            if(e.KeyCode == Keys.F12)
            {
                Close();
            }
        }

        private void dgvStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int index = dgvStudent.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvStudent.Rows[index];
                search.txtBarcode.Clear();
                search.txtBarcode.Text = selectedRow.Cells[0].Value.ToString();

                Close();
            }
            
            if(e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");

            }
        }

        private void txtRegistrationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\\') || (e.KeyChar == '\'') || (e.KeyChar == ';') || (e.KeyChar == '"') || (e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }
    }
}
