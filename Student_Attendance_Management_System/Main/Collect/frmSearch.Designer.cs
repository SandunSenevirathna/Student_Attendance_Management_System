namespace Student_Attendance_Management_System.Main.Collect
{
    partial class frmSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblSetting = new System.Windows.Forms.Label();
            this.txtRegistrationNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.dgvStudent = new Guna.UI.WinForms.GunaDataGridView();
            this.imgSetting = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.Location = new System.Drawing.Point(66, 26);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(63, 23);
            this.lblSetting.TabIndex = 35;
            this.lblSetting.Text = "Search";
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistrationNumber.BaseColor = System.Drawing.Color.White;
            this.txtRegistrationNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtRegistrationNumber.BorderSize = 1;
            this.txtRegistrationNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegistrationNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRegistrationNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRegistrationNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRegistrationNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationNumber.Location = new System.Drawing.Point(467, 18);
            this.txtRegistrationNumber.MaxLength = 50;
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.PasswordChar = '\0';
            this.txtRegistrationNumber.Radius = 5;
            this.txtRegistrationNumber.SelectedText = "";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(261, 42);
            this.txtRegistrationNumber.TabIndex = 0;
            this.txtRegistrationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistrationNumber.TextChanged += new System.EventHandler(this.txtRegistrationNumber_TextChanged);
            this.txtRegistrationNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegistrationNumber_KeyDown);
            this.txtRegistrationNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistrationNumber_KeyPress);
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel12.Location = new System.Drawing.Point(281, 28);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(171, 21);
            this.gunaLabel12.TabIndex = 37;
            this.gunaLabel12.Text = "Registration Number :";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudent.EnableHeadersVisualStyles = false;
            this.dgvStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvStudent.Location = new System.Drawing.Point(24, 79);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(737, 332);
            this.dgvStudent.TabIndex = 1;
            this.dgvStudent.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvStudent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvStudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvStudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudent.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvStudent.ThemeStyle.ReadOnly = true;
            this.dgvStudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvStudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStudent.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvStudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellDoubleClick);
            this.dgvStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvStudent_KeyDown);
            // 
            // imgSetting
            // 
            this.imgSetting.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_search_100px_1;
            this.imgSetting.Location = new System.Drawing.Point(24, 18);
            this.imgSetting.Name = "imgSetting";
            this.imgSetting.Size = new System.Drawing.Size(36, 38);
            this.imgSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSetting.TabIndex = 34;
            this.imgSetting.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(748, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 33;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.imgSetting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRegistrationNumber);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.dgvStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.PictureBox imgSetting;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        private Guna.UI.WinForms.GunaTextBox txtRegistrationNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaDataGridView dgvStudent;
    }
}