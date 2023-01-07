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
    public partial class frmLectures : Form
    {
        bool alreadyExists;

        public frmLectures()
        {
            InitializeComponent();
            cmbBatchFill();
            cmbSubjectFill();
            dgvFill();
        }

        private void dgvFill()
        {
            DataTable table = Database.selectData("SELECT * FROM `lecture`   ");
            dgvLecture.DataSource = table;

            dgvLecture.Columns["lectureName"].HeaderText = "Llecture Name";
            dgvLecture.Columns["subject"].HeaderText = "Subject Name";
            dgvLecture.Columns["subjectCode"].HeaderText = "Subject Code";
            dgvLecture.Columns["batch"].HeaderText = "Bbatch";


            //dgvLecture.Columns["subjectCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        public void cmbSubjectFill()
        {
            List<string> Subjectsize = new List<string>();

            DataTable dt = Database.selectData(@"SELECT *  FROM `subject` WHERE batch = '"+cmbBatch.Text+"' ");

            if(dt.Rows.Count != 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Subjectsize.Add(item[1].ToString());
                }
                cmbSubject.DataSource = Subjectsize;
            }
            else
            {
                lblSubjectCode.Text = string.Empty;
                cmbSubject.DataSource = null;
            }

           
        }
        private void Insert()
        {
            if(txtLectureName.Text != string.Empty && cmbBatch.Text != string.Empty && cmbSubject.Text != string.Empty) 
            {


                if (dgvLecture.Rows.Count == 0)
                {
                    Database.insert(@"INSERT INTO `lecture`(`lectureName`, `subject`, `subjectCode`, `batch`) VALUES
                        ('" + txtLectureName.Text + "','" + cmbSubject.Text + "','" + lblSubjectCode.Text + "','" + cmbBatch.Text + "')");
                    txtLectureName.Clear();
                    txtLectureName.SelectAll();
                    cmbBatch.Text = null;
                    cmbSubject.Text = string.Empty;
                    dgvFill();
                }
                else
                {
                    alreadyExists = false;

                    for (int i = 0; i < dgvLecture.Rows.Count; ++i) // kalin thiyana
                    {
                        if (dgvLecture.Rows[i].Cells[0].Value.ToString() == txtLectureName.Text && dgvLecture.Rows[i].Cells[2].Value.ToString() == lblSubjectCode.Text && dgvLecture.Rows[i].Cells[3].Value.ToString() == cmbBatch.Text)
                        {

                            alreadyExists = true;
                            MessageBox.Show("This Lecture  is already exists.");
                            txtLectureName.SelectAll();
                            break;


                        }

                    }

                    if (alreadyExists == false)
                    {
                        Database.insert(@"INSERT INTO `lecture`(`lectureName`, `subject`, `subjectCode`, `batch`) VALUES
                        ('" + txtLectureName.Text + "','" + cmbSubject.Text + "','" + lblSubjectCode.Text + "','" + cmbBatch.Text + "')");
                        txtLectureName.Clear();
                        txtLectureName.SelectAll();
                        cmbBatch.Text = null;
                        cmbSubject.Text = string.Empty;
                        dgvFill();

                        MessageBox.Show("This Lecture  is Added 😀 .");

                    }



                }

                //-----------------------------------------------------------------------
               
            }
        }

        private void Delete()
        {
            Database.insert(@"DELETE FROM `lecture` WHERE `lectureName`= '" + txtLectureName.Text + "' AND `subjectCode`= '" + lblSubjectCode.Text + "' AND `batch` = '" + cmbBatch.Text + "'");
            txtLectureName.Clear();
            txtLectureName.SelectAll();
            cmbBatch.Text = null;
            cmbSubject.Text = string.Empty;
            dgvFill();

            MessageBox.Show("This Lecture  is Deleted 🥵 .");
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            frmSetting frmSetting = new frmSetting();
            this.Hide();
            frmSetting.ShowDialog();
        }

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSubjectFill();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Database.selectData(@"SELECT `subjectCode`  FROM `subject` WHERE `sunjectName` = '" + cmbSubject.Text + "' AND `batch`= '"+cmbBatch.Text+"' ");
            if(dt.Rows.Count != 0 ) { lblSubjectCode.Text = dt.Rows[0][0].ToString(); }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dgvLecture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvLecture.Rows[index];

                txtLectureName.Text = selectedRow.Cells[0].Value.ToString();
                cmbSubject.Text = selectedRow.Cells[1].Value.ToString();
                lblSubjectCode.Text = selectedRow.Cells[2].Value.ToString();
                cmbBatch.Text = selectedRow.Cells[3].Value.ToString();

                txtLectureName.SelectAll();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLectureName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar == '\\') || (e.KeyChar == '\'') || (e.KeyChar == ';')))
            {
                e.Handled = true;
            }
        }

        private void txtLectureName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtLectureName.Clear();
            }
        }
    }
}
