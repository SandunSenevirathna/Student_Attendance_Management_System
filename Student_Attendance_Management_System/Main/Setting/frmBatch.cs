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
    public partial class frmBatch : Form
    {
        public frmBatch()
        {
            InitializeComponent();
            dgvBFill();
            dgvLFill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBFill()
        {
            DataTable table = Database.selectData("SELECT * FROM `batch`  ");
            dgvBatch.DataSource = table;

            dgvBatch.Columns["batch"].HeaderText = "Batch";


        }

        private void dgvLFill()
        {
            DataTable table = Database.selectData("SELECT * FROM `lecturehall`  ");
            dgvLectureHall.DataSource = table;

            dgvLectureHall.Columns["lecturehall"].HeaderText = "Lecture Halls";


        }
        private void DeleteB()
        {
            if (txtBatch.Text != string.Empty)
            {
                Database.insert(@"DELETE FROM `batch` WHERE `batch`='" + txtBatch.Text + "' ");
                txtBatch.Clear();
                txtBatch.Focus();
                dgvBFill();
            }

        }

        private void DeleteL()
        {
            if (txtLectureHall.Text != string.Empty)
            {
                Database.insert(@"DELETE FROM `lecturehall` WHERE `lecturehall`='" + txtLectureHall.Text + "' ");
                txtLectureHall.Clear();
                txtLectureHall.Focus();
                dgvLFill();
            }

        }

        private void InsertB()
        {
            if (txtBatch.Text != string.Empty)
            {
                Database.insert(@"INSERT INTO `batch`(`batch`) VALUES ('" + txtBatch.Text + "')");
                txtBatch.Clear();
                txtBatch.Focus();
                dgvBFill();
            }
        }

        private void InsertL()
        {
            if (txtLectureHall.Text != string.Empty)
            {
                Database.insert(@"INSERT INTO `lecturehall`(`lecturehall`) VALUES ('" + txtLectureHall.Text + "')");
                txtLectureHall.Clear();
                txtLectureHall.Focus();
                dgvLFill();
            }
        }


        private void txtBatch_TextChanged(object sender, EventArgs e)
        {
            if (txtBatch.Text != string.Empty)
            {
                btnBInsert.Enabled = true;
                btnBDelete.Enabled = true;
            }
            else
            {
                btnBInsert.Enabled = false;
                btnBDelete.Enabled = false;
            }
        }

        private void txtLectureHall_TextChanged(object sender, EventArgs e)
        {
            if (txtLectureHall.Text != string.Empty)
            {
                btnLInsert.Enabled = true;
                btnLDelete.Enabled = true;
            }
            else
            {
                btnLInsert.Enabled = false;
                btnLDelete.Enabled = false;
            }
        }

        private void btnBInsert_Click(object sender, EventArgs e)
        {
            InsertB();
        }

        private void btnBDelete_Click(object sender, EventArgs e)
        {
            DeleteB();
        }

        private void btnLInsert_Click(object sender, EventArgs e)
        {
            InsertL();
        }

        private void btnLDelete_Click(object sender, EventArgs e)
        {
            DeleteL();
        }

        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertB();
            }

            if (e.KeyCode == Keys.Delete)
            {
                DeleteB();
            }

            if (e.KeyCode == Keys.Escape)
            {
                txtBatch.Clear();
                txtBatch.Focus();
            }
        }

        private void txtLectureHall_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertL();
            }

            if (e.KeyCode == Keys.Delete)
            {
                DeleteL();
            }

            if (e.KeyCode == Keys.Escape)
            {
                txtLectureHall.Clear();
                txtLectureHall.Focus();
            }
        }

        private void dgvBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvBatch.Rows[index];

                txtBatch.Text = selectedRow.Cells[0].Value.ToString();
                txtBatch.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLectureHall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvLectureHall.Rows[index];

                txtLectureHall.Text = selectedRow.Cells[0].Value.ToString();
                txtLectureHall.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
