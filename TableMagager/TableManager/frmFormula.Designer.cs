namespace TableManager
{
    partial class frmFormula
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
            this.comColumnName2 = new System.Windows.Forms.ComboBox();
            this.comColumnName1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.comTypeOfMath = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comDataType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FormulaList = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Time1_From = new System.Windows.Forms.DateTimePicker();
            this.Time2_To = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comColumnName2
            // 
            this.comColumnName2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comColumnName2.FormattingEnabled = true;
            this.comColumnName2.Location = new System.Drawing.Point(481, 125);
            this.comColumnName2.Name = "comColumnName2";
            this.comColumnName2.Size = new System.Drawing.Size(181, 24);
            this.comColumnName2.TabIndex = 0;
            // 
            // comColumnName1
            // 
            this.comColumnName1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comColumnName1.FormattingEnabled = true;
            this.comColumnName1.Location = new System.Drawing.Point(40, 125);
            this.comColumnName1.Name = "comColumnName1";
            this.comColumnName1.Size = new System.Drawing.Size(181, 24);
            this.comColumnName1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ColumnName1 : ";
            // 
            // txtColumnName
            // 
            this.txtColumnName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnName.Location = new System.Drawing.Point(184, 39);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(176, 23);
            this.txtColumnName.TabIndex = 3;
            // 
            // comTypeOfMath
            // 
            this.comTypeOfMath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTypeOfMath.FormattingEnabled = true;
            this.comTypeOfMath.Location = new System.Drawing.Point(279, 125);
            this.comTypeOfMath.Name = "comTypeOfMath";
            this.comTypeOfMath.Size = new System.Drawing.Size(149, 24);
            this.comTypeOfMath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ColumnName2 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "New ColumName : ";
            // 
            // comDataType
            // 
            this.comDataType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDataType.FormattingEnabled = true;
            this.comDataType.Items.AddRange(new object[] {
            "Whole Number",
            "Small Number",
            "Decimal Number",
            "Precise Decimal",
            "Text",
            "Date & Time"});
            this.comDataType.Location = new System.Drawing.Point(481, 40);
            this.comDataType.Name = "comDataType";
            this.comDataType.Size = new System.Drawing.Size(181, 24);
            this.comDataType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "DataType :";
            // 
            // FormulaList
            // 
            this.FormulaList.FormattingEnabled = true;
            this.FormulaList.Location = new System.Drawing.Point(39, 256);
            this.FormulaList.Name = "FormulaList";
            this.FormulaList.Size = new System.Drawing.Size(623, 329);
            this.FormulaList.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(573, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 33);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(466, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Time1_From
            // 
            this.Time1_From.Enabled = false;
            this.Time1_From.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time1_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Time1_From.Location = new System.Drawing.Point(40, 212);
            this.Time1_From.Name = "Time1_From";
            this.Time1_From.Size = new System.Drawing.Size(147, 26);
            this.Time1_From.TabIndex = 13;
            this.Time1_From.Value = new System.DateTime(2026, 1, 1, 3, 11, 0, 0);
            // 
            // Time2_To
            // 
            this.Time2_To.Enabled = false;
            this.Time2_To.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time2_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Time2_To.Location = new System.Drawing.Point(395, 212);
            this.Time2_To.Name = "Time2_To";
            this.Time2_To.Size = new System.Drawing.Size(147, 26);
            this.Time2_To.TabIndex = 14;
            this.Time2_To.Value = new System.DateTime(2026, 1, 1, 3, 9, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "From : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "To :";
            // 
            // frmFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 636);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Time2_To);
            this.Controls.Add(this.Time1_From);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FormulaList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comDataType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comTypeOfMath);
            this.Controls.Add(this.txtColumnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comColumnName1);
            this.Controls.Add(this.comColumnName2);
            this.Name = "frmFormula";
            this.Text = "frmFormula";
            this.Load += new System.EventHandler(this.frmFormula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comColumnName2;
        private System.Windows.Forms.ComboBox comColumnName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.ComboBox comTypeOfMath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comDataType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox FormulaList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker Time1_From;
        private System.Windows.Forms.DateTimePicker Time2_To;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}