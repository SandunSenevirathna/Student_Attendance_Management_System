namespace Student_Attendance_Management_System.Main.Setting
{
    partial class frmLectures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dgvLecture = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBatch = new Guna.UI.WinForms.GunaComboBox();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnInsert = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtLectureName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblSetting = new System.Windows.Forms.Label();
            this.imgSetting = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSubject = new Guna.UI.WinForms.GunaComboBox();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this;
            // 
            // dgvLecture
            // 
            this.dgvLecture.AllowUserToAddRows = false;
            this.dgvLecture.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvLecture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLecture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLecture.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLecture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLecture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLecture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLecture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLecture.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLecture.EnableHeadersVisualStyles = false;
            this.dgvLecture.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvLecture.Location = new System.Drawing.Point(528, 109);
            this.dgvLecture.Name = "dgvLecture";
            this.dgvLecture.ReadOnly = true;
            this.dgvLecture.RowHeadersVisible = false;
            this.dgvLecture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLecture.Size = new System.Drawing.Size(810, 598);
            this.dgvLecture.TabIndex = 44;
            this.dgvLecture.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
            this.dgvLecture.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvLecture.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLecture.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLecture.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLecture.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLecture.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvLecture.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvLecture.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvLecture.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLecture.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLecture.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLecture.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLecture.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvLecture.ThemeStyle.ReadOnly = true;
            this.dgvLecture.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvLecture.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLecture.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLecture.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLecture.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLecture.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvLecture.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLecture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecture_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Batch :";
            // 
            // cmbBatch
            // 
            this.cmbBatch.BackColor = System.Drawing.Color.Transparent;
            this.cmbBatch.BaseColor = System.Drawing.Color.White;
            this.cmbBatch.BorderColor = System.Drawing.Color.Silver;
            this.cmbBatch.BorderSize = 1;
            this.cmbBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBatch.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBatch.ForeColor = System.Drawing.Color.Black;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(144, 208);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbBatch.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBatch.Radius = 3;
            this.cmbBatch.Size = new System.Drawing.Size(196, 40);
            this.cmbBatch.TabIndex = 36;
            this.cmbBatch.SelectedIndexChanged += new System.EventHandler(this.cmbBatch_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = null;
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(50, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(445, 131);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Animated = true;
            this.btnInsert.AnimationHoverSpeed = 0.07F;
            this.btnInsert.AnimationSpeed = 0.03F;
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnInsert.BorderColor = System.Drawing.Color.Transparent;
            this.btnInsert.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnInsert.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnInsert.CheckedForeColor = System.Drawing.Color.White;
            this.btnInsert.CheckedImage = null;
            this.btnInsert.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInsert.FocusedColor = System.Drawing.Color.Empty;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = null;
            this.btnInsert.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInsert.LineColor = System.Drawing.Color.Transparent;
            this.btnInsert.Location = new System.Drawing.Point(50, 421);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.btnInsert.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnInsert.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInsert.OnHoverImage = null;
            this.btnInsert.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnInsert.OnPressedColor = System.Drawing.Color.Black;
            this.btnInsert.Radius = 5;
            this.btnInsert.Size = new System.Drawing.Size(445, 131);
            this.btnInsert.TabIndex = 40;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtLectureName
            // 
            this.txtLectureName.AnimateReadOnly = false;
            this.txtLectureName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLectureName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLectureName.Depth = 0;
            this.txtLectureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLectureName.HideSelection = true;
            this.txtLectureName.Hint = "Lecture Name";
            this.txtLectureName.LeadingIcon = null;
            this.txtLectureName.Location = new System.Drawing.Point(51, 109);
            this.txtLectureName.MaxLength = 50;
            this.txtLectureName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLectureName.Name = "txtLectureName";
            this.txtLectureName.PasswordChar = '\0';
            this.txtLectureName.PrefixSuffixText = null;
            this.txtLectureName.ReadOnly = false;
            this.txtLectureName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLectureName.SelectedText = "";
            this.txtLectureName.SelectionLength = 0;
            this.txtLectureName.SelectionStart = 0;
            this.txtLectureName.ShortcutsEnabled = true;
            this.txtLectureName.Size = new System.Drawing.Size(444, 48);
            this.txtLectureName.TabIndex = 33;
            this.txtLectureName.TabStop = false;
            this.txtLectureName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLectureName.TrailingIcon = null;
            this.txtLectureName.UseSystemPasswordChar = false;
            this.txtLectureName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLectureName_KeyDown);
            this.txtLectureName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLectureName_KeyPress);
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.Location = new System.Drawing.Point(83, 25);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(97, 29);
            this.lblSetting.TabIndex = 39;
            this.lblSetting.Text = "Lectures";
            // 
            // imgSetting
            // 
            this.imgSetting.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_classroom_100px_2;
            this.imgSetting.Location = new System.Drawing.Point(29, 13);
            this.imgSetting.Name = "imgSetting";
            this.imgSetting.Size = new System.Drawing.Size(48, 52);
            this.imgSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSetting.TabIndex = 38;
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
            this.btnClose.Location = new System.Drawing.Point(1314, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 37;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "Subject :";
            // 
            // cmbSubject
            // 
            this.cmbSubject.BackColor = System.Drawing.Color.Transparent;
            this.cmbSubject.BaseColor = System.Drawing.Color.White;
            this.cmbSubject.BorderColor = System.Drawing.Color.Silver;
            this.cmbSubject.BorderSize = 1;
            this.cmbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.ForeColor = System.Drawing.Color.Black;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(144, 296);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbSubject.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSubject.Radius = 3;
            this.cmbSubject.Size = new System.Drawing.Size(351, 35);
            this.cmbSubject.TabIndex = 45;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSubjectCode.Location = new System.Drawing.Point(373, 208);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(108, 32);
            this.lblSubjectCode.TabIndex = 47;
            this.lblSubjectCode.Text = "ICT 2207";
            // 
            // frmLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblSubjectCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.dgvLecture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtLectureName);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.imgSetting);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLectures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLectures";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView dgvLecture;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmbBatch;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnInsert;
        private MaterialSkin.Controls.MaterialTextBox2 txtLectureName;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.PictureBox imgSetting;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cmbSubject;
    }
}