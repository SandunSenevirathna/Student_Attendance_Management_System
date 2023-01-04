namespace Student_Attendance_Management_System.Menu
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnUsers = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnBackup = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnSetting = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnReports = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnCollect = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Black;
            this.gunaPanel1.Controls.Add(this.pictureBox4);
            this.gunaPanel1.Controls.Add(this.lblUserName);
            this.gunaPanel1.Controls.Add(this.pictureBox2);
            this.gunaPanel1.Controls.Add(this.btnClose);
            this.gunaPanel1.Controls.Add(this.lblTime);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.lblDate);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(864, 57);
            this.gunaPanel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_account_40px;
            this.pictureBox4.Location = new System.Drawing.Point(25, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Black;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(69, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(116, 21);
            this.lblUserName.TabIndex = 37;
            this.lblUserName.Text = "MR. Buddhika";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_calendar_40px;
            this.pictureBox2.Location = new System.Drawing.Point(328, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_cancel_50px;
            this.btnClose.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.Location = new System.Drawing.Point(812, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(226, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(78, 21);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "12:56:33";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_clock_40px;
            this.pictureBox1.Location = new System.Drawing.Point(195, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Black;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(359, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 21);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "2021-02-31";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel1;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(117)))), ((int)(((byte)(93)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImage = null;
            this.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_Logout_Rounded_100px;
            this.btnLogout.ImageSize = new System.Drawing.Size(60, 60);
            this.btnLogout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.Location = new System.Drawing.Point(577, 308);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.OnPressedDepth = 50;
            this.btnLogout.Radius = 20;
            this.btnLogout.Size = new System.Drawing.Size(170, 170);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageOffsetY = 10;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.AnimationHoverSpeed = 0.07F;
            this.btnUsers.AnimationSpeed = 0.03F;
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btnUsers.BorderColor = System.Drawing.Color.Black;
            this.btnUsers.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUsers.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUsers.CheckedForeColor = System.Drawing.Color.White;
            this.btnUsers.CheckedImage = null;
            this.btnUsers.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsers.FocusedColor = System.Drawing.Color.Empty;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_user_100px;
            this.btnUsers.ImageSize = new System.Drawing.Size(60, 60);
            this.btnUsers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUsers.Location = new System.Drawing.Point(355, 308);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnUsers.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnUsers.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUsers.OnHoverImage = null;
            this.btnUsers.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnUsers.OnPressedColor = System.Drawing.Color.Black;
            this.btnUsers.OnPressedDepth = 50;
            this.btnUsers.Radius = 20;
            this.btnUsers.Size = new System.Drawing.Size(170, 170);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextImageOffsetY = 10;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Animated = true;
            this.btnBackup.AnimationHoverSpeed = 0.07F;
            this.btnBackup.AnimationSpeed = 0.03F;
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(101)))), ((int)(((byte)(103)))));
            this.btnBackup.BorderColor = System.Drawing.Color.Black;
            this.btnBackup.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBackup.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBackup.CheckedForeColor = System.Drawing.Color.White;
            this.btnBackup.CheckedImage = null;
            this.btnBackup.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBackup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackup.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_data_backup_100px;
            this.btnBackup.ImageSize = new System.Drawing.Size(60, 60);
            this.btnBackup.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBackup.Location = new System.Drawing.Point(132, 308);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnBackup.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnBackup.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackup.OnHoverImage = null;
            this.btnBackup.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnBackup.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackup.OnPressedDepth = 50;
            this.btnBackup.Radius = 20;
            this.btnBackup.Size = new System.Drawing.Size(170, 170);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextImageOffsetY = 10;
            // 
            // btnSetting
            // 
            this.btnSetting.Animated = true;
            this.btnSetting.AnimationHoverSpeed = 0.07F;
            this.btnSetting.AnimationSpeed = 0.03F;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.btnSetting.BorderColor = System.Drawing.Color.Black;
            this.btnSetting.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSetting.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSetting.CheckedForeColor = System.Drawing.Color.White;
            this.btnSetting.CheckedImage = null;
            this.btnSetting.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSetting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSetting.FocusedColor = System.Drawing.Color.Empty;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_settings_100px;
            this.btnSetting.ImageSize = new System.Drawing.Size(60, 60);
            this.btnSetting.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSetting.Location = new System.Drawing.Point(577, 104);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnSetting.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSetting.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSetting.OnHoverImage = null;
            this.btnSetting.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnSetting.OnPressedColor = System.Drawing.Color.Black;
            this.btnSetting.OnPressedDepth = 50;
            this.btnSetting.Radius = 20;
            this.btnSetting.Size = new System.Drawing.Size(170, 170);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextImageOffsetY = 10;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.AnimationHoverSpeed = 0.07F;
            this.btnReports.AnimationSpeed = 0.03F;
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(58)))), ((int)(((byte)(30)))));
            this.btnReports.BorderColor = System.Drawing.Color.Black;
            this.btnReports.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReports.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReports.CheckedForeColor = System.Drawing.Color.White;
            this.btnReports.CheckedImage = null;
            this.btnReports.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReports.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReports.FocusedColor = System.Drawing.Color.Empty;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_line_chart_100px;
            this.btnReports.ImageSize = new System.Drawing.Size(60, 60);
            this.btnReports.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReports.Location = new System.Drawing.Point(355, 104);
            this.btnReports.Name = "btnReports";
            this.btnReports.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnReports.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnReports.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReports.OnHoverImage = null;
            this.btnReports.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnReports.OnPressedColor = System.Drawing.Color.Black;
            this.btnReports.OnPressedDepth = 50;
            this.btnReports.Radius = 20;
            this.btnReports.Size = new System.Drawing.Size(170, 170);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.TextImageOffsetY = 10;
            // 
            // btnCollect
            // 
            this.btnCollect.Animated = true;
            this.btnCollect.AnimationHoverSpeed = 0.07F;
            this.btnCollect.AnimationSpeed = 0.03F;
            this.btnCollect.BackColor = System.Drawing.Color.Transparent;
            this.btnCollect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnCollect.BorderColor = System.Drawing.Color.Black;
            this.btnCollect.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCollect.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCollect.CheckedForeColor = System.Drawing.Color.White;
            this.btnCollect.CheckedImage = null;
            this.btnCollect.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCollect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCollect.FocusedColor = System.Drawing.Color.Empty;
            this.btnCollect.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollect.ForeColor = System.Drawing.Color.White;
            this.btnCollect.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_barcode_reader_100px_1;
            this.btnCollect.ImageSize = new System.Drawing.Size(60, 60);
            this.btnCollect.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCollect.Location = new System.Drawing.Point(132, 104);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnCollect.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCollect.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCollect.OnHoverImage = null;
            this.btnCollect.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnCollect.OnPressedColor = System.Drawing.Color.Black;
            this.btnCollect.OnPressedDepth = 50;
            this.btnCollect.Radius = 20;
            this.btnCollect.Size = new System.Drawing.Size(170, 170);
            this.btnCollect.TabIndex = 1;
            this.btnCollect.Text = "Collect";
            this.btnCollect.TextImageOffsetY = 10;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 300;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCollect);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnCollect;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnLogout;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnUsers;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnBackup;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnSetting;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnReports;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerDateTime;
    }
}