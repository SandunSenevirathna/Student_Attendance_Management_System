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
    public partial class frmSubject : Form
    {
        bool alreadyExists;


        public frmSubject()
        {
            InitializeComponent();
            cmbBatchFill();
            dgvFill();
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

        private void dgvFill()
        {
            DataTable table = Database.selectData("SELECT * FROM `subject`  ");
            dgvSubject.DataSource = table;

            dgvSubject.Columns["subjectCode"].HeaderText = "Subject Code";
            dgvSubject.Columns["sunjectName"].HeaderText = "Sunject Name";
            dgvSubject.Columns["batch"].HeaderText = "Batch";


        }

        private void ClearText()
        {
            txtSubjectCode.Clear();
            txtSubjectName.Clear();
            cmbBatch.Text = string.Empty;
            
            txtSubjectCode.SelectAll();
        }

        private void AutoFillText()
        {
            DataTable dt = Database.selectData(@"SELECT `sunjectName`, `batch` FROM `subject` WHERE `subjectCode` = '" + txtSubjectCode.Text + "'");
            if (dt.Rows.Count == 1)
            {
                txtSubjectName.Text = dt.Rows[0][0].ToString();
                cmbBatch.Text = dt.Rows[0][1].ToString();

                btnInsert.Enabled = false;
                btnDelete.Enabled = true;
               

            }

            else
            {
                txtSubjectName.Clear();
                cmbBatch.Text = string.Empty;
                

                btnInsert.Enabled = true;
                btnDelete.Enabled = false;
            }

        }
        private void Insert()
        {

            if (txtSubjectCode.Text != string.Empty && txtSubjectName.Text != string.Empty && cmbBatch.Text != string.Empty && btnInsert.Enabled == true)
            {
                if (dgvSubject.Rows.Count == 0)
                {
                    Database.insert(@"INSERT INTO `subject`(`subjectCode`, `sunjectName`, `batch`) VALUES ('" + txtSubjectCode.Text + "','" + txtSubjectName.Text + "','" + cmbBatch.Text + "')");
                    dgvFill();
                    ClearText();
                }
                else
                {
                    alreadyExists = false;

                    for (int i = 0; i < dgvSubject.Rows.Count; ++i) // kalin thiyana
                    {
                        if (dgvSubject.Rows[i].Cells[0].Value.ToString() == txtSubjectCode.Text)
                        {

                            alreadyExists = true;
                            MessageBox.Show("This Subject is already exists.");
                            txtSubjectCode.SelectAll();
                            break;


                        }

                    }

                    if (alreadyExists == false)
                    {
                        Database.insert(@"INSERT INTO `subject`(`subjectCode`, `sunjectName`, `batch`) VALUES ('" + txtSubjectCode.Text + "','" + txtSubjectName.Text + "','" + cmbBatch.Text + "')");
                        dgvFill();
                        ClearText();


                    }



                }


            }


        }

        private void Delete()
        {
            if (txtSubjectCode.Text != string.Empty && txtSubjectName.Text != string.Empty && cmbBatch.Text != string.Empty && btnDelete.Enabled == true)
            {
                Database.insert(@"DELETE FROM `subject` WHERE `subjectCode` = '"+txtSubjectCode.Text+"'");
                dgvFill();
                ClearText();


            }


        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSubjectCode_TextChanged(object sender, EventArgs e)
        {
            AutoFillText();
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvSubject.Rows[index];

                txtSubjectCode.Text = selectedRow.Cells[0].Value.ToString();
                txtSubjectCode.SelectAll();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonPressWithoutSymbols(KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\\') || (e.KeyChar == '\'') || (e.KeyChar == ';') || (e.KeyChar == '"') || (e.KeyChar == ','))
            {
                e.Handled = true;
            }
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
                Delete();
            }
        }

        private void txtSubjectCode_KeyDown(object sender, KeyEventArgs e)
        {
            ButtonEnter (e);
        }

        private void txtSubjectName_KeyDown(object sender, KeyEventArgs e)
        {
            ButtonEnter(e);

        }

        private void txtSubjectCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            ButtonPressWithoutSymbols(e);
        }

        private void txtSubjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ButtonPressWithoutSymbols(e);

        }

        private void cmbBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Insert();
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
                Delete();
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

        
    }
}
