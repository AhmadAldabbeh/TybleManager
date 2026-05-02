namespace TableManager
{
    partial class frmAdd_UpdateRows
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.comFieldName = new System.Windows.Forms.ComboBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Add_UpdateRowDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.comEmployeeName = new System.Windows.Forms.ComboBox();
            this.chAddEmployee = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(111, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(156, 33);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Add/Update";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(293, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtValue
            // 
            this.txtValue.Enabled = false;
            this.txtValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(150, 249);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(239, 27);
            this.txtValue.TabIndex = 2;
            // 
            // comFieldName
            // 
            this.comFieldName.Enabled = false;
            this.comFieldName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFieldName.FormattingEnabled = true;
            this.comFieldName.Location = new System.Drawing.Point(149, 186);
            this.comFieldName.Name = "comFieldName";
            this.comFieldName.Size = new System.Drawing.Size(239, 24);
            this.comFieldName.TabIndex = 3;
            this.comFieldName.SelectedIndexChanged += new System.EventHandler(this.comFieldName_SelectedIndexChanged);
            this.comFieldName.Validating += new System.ComponentModel.CancelEventHandler(this.comFieldName_Validating);
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Enabled = false;
            this.lblFieldName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldName.Location = new System.Drawing.Point(45, 186);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(94, 19);
            this.lblFieldName.TabIndex = 4;
            this.lblFieldName.Text = "FieldName :";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Enabled = false;
            this.lblValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(71, 252);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(71, 19);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Values : ";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(183, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Add_UpdateRowDatePicker
            // 
            this.Add_UpdateRowDatePicker.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_UpdateRowDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Add_UpdateRowDatePicker.Location = new System.Drawing.Point(150, 251);
            this.Add_UpdateRowDatePicker.Name = "Add_UpdateRowDatePicker";
            this.Add_UpdateRowDatePicker.Size = new System.Drawing.Size(175, 26);
            this.Add_UpdateRowDatePicker.TabIndex = 7;
            this.Add_UpdateRowDatePicker.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.Add_UpdateRowDatePicker.Visible = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Enabled = false;
            this.lblEmployeeName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 112);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(130, 19);
            this.lblEmployeeName.TabIndex = 9;
            this.lblEmployeeName.Text = "EmployeeName :";
            // 
            // comEmployeeName
            // 
            this.comEmployeeName.Enabled = false;
            this.comEmployeeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comEmployeeName.FormattingEnabled = true;
            this.comEmployeeName.Location = new System.Drawing.Point(148, 112);
            this.comEmployeeName.Name = "comEmployeeName";
            this.comEmployeeName.Size = new System.Drawing.Size(239, 24);
            this.comEmployeeName.TabIndex = 8;

            // 
            // chAddEmployee
            // 
            this.chAddEmployee.AutoSize = true;
            this.chAddEmployee.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chAddEmployee.ForeColor = System.Drawing.Color.DimGray;
            this.chAddEmployee.Location = new System.Drawing.Point(150, 73);
            this.chAddEmployee.Name = "chAddEmployee";
            this.chAddEmployee.Size = new System.Drawing.Size(120, 22);
            this.chAddEmployee.TabIndex = 10;
            this.chAddEmployee.Text = "Add Employee";
            this.chAddEmployee.UseVisualStyleBackColor = true;
            this.chAddEmployee.CheckedChanged += new System.EventHandler(this.chAddEmployee_CheckedChanged);
            // 
            // frmAdd_UpdateRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 453);
            this.Controls.Add(this.chAddEmployee);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.comEmployeeName);
            this.Controls.Add(this.Add_UpdateRowDatePicker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblFieldName);
            this.Controls.Add(this.comFieldName);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdd_UpdateRows";
            this.Text = "frmAdd_UpdateRows";
            this.Load += new System.EventHandler(this.frmAdd_UpdateRows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox comFieldName;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker Add_UpdateRowDatePicker;
        private System.Windows.Forms.CheckBox chAddEmployee;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.ComboBox comEmployeeName;
    }
}