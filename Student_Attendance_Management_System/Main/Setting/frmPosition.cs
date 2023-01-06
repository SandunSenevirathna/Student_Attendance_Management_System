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
    public partial class frmPosition : Form
    {
        public frmPosition()
        {
            InitializeComponent();
            dgvFill();

        }

        private void dgvFill()
        {
          DataTable table = Database.selectData("SELECT * from `position` ");
          dgvPosition.DataSource = table;

          dgvPosition.Columns["position"].HeaderText = "Position";


        }

        private void Delete()
        {
            if(txtPosition.Text != string.Empty)
            {
                Database.insert(@"DELETE FROM `position` WHERE `position`='"+txtPosition.Text+"' ");
                txtPosition.Clear();
                txtPosition.Focus();
                dgvFill();
            }

        }

        private void Insert()
        {
            if (txtPosition.Text != string.Empty)
            {
                Database.insert(@"INSERT INTO `position`(`position`) VALUES ('" + txtPosition.Text + "')");
                txtPosition.Clear();
                txtPosition.Focus();
                dgvFill();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            if (txtPosition.Text != string.Empty)
            {
                btnInsert.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                Insert();
            }

            if(e.KeyCode== Keys.Delete)
            {
                Delete();            
            }

            if(e.KeyCode== Keys.Escape)
            {
                txtPosition.Clear();
                txtPosition.Focus();
            }
        }

        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvPosition.Rows[index];

                txtPosition.Text = selectedRow.Cells[0].Value.ToString();
                txtPosition.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
