namespace Student_Attendance_Management_System.Main.Setting
{
    partial class frmPosition
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
            this.lblSetting = new System.Windows.Forms.Label();
            this.imgSetting = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            this.dgvPosition = new Guna.UI.WinForms.GunaDataGridView();
            this.txtPosition = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnInsert = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
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
            this.lblSetting.Size = new System.Drawing.Size(74, 23);
            this.lblSetting.TabIndex = 18;
            this.lblSetting.Text = "Position";
            // 
            // imgSetting
            // 
            this.imgSetting.Image = global::Student_Attendance_Management_System.Properties.Resources.icons8_leaving_queue_skin_type_2_100px;
            this.imgSetting.Location = new System.Drawing.Point(24, 18);
            this.imgSetting.Name = "imgSetting";
            this.imgSetting.Size = new System.Drawing.Size(36, 38);
            this.imgSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSetting.TabIndex = 17;
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
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvPosition.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosition.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosition.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPosition.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosition.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPosition.EnableHeadersVisualStyles = false;
            this.dgvPosition.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvPosition.Location = new System.Drawing.Point(24, 76);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            this.dgvPosition.RowHeadersVisible = false;
            this.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosition.Size = new System.Drawing.Size(397, 335);
            this.dgvPosition.TabIndex = 19;
            this.dgvPosition.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
            this.dgvPosition.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvPosition.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPosition.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPosition.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPosition.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPosition.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPosition.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvPosition.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvPosition.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPosition.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvPosition.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPosition.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPosition.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvPosition.ThemeStyle.ReadOnly = true;
            this.dgvPosition.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvPosition.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPosition.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPosition.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPosition.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPosition.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvPosition.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPosition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosition_CellClick);
            // 
            // txtPosition
            // 
            this.txtPosition.AnimateReadOnly = false;
            this.txtPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPosition.Depth = 0;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPosition.HideSelection = true;
            this.txtPosition.Hint = "Type Position";
            this.txtPosition.LeadingIcon = null;
            this.txtPosition.Location = new System.Drawing.Point(451, 76);
            this.txtPosition.MaxLength = 100;
            this.txtPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.PasswordChar = '\0';
            this.txtPosition.PrefixSuffixText = null;
            this.txtPosition.ReadOnly = false;
            this.txtPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPosition.SelectedText = "";
            this.txtPosition.SelectionLength = 0;
            this.txtPosition.SelectionStart = 0;
            this.txtPosition.ShortcutsEnabled = true;
            this.txtPosition.Size = new System.Drawing.Size(287, 48);
            this.txtPosition.TabIndex = 0;
            this.txtPosition.TabStop = false;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPosition.TrailingIcon = null;
            this.txtPosition.UseSystemPasswordChar = false;
            this.txtPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosition_KeyDown);
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
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
            this.btnInsert.Enabled = false;
            this.btnInsert.FocusedColor = System.Drawing.Color.Empty;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = null;
            this.btnInsert.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInsert.LineColor = System.Drawing.Color.Transparent;
            this.btnInsert.Location = new System.Drawing.Point(451, 246);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.btnInsert.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnInsert.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInsert.OnHoverImage = null;
            this.btnInsert.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnInsert.OnPressedColor = System.Drawing.Color.Black;
            this.btnInsert.Radius = 5;
            this.btnInsert.Size = new System.Drawing.Size(287, 73);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.btnDelete.Enabled = false;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(451, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(287, 73);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.imgSetting);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPosition";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imgSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.PictureBox imgSetting;
        private MaterialSkin.Controls.MaterialTextBox2 txtPosition;
        private Guna.UI.WinForms.GunaDataGridView dgvPosition;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnInsert;
    }
}