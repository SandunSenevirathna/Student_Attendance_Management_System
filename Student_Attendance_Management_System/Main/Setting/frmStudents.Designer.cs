namespace Student_Attendance_Management_System.Main.Setting
{
    partial class frmStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblSetting = new System.Windows.Forms.Label();
            this.imgSetting = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnInsert = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtRegistrationNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtStudentName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDepartment = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbBatch = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudent = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.Location = new System.Drawing.Point(66, 24);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(101, 29);
            this.lblSetting.TabIndex = 19;
            this.lblSetting.Text = "Students";
            // 
            // imgSetting
            // 
            this.imgSetting.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_students_100px_1;
            this.imgSetting.Location = new System.Drawing.Point(12, 12);
            this.imgSetting.Name = "imgSetting";
            this.imgSetting.Size = new System.Drawing.Size(48, 52);
            this.imgSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSetting.TabIndex = 18;
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
            this.btnClose.Location = new System.Drawing.Point(1314, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 17;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(52, 631);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(286, 77);
            this.btnDelete.TabIndex = 26;
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
            this.btnInsert.Location = new System.Drawing.Point(50, 446);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.btnInsert.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnInsert.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInsert.OnHoverImage = null;
            this.btnInsert.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnInsert.OnPressedColor = System.Drawing.Color.Black;
            this.btnInsert.Radius = 5;
            this.btnInsert.Size = new System.Drawing.Size(286, 77);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.AnimateReadOnly = false;
            this.txtRegistrationNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegistrationNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegistrationNumber.Depth = 0;
            this.txtRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegistrationNumber.HideSelection = true;
            this.txtRegistrationNumber.Hint = "Registration Number";
            this.txtRegistrationNumber.LeadingIcon = null;
            this.txtRegistrationNumber.Location = new System.Drawing.Point(51, 110);
            this.txtRegistrationNumber.MaxLength = 50;
            this.txtRegistrationNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.PasswordChar = '\0';
            this.txtRegistrationNumber.PrefixSuffixText = null;
            this.txtRegistrationNumber.ReadOnly = false;
            this.txtRegistrationNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistrationNumber.SelectedText = "";
            this.txtRegistrationNumber.SelectionLength = 0;
            this.txtRegistrationNumber.SelectionStart = 0;
            this.txtRegistrationNumber.ShortcutsEnabled = true;
            this.txtRegistrationNumber.Size = new System.Drawing.Size(287, 48);
            this.txtRegistrationNumber.TabIndex = 0;
            this.txtRegistrationNumber.TabStop = false;
            this.txtRegistrationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegistrationNumber.TrailingIcon = null;
            this.txtRegistrationNumber.UseSystemPasswordChar = false;
            this.txtRegistrationNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegistrationNumber_KeyDown);
            this.txtRegistrationNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistrationNumber_KeyPress);
            this.txtRegistrationNumber.TextChanged += new System.EventHandler(this.txtRegistrationNumber_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImage = null;
            this.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.LineColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(51, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(286, 77);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.AnimateReadOnly = false;
            this.txtStudentName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtStudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStudentName.Depth = 0;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStudentName.HideSelection = true;
            this.txtStudentName.Hint = "Student Name";
            this.txtStudentName.LeadingIcon = null;
            this.txtStudentName.Location = new System.Drawing.Point(51, 188);
            this.txtStudentName.MaxLength = 100;
            this.txtStudentName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.PrefixSuffixText = null;
            this.txtStudentName.ReadOnly = false;
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.SelectionLength = 0;
            this.txtStudentName.SelectionStart = 0;
            this.txtStudentName.ShortcutsEnabled = true;
            this.txtStudentName.Size = new System.Drawing.Size(287, 48);
            this.txtStudentName.TabIndex = 1;
            this.txtStudentName.TabStop = false;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentName.TrailingIcon = null;
            this.txtStudentName.UseSystemPasswordChar = false;
            this.txtStudentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentName_KeyDown);
            this.txtStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentName_KeyPress);
            // 
            // txtDepartment
            // 
            this.txtDepartment.AnimateReadOnly = false;
            this.txtDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDepartment.Depth = 0;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDepartment.HideSelection = true;
            this.txtDepartment.Hint = "Department (ITT, EET, MTT, BPT ..) ";
            this.txtDepartment.LeadingIcon = null;
            this.txtDepartment.Location = new System.Drawing.Point(51, 271);
            this.txtDepartment.MaxLength = 5;
            this.txtDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.PasswordChar = '\0';
            this.txtDepartment.PrefixSuffixText = null;
            this.txtDepartment.ReadOnly = false;
            this.txtDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDepartment.SelectedText = "";
            this.txtDepartment.SelectionLength = 0;
            this.txtDepartment.SelectionStart = 0;
            this.txtDepartment.ShortcutsEnabled = true;
            this.txtDepartment.Size = new System.Drawing.Size(287, 48);
            this.txtDepartment.TabIndex = 2;
            this.txtDepartment.TabStop = false;
            this.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDepartment.TrailingIcon = null;
            this.txtDepartment.UseSystemPasswordChar = false;
            this.txtDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDepartment_KeyDown);
            this.txtDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartment_KeyPress);
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
            this.cmbBatch.Location = new System.Drawing.Point(126, 363);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbBatch.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBatch.Radius = 3;
            this.cmbBatch.Size = new System.Drawing.Size(212, 40);
            this.cmbBatch.TabIndex = 3;
            this.cmbBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBatch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Batch :";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvStudent.EnableHeadersVisualStyles = false;
            this.dgvStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvStudent.Location = new System.Drawing.Point(376, 110);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(925, 598);
            this.dgvStudent.TabIndex = 32;
            this.dgvStudent.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvStudent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvStudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvStudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudent.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvStudent.ThemeStyle.ReadOnly = true;
            this.dgvStudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvStudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStudent.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvStudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtRegistrationNumber);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.imgSetting);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudents";
            this.Text = "frmStudents";
            ((System.ComponentModel.ISupportInitialize)(this.imgSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.PictureBox imgSetting;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        private MaterialSkin.Controls.MaterialTextBox2 txtDepartment;
        private MaterialSkin.Controls.MaterialTextBox2 txtStudentName;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnInsert;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegistrationNumber;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmbBatch;
        private Guna.UI.WinForms.GunaDataGridView dgvStudent;
    }
}