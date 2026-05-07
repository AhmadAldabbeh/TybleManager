namespace TableManager
{
    partial class frmDeleteFormula
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
            this.DateForm1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTo1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comEmployeeName = new System.Windows.Forms.ComboBox();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbRowName = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRowName = new System.Windows.Forms.TextBox();
            this.gbDeleteALl = new System.Windows.Forms.GroupBox();
            this.DeleteAllFor_Table = new System.Windows.Forms.CheckBox();
            this.chDeleteAll = new System.Windows.Forms.CheckBox();
            this.chWithEmployee = new System.Windows.Forms.CheckBox();
            this.chWithRowName = new System.Windows.Forms.CheckBox();
            this.chWithDate = new System.Windows.Forms.CheckBox();
            this.gbEmployee.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.gbRowName.SuspendLayout();
            this.gbDeleteALl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateForm1
            // 
            this.DateForm1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateForm1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateForm1.Location = new System.Drawing.Point(70, 23);
            this.DateForm1.Name = "DateForm1";
            this.DateForm1.Size = new System.Drawing.Size(147, 26);
            this.DateForm1.TabIndex = 40;
            this.DateForm1.Value = new System.DateTime(2026, 1, 1, 3, 11, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "From : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "To :";
            // 
            // DateTo1
            // 
            this.DateTo1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTo1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo1.Location = new System.Drawing.Point(70, 74);
            this.DateTo1.Name = "DateTo1";
            this.DateTo1.Size = new System.Drawing.Size(147, 26);
            this.DateTo1.TabIndex = 41;
            this.DateTo1.Value = new System.DateTime(2026, 1, 1, 3, 9, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "EmployeeName : ";
            // 
            // comEmployeeName
            // 
            this.comEmployeeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comEmployeeName.FormattingEnabled = true;
            this.comEmployeeName.Location = new System.Drawing.Point(137, 19);
            this.comEmployeeName.Name = "comEmployeeName";
            this.comEmployeeName.Size = new System.Drawing.Size(181, 24);
            this.comEmployeeName.TabIndex = 46;
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.comEmployeeName);
            this.gbEmployee.Controls.Add(this.label8);
            this.gbEmployee.Enabled = false;
            this.gbEmployee.Location = new System.Drawing.Point(13, 28);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(343, 62);
            this.gbEmployee.TabIndex = 48;
            this.gbEmployee.TabStop = false;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.DateForm1);
            this.gbDate.Controls.Add(this.DateTo1);
            this.gbDate.Controls.Add(this.label7);
            this.gbDate.Controls.Add(this.label6);
            this.gbDate.Enabled = false;
            this.gbDate.Location = new System.Drawing.Point(9, 214);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(343, 123);
            this.gbDate.TabIndex = 49;
            this.gbDate.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(451, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 33);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(345, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 33);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbRowName
            // 
            this.gbRowName.Controls.Add(this.txtRowName);
            this.gbRowName.Controls.Add(this.label1);
            this.gbRowName.Enabled = false;
            this.gbRowName.Location = new System.Drawing.Point(9, 119);
            this.gbRowName.Name = "gbRowName";
            this.gbRowName.Size = new System.Drawing.Size(343, 66);
            this.gbRowName.TabIndex = 52;
            this.gbRowName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "RowName : ";
            // 
            // txtRowName
            // 
            this.txtRowName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRowName.Location = new System.Drawing.Point(141, 19);
            this.txtRowName.Name = "txtRowName";
            this.txtRowName.Size = new System.Drawing.Size(181, 26);
            this.txtRowName.TabIndex = 51;
            // 
            // gbDeleteALl
            // 
            this.gbDeleteALl.Controls.Add(this.DeleteAllFor_Table);
            this.gbDeleteALl.Enabled = false;
            this.gbDeleteALl.Location = new System.Drawing.Point(370, 28);
            this.gbDeleteALl.Name = "gbDeleteALl";
            this.gbDeleteALl.Size = new System.Drawing.Size(171, 56);
            this.gbDeleteALl.TabIndex = 53;
            this.gbDeleteALl.TabStop = false;
            // 
            // DeleteAllFor_Table
            // 
            this.DeleteAllFor_Table.AutoSize = true;
            this.DeleteAllFor_Table.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllFor_Table.Location = new System.Drawing.Point(6, 19);
            this.DeleteAllFor_Table.Name = "DeleteAllFor_Table";
            this.DeleteAllFor_Table.Size = new System.Drawing.Size(139, 20);
            this.DeleteAllFor_Table.TabIndex = 0;
            this.DeleteAllFor_Table.Text = "Delete All For Table";
            this.DeleteAllFor_Table.UseVisualStyleBackColor = true;
            // 
            // chDeleteAll
            // 
            this.chDeleteAll.AutoSize = true;
            this.chDeleteAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDeleteAll.Location = new System.Drawing.Point(376, 12);
            this.chDeleteAll.Name = "chDeleteAll";
            this.chDeleteAll.Size = new System.Drawing.Size(96, 17);
            this.chDeleteAll.TabIndex = 1;
            this.chDeleteAll.Text = "With Delete All";
            this.chDeleteAll.UseVisualStyleBackColor = true;
            this.chDeleteAll.CheckedChanged += new System.EventHandler(this.chDeleteAll_CheckedChanged);
            // 
            // chWithEmployee
            // 
            this.chWithEmployee.AutoSize = true;
            this.chWithEmployee.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWithEmployee.Location = new System.Drawing.Point(17, 12);
            this.chWithEmployee.Name = "chWithEmployee";
            this.chWithEmployee.Size = new System.Drawing.Size(97, 17);
            this.chWithEmployee.TabIndex = 48;
            this.chWithEmployee.Text = "With Employee";
            this.chWithEmployee.UseVisualStyleBackColor = true;
            this.chWithEmployee.CheckedChanged += new System.EventHandler(this.chWithEmployee_CheckedChanged);
            // 
            // chWithRowName
            // 
            this.chWithRowName.AutoSize = true;
            this.chWithRowName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWithRowName.Location = new System.Drawing.Point(15, 105);
            this.chWithRowName.Name = "chWithRowName";
            this.chWithRowName.Size = new System.Drawing.Size(99, 17);
            this.chWithRowName.TabIndex = 52;
            this.chWithRowName.Text = "With RowName";
            this.chWithRowName.UseVisualStyleBackColor = true;
            this.chWithRowName.CheckedChanged += new System.EventHandler(this.chWithRowName_CheckedChanged);
            // 
            // chWithDate
            // 
            this.chWithDate.AutoSize = true;
            this.chWithDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWithDate.Location = new System.Drawing.Point(13, 200);
            this.chWithDate.Name = "chWithDate";
            this.chWithDate.Size = new System.Drawing.Size(108, 17);
            this.chWithDate.TabIndex = 44;
            this.chWithDate.Text = "With Date Range";
            this.chWithDate.UseVisualStyleBackColor = true;
            this.chWithDate.CheckedChanged += new System.EventHandler(this.chWithDate_CheckedChanged);
            // 
            // frmDeleteFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 405);
            this.Controls.Add(this.chDeleteAll);
            this.Controls.Add(this.chWithEmployee);
            this.Controls.Add(this.chWithRowName);
            this.Controls.Add(this.chWithDate);
            this.Controls.Add(this.gbDeleteALl);
            this.Controls.Add(this.gbRowName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.gbEmployee);
            this.Name = "frmDeleteFormula";
            this.Text = "frmDeleteFormula";
            this.Load += new System.EventHandler(this.frmDeleteFormula_Load);
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.gbRowName.ResumeLayout(false);
            this.gbRowName.PerformLayout();
            this.gbDeleteALl.ResumeLayout(false);
            this.gbDeleteALl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateForm1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comEmployeeName;
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbRowName;
        private System.Windows.Forms.TextBox txtRowName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDeleteALl;
        private System.Windows.Forms.CheckBox chDeleteAll;
        private System.Windows.Forms.CheckBox DeleteAllFor_Table;
        private System.Windows.Forms.CheckBox chWithEmployee;
        private System.Windows.Forms.CheckBox chWithDate;
        private System.Windows.Forms.CheckBox chWithRowName;
    }
}