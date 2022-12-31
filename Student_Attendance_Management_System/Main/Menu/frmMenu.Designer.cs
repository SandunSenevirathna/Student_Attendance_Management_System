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
            this.gunaAdvenceTileButton6 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton5 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton4 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton3 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton2 = new Guna.UI.WinForms.GunaAdvenceTileButton();
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
            // gunaAdvenceTileButton6
            // 
            this.gunaAdvenceTileButton6.Animated = true;
            this.gunaAdvenceTileButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(117)))), ((int)(((byte)(93)))));
            this.gunaAdvenceTileButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton6.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton6.CheckedImage = null;
            this.gunaAdvenceTileButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton6.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton6.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_Logout_Rounded_100px;
            this.gunaAdvenceTileButton6.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaAdvenceTileButton6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton6.Location = new System.Drawing.Point(577, 308);
            this.gunaAdvenceTileButton6.Name = "gunaAdvenceTileButton6";
            this.gunaAdvenceTileButton6.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton6.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton6.OnHoverImage = null;
            this.gunaAdvenceTileButton6.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton6.OnPressedDepth = 50;
            this.gunaAdvenceTileButton6.Radius = 20;
            this.gunaAdvenceTileButton6.Size = new System.Drawing.Size(170, 170);
            this.gunaAdvenceTileButton6.TabIndex = 6;
            this.gunaAdvenceTileButton6.Text = "Logout";
            this.gunaAdvenceTileButton6.TextImageOffsetY = 10;
            // 
            // gunaAdvenceTileButton5
            // 
            this.gunaAdvenceTileButton5.Animated = true;
            this.gunaAdvenceTileButton5.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton5.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.gunaAdvenceTileButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton5.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton5.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton5.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton5.CheckedImage = null;
            this.gunaAdvenceTileButton5.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton5.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton5.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_user_100px;
            this.gunaAdvenceTileButton5.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaAdvenceTileButton5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton5.Location = new System.Drawing.Point(355, 308);
            this.gunaAdvenceTileButton5.Name = "gunaAdvenceTileButton5";
            this.gunaAdvenceTileButton5.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton5.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton5.OnHoverImage = null;
            this.gunaAdvenceTileButton5.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton5.OnPressedDepth = 50;
            this.gunaAdvenceTileButton5.Radius = 20;
            this.gunaAdvenceTileButton5.Size = new System.Drawing.Size(170, 170);
            this.gunaAdvenceTileButton5.TabIndex = 5;
            this.gunaAdvenceTileButton5.Text = "Users";
            this.gunaAdvenceTileButton5.TextImageOffsetY = 10;
            // 
            // gunaAdvenceTileButton4
            // 
            this.gunaAdvenceTileButton4.Animated = true;
            this.gunaAdvenceTileButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.gunaAdvenceTileButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton4.CheckedImage = null;
            this.gunaAdvenceTileButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton4.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_data_backup_100px;
            this.gunaAdvenceTileButton4.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaAdvenceTileButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton4.Location = new System.Drawing.Point(132, 308);
            this.gunaAdvenceTileButton4.Name = "gunaAdvenceTileButton4";
            this.gunaAdvenceTileButton4.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton4.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton4.OnHoverImage = null;
            this.gunaAdvenceTileButton4.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton4.OnPressedDepth = 50;
            this.gunaAdvenceTileButton4.Radius = 20;
            this.gunaAdvenceTileButton4.Size = new System.Drawing.Size(170, 170);
            this.gunaAdvenceTileButton4.TabIndex = 4;
            this.gunaAdvenceTileButton4.Text = "Backup";
            this.gunaAdvenceTileButton4.TextImageOffsetY = 10;
            // 
            // gunaAdvenceTileButton3
            // 
            this.gunaAdvenceTileButton3.Animated = true;
            this.gunaAdvenceTileButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.gunaAdvenceTileButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton3.CheckedImage = null;
            this.gunaAdvenceTileButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton3.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_settings_100px;
            this.gunaAdvenceTileButton3.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaAdvenceTileButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton3.Location = new System.Drawing.Point(577, 104);
            this.gunaAdvenceTileButton3.Name = "gunaAdvenceTileButton3";
            this.gunaAdvenceTileButton3.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton3.OnHoverImage = null;
            this.gunaAdvenceTileButton3.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.OnPressedDepth = 50;
            this.gunaAdvenceTileButton3.Radius = 20;
            this.gunaAdvenceTileButton3.Size = new System.Drawing.Size(170, 170);
            this.gunaAdvenceTileButton3.TabIndex = 3;
            this.gunaAdvenceTileButton3.Text = "Setting";
            this.gunaAdvenceTileButton3.TextImageOffsetY = 10;
            // 
            // gunaAdvenceTileButton2
            // 
            this.gunaAdvenceTileButton2.Animated = true;
            this.gunaAdvenceTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(58)))), ((int)(((byte)(30)))));
            this.gunaAdvenceTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.CheckedImage = null;
            this.gunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_line_chart_100px;
            this.gunaAdvenceTileButton2.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaAdvenceTileButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.Location = new System.Drawing.Point(355, 104);
            this.gunaAdvenceTileButton2.Name = "gunaAdvenceTileButton2";
            this.gunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.OnHoverImage = null;
            this.gunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.OnPressedDepth = 50;
            this.gunaAdvenceTileButton2.Radius = 20;
            this.gunaAdvenceTileButton2.Size = new System.Drawing.Size(170, 170);
            this.gunaAdvenceTileButton2.TabIndex = 2;
            this.gunaAdvenceTileButton2.Text = "Reports";
            this.gunaAdvenceTileButton2.TextImageOffsetY = 10;
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
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.gunaAdvenceTileButton6);
            this.Controls.Add(this.gunaAdvenceTileButton5);
            this.Controls.Add(this.gunaAdvenceTileButton4);
            this.Controls.Add(this.gunaAdvenceTileButton3);
            this.Controls.Add(this.gunaAdvenceTileButton2);
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
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton6;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton5;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton4;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton3;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerDateTime;
    }
}