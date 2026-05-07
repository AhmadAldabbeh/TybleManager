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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.DateForm1 = new System.Windows.Forms.DateTimePicker();
            this.DateTo1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comEmployeeName = new System.Windows.Forms.ComboBox();
            this.DateSpecific = new System.Windows.Forms.DateTimePicker();
            this.lblSpecificDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chAuto_Yearly = new System.Windows.Forms.CheckBox();
            this.chMonthly = new System.Windows.Forms.CheckBox();
            this.chAuto_Monthly = new System.Windows.Forms.CheckBox();
            this.chAuto_Weekly = new System.Windows.Forms.CheckBox();
            this.DGWFormula = new System.Windows.Forms.DataGridView();
            this.gbDAteInfo = new System.Windows.Forms.GroupBox();
            this.chkTo = new System.Windows.Forms.CheckBox();
            this.chkFrom = new System.Windows.Forms.CheckBox();
            this.chkSpecificDate = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chWithDateInfo = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMoreForDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWFormula)).BeginInit();
            this.gbDAteInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comColumnName2
            // 
            this.comColumnName2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comColumnName2.FormattingEnabled = true;
            this.comColumnName2.Location = new System.Drawing.Point(134, 103);
            this.comColumnName2.Name = "comColumnName2";
            this.comColumnName2.Size = new System.Drawing.Size(181, 24);
            this.comColumnName2.TabIndex = 0;
            // 
            // comColumnName1
            // 
            this.comColumnName1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comColumnName1.FormattingEnabled = true;
            this.comColumnName1.Location = new System.Drawing.Point(134, 18);
            this.comColumnName1.Name = "comColumnName1";
            this.comColumnName1.Size = new System.Drawing.Size(181, 24);
            this.comColumnName1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ColumnName1 : ";
            // 
            // txtColumnName
            // 
            this.txtColumnName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnName.Location = new System.Drawing.Point(146, 26);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(176, 23);
            this.txtColumnName.TabIndex = 3;
            // 
            // comTypeOfMath
            // 
            this.comTypeOfMath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTypeOfMath.FormattingEnabled = true;
            this.comTypeOfMath.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "SUM",
            "AVG",
            "MIN",
            "MAX",
            "ROUND"});
            this.comTypeOfMath.Location = new System.Drawing.Point(134, 58);
            this.comTypeOfMath.Name = "comTypeOfMath";
            this.comTypeOfMath.Size = new System.Drawing.Size(181, 24);
            this.comTypeOfMath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ColumnName2 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 26);
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
            this.comDataType.Location = new System.Drawing.Point(797, 26);
            this.comDataType.Name = "comDataType";
            this.comDataType.Size = new System.Drawing.Size(181, 24);
            this.comDataType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "DataType :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(924, 785);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 33);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(826, 786);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DateForm1
            // 
            this.DateForm1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateForm1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateForm1.Location = new System.Drawing.Point(66, 172);
            this.DateForm1.Name = "DateForm1";
            this.DateForm1.Size = new System.Drawing.Size(147, 26);
            this.DateForm1.TabIndex = 13;
            this.DateForm1.Value = new System.DateTime(2026, 1, 1, 3, 11, 0, 0);
            // 
            // DateTo1
            // 
            this.DateTo1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTo1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo1.Location = new System.Drawing.Point(362, 171);
            this.DateTo1.Name = "DateTo1";
            this.DateTo1.Size = new System.Drawing.Size(147, 26);
            this.DateTo1.TabIndex = 14;
            this.DateTo1.Value = new System.DateTime(2026, 1, 1, 3, 9, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "From : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "To :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(666, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "EmployeeName : ";
            // 
            // comEmployeeName
            // 
            this.comEmployeeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comEmployeeName.FormattingEnabled = true;
            this.comEmployeeName.Location = new System.Drawing.Point(797, 19);
            this.comEmployeeName.Name = "comEmployeeName";
            this.comEmployeeName.Size = new System.Drawing.Size(181, 24);
            this.comEmployeeName.TabIndex = 17;
            // 
            // DateSpecific
            // 
            this.DateSpecific.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSpecific.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateSpecific.Location = new System.Drawing.Point(362, 103);
            this.DateSpecific.Name = "DateSpecific";
            this.DateSpecific.Size = new System.Drawing.Size(147, 26);
            this.DateSpecific.TabIndex = 32;
            // 
            // lblSpecificDate
            // 
            this.lblSpecificDate.AutoSize = true;
            this.lblSpecificDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecificDate.Location = new System.Drawing.Point(241, 103);
            this.lblSpecificDate.Name = "lblSpecificDate";
            this.lblSpecificDate.Size = new System.Drawing.Size(110, 19);
            this.lblSpecificDate.TabIndex = 31;
            this.lblSpecificDate.Text = "Specific Date :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.chAuto_Yearly);
            this.groupBox1.Controls.Add(this.chMonthly);
            this.groupBox1.Controls.Add(this.chAuto_Monthly);
            this.groupBox1.Controls.Add(this.chAuto_Weekly);
            this.groupBox1.Location = new System.Drawing.Point(7, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 129);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // chAuto_Yearly
            // 
            this.chAuto_Yearly.AutoSize = true;
            this.chAuto_Yearly.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chAuto_Yearly.Location = new System.Drawing.Point(6, 96);
            this.chAuto_Yearly.Name = "chAuto_Yearly";
            this.chAuto_Yearly.Size = new System.Drawing.Size(115, 23);
            this.chAuto_Yearly.TabIndex = 36;
            this.chAuto_Yearly.Text = "Auto_Yearly";
            this.chAuto_Yearly.UseVisualStyleBackColor = true;
            // 
            // chMonthly
            // 
            this.chMonthly.AutoSize = true;
            this.chMonthly.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMonthly.Location = new System.Drawing.Point(6, 9);
            this.chMonthly.Name = "chMonthly";
            this.chMonthly.Size = new System.Drawing.Size(84, 23);
            this.chMonthly.TabIndex = 33;
            this.chMonthly.Text = "Monthly";
            this.chMonthly.UseVisualStyleBackColor = true;
            // 
            // chAuto_Monthly
            // 
            this.chAuto_Monthly.AutoSize = true;
            this.chAuto_Monthly.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chAuto_Monthly.Location = new System.Drawing.Point(6, 38);
            this.chAuto_Monthly.Name = "chAuto_Monthly";
            this.chAuto_Monthly.Size = new System.Drawing.Size(127, 23);
            this.chAuto_Monthly.TabIndex = 35;
            this.chAuto_Monthly.Text = "Auto_Monthly";
            this.chAuto_Monthly.UseVisualStyleBackColor = true;
            // 
            // chAuto_Weekly
            // 
            this.chAuto_Weekly.AutoSize = true;
            this.chAuto_Weekly.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chAuto_Weekly.Location = new System.Drawing.Point(6, 67);
            this.chAuto_Weekly.Name = "chAuto_Weekly";
            this.chAuto_Weekly.Size = new System.Drawing.Size(121, 23);
            this.chAuto_Weekly.TabIndex = 34;
            this.chAuto_Weekly.Text = "Auto_Weekly";
            this.chAuto_Weekly.UseVisualStyleBackColor = true;
            // 
            // DGWFormula
            // 
            this.DGWFormula.AllowUserToAddRows = false;
            this.DGWFormula.BackgroundColor = System.Drawing.Color.White;
            this.DGWFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWFormula.Location = new System.Drawing.Point(39, 506);
            this.DGWFormula.Name = "DGWFormula";
            this.DGWFormula.Size = new System.Drawing.Size(975, 273);
            this.DGWFormula.TabIndex = 37;
            // 
            // gbDAteInfo
            // 
            this.gbDAteInfo.Controls.Add(this.chkTo);
            this.gbDAteInfo.Controls.Add(this.chkFrom);
            this.gbDAteInfo.Controls.Add(this.chkSpecificDate);
            this.gbDAteInfo.Controls.Add(this.groupBox1);
            this.gbDAteInfo.Controls.Add(this.DateForm1);
            this.gbDAteInfo.Controls.Add(this.label6);
            this.gbDAteInfo.Controls.Add(this.lblSpecificDate);
            this.gbDAteInfo.Controls.Add(this.DateSpecific);
            this.gbDAteInfo.Controls.Add(this.label7);
            this.gbDAteInfo.Controls.Add(this.DateTo1);
            this.gbDAteInfo.Enabled = false;
            this.gbDAteInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDAteInfo.Location = new System.Drawing.Point(40, 272);
            this.gbDAteInfo.Name = "gbDAteInfo";
            this.gbDAteInfo.Size = new System.Drawing.Size(579, 217);
            this.gbDAteInfo.TabIndex = 38;
            this.gbDAteInfo.TabStop = false;
            this.gbDAteInfo.Text = "Dateinfo";
            // 
            // chkTo
            // 
            this.chkTo.AutoSize = true;
            this.chkTo.Location = new System.Drawing.Point(515, 178);
            this.chkTo.Name = "chkTo";
            this.chkTo.Size = new System.Drawing.Size(15, 14);
            this.chkTo.TabIndex = 39;
            this.chkTo.UseVisualStyleBackColor = true;
            // 
            // chkFrom
            // 
            this.chkFrom.AutoSize = true;
            this.chkFrom.Location = new System.Drawing.Point(219, 179);
            this.chkFrom.Name = "chkFrom";
            this.chkFrom.Size = new System.Drawing.Size(15, 14);
            this.chkFrom.TabIndex = 38;
            this.chkFrom.UseVisualStyleBackColor = true;
            // 
            // chkSpecificDate
            // 
            this.chkSpecificDate.AutoSize = true;
            this.chkSpecificDate.Location = new System.Drawing.Point(515, 108);
            this.chkSpecificDate.Name = "chkSpecificDate";
            this.chkSpecificDate.Size = new System.Drawing.Size(15, 14);
            this.chkSpecificDate.TabIndex = 37;
            this.chkSpecificDate.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtColumnName);
            this.groupBox3.Controls.Add(this.comDataType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 66);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comColumnName2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comTypeOfMath);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.comEmployeeName);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comColumnName1);
            this.groupBox4.Location = new System.Drawing.Point(5, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1009, 149);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            // 
            // chWithDateInfo
            // 
            this.chWithDateInfo.AutoSize = true;
            this.chWithDateInfo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWithDateInfo.Location = new System.Drawing.Point(40, 242);
            this.chWithDateInfo.Name = "chWithDateInfo";
            this.chWithDateInfo.Size = new System.Drawing.Size(136, 22);
            this.chWithDateInfo.TabIndex = 41;
            this.chWithDateInfo.Text = "With Date Info ?";
            this.chWithDateInfo.UseVisualStyleBackColor = true;
            this.chWithDateInfo.CheckedChanged += new System.EventHandler(this.chWithDateInfo_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(39, 786);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 33);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMoreForDelete
            // 
            this.btnMoreForDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreForDelete.Location = new System.Drawing.Point(151, 786);
            this.btnMoreForDelete.Name = "btnMoreForDelete";
            this.btnMoreForDelete.Size = new System.Drawing.Size(143, 33);
            this.btnMoreForDelete.TabIndex = 43;
            this.btnMoreForDelete.Text = "More for Delete";
            this.btnMoreForDelete.UseVisualStyleBackColor = true;
            this.btnMoreForDelete.Click += new System.EventHandler(this.btnMoreForDelete_Click);
            // 
            // frmFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 828);
            this.Controls.Add(this.btnMoreForDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chWithDateInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDAteInfo);
            this.Controls.Add(this.DGWFormula);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmFormula";
            this.Text = "frmFormula";
            this.Load += new System.EventHandler(this.frmFormula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWFormula)).EndInit();
            this.gbDAteInfo.ResumeLayout(false);
            this.gbDAteInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker DateForm1;
        private System.Windows.Forms.DateTimePicker DateTo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comEmployeeName;
        private System.Windows.Forms.DateTimePicker DateSpecific;
        private System.Windows.Forms.Label lblSpecificDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGWFormula;
        private System.Windows.Forms.GroupBox gbDAteInfo;
        private System.Windows.Forms.CheckBox chAuto_Yearly;
        private System.Windows.Forms.CheckBox chMonthly;
        private System.Windows.Forms.CheckBox chAuto_Monthly;
        private System.Windows.Forms.CheckBox chAuto_Weekly;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chWithDateInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkSpecificDate;
        private System.Windows.Forms.CheckBox chkTo;
        private System.Windows.Forms.CheckBox chkFrom;
        private System.Windows.Forms.Button btnMoreForDelete;
    }
}