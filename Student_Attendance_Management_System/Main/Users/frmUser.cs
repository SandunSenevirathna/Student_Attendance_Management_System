
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using Student_Attendance_Management_System.Codes;
using System.Data;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Attendance_Management_System.Main.Users
{
    public partial class frmUser : Form
    {
        NotifyIcon notifyIcon = new NotifyIcon();

        public frmUser()
        {
            InitializeComponent();

            // Create a notify icon and add it to the form

            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.Visible = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ClearText()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbPosition.Text = null;

            txtUsername.Focus();
        }

        private void AutoFillText(string Username)
        {
            DataTable dt = Database.selectData(@"SELECT `firstname`, `lastname`, `position`   FROM `user` WHERE `username` = '" + Username + "'");
            if (dt.Rows.Count == 1)
            {
                txtFirstName.Text = dt.Rows[0][0].ToString();
                txtLastName.Text = dt.Rows[0][1].ToString();
                cmbPosition.Text = dt.Rows[0][2].ToString();

                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }

            else
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPassword.Clear();
                cmbPosition.Text = null;

                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void InsertData(string userPassword)
        {

            string passwordHashString = Convert.ToBase64String(SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(userPassword)));
            // MessageBox.Show(userPassword + " = " + passwordHashString);
            //MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd").ToString());

            DateTime currentDate = DateTime.Now;

            if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && cmbPosition.Text != string.Empty)
            {
                Database.insert(
                    @"INSERT INTO `user`
                    (`firstname`, `lastname`, `position`, `username`, `password`, `registerdate`) 
                    VALUES
                    ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + cmbPosition.Text + "', '" + txtUsername.Text + "', '" + passwordHashString + "', '" + currentDate.ToString("yyyy-MM-dd") + "')"

                );

                notifyIcon.ShowBalloonTip(3000, "SAS", "This is a Insert Notifi.", ToolTipIcon.Info);
                ClearText();
            }

            else
            {
                txtUsername.Focus();

                notifyIcon.ShowBalloonTip(3000, "SAS", "Text Boxs are Empty", ToolTipIcon.Error);

            }

        }


        private void UpdateData(string userPassword)
        {

            string passwordHashString = Convert.ToBase64String(SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(userPassword)));
            // MessageBox.Show(userPassword + " = " + passwordHashString);
            //MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd").ToString());

            DateTime currentDate = DateTime.Now;

            if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && cmbPosition.Text != string.Empty)
            {
                Database.insert(
                    @"UPDATE `user` SET `firstname`='"+txtFirstName.Text+"',`lastname`='"+txtLastName.Text+"',`position`='"+cmbPosition.Text+"',`password`='"+ passwordHashString + "' WHERE `username`= '"+txtUsername.Text+"'"

                );;

                notifyIcon.ShowBalloonTip(3000, "SAS", "This is a Update Notifi.", ToolTipIcon.Info);
                ClearText();
            }

            else
            {
                txtUsername.Focus();
                notifyIcon.ShowBalloonTip(3000, "SAS", "Text Boxs are Empty", ToolTipIcon.Error);


            }

        }

        private void DeleteData(string Username)
        {

           

            if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtUsername.Text != string.Empty  && cmbPosition.Text != string.Empty)
            {
                Database.insert(@"DELETE FROM `user` WHERE `username`='"+ Username+ "'"); ;

                notifyIcon.ShowBalloonTip(3000, "SAS", "This is a Delete Notifi.", ToolTipIcon.Info);
                ClearText();
            }

            else
            {
                txtUsername.Focus();
                notifyIcon.ShowBalloonTip(3000, "SAS", "Text Boxs are Empty", ToolTipIcon.Error);


            }

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertData(txtPassword.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData(txtPassword.Text);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            AutoFillText(txtUsername.Text);
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                txtPassword.PasswordChar = '\0';
                btnShowPassword.Image = Properties.Resources.icons8_fingerprint_35px_1;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                btnShowPassword.Image = Properties.Resources.icons8_fingerprint_35px;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData(txtUsername.Text);
        }
    }
}
