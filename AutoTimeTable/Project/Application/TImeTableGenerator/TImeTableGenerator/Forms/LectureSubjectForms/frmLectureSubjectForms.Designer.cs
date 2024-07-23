﻿
namespace TImeTableGenerator.Forms.LectureSubjectForms
{
    partial class frmLectureSubjectForms
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
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmsedit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvTeacherSubjects = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.cmsOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSubjects)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(536, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(697, 30);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmsedit
            // 
            this.cmsedit.Name = "cmsedit";
            this.cmsedit.Size = new System.Drawing.Size(269, 24);
            this.cmsedit.Text = "Status Change (for Lecturer): ";
            this.cmsedit.Click += new System.EventHandler(this.cmsedit_Click);
            // 
            // cmsOption
            // 
            this.cmsOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsedit});
            this.cmsOption.Name = "cmsOption";
            this.cmsOption.Size = new System.Drawing.Size(270, 28);
            // 
            // dgvTeacherSubjects
            // 
            this.dgvTeacherSubjects.AllowUserToAddRows = false;
            this.dgvTeacherSubjects.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTeacherSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeacherSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherSubjects.ContextMenuStrip = this.cmsOption;
            this.dgvTeacherSubjects.Location = new System.Drawing.Point(536, 74);
            this.dgvTeacherSubjects.MultiSelect = false;
            this.dgvTeacherSubjects.Name = "dgvTeacherSubjects";
            this.dgvTeacherSubjects.ReadOnly = true;
            this.dgvTeacherSubjects.RowHeadersVisible = false;
            this.dgvTeacherSubjects.RowHeadersWidth = 51;
            this.dgvTeacherSubjects.RowTemplate.Height = 24;
            this.dgvTeacherSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherSubjects.Size = new System.Drawing.Size(697, 587);
            this.dgvTeacherSubjects.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search: ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(329, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(167, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 51);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTeachers);
            this.groupBox2.Location = new System.Drawing.Point(21, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Teacher and Lecturer :";
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(12, 31);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.Size = new System.Drawing.Size(440, 39);
            this.cmbTeachers.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 279);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 29);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(21, 247);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(78, 21);
            this.chkStatus.TabIndex = 10;
            this.chkStatus.Text = "Status: ";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbSubjects);
            this.groupBox5.Location = new System.Drawing.Point(21, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(474, 74);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Subjects :";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(12, 29);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(440, 39);
            this.cmbSubjects.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 654);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lectures and Subjects:";
            // 
            // frmLectureSubjectForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 677);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvTeacherSubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLectureSubjectForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer and Subject Allotments";
            this.Load += new System.EventHandler(this.frmLectureSubjectForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.cmsOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSubjects)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvTeacherSubjects;
        private System.Windows.Forms.ContextMenuStrip cmsOption;
        private System.Windows.Forms.ToolStripMenuItem cmsedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}