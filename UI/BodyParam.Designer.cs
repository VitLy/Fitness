namespace UI
{
    partial class BodyParam
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxThigh = new System.Windows.Forms.CheckBox();
            this.cbxWaist = new System.Windows.Forms.CheckBox();
            this.cbxButtock = new System.Windows.Forms.CheckBox();
            this.cbxBreast = new System.Windows.Forms.CheckBox();
            this.cbxWeight = new System.Windows.Forms.CheckBox();
            this.nudBreast = new System.Windows.Forms.NumericUpDown();
            this.nudThigh = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.nudButtock = new System.Windows.Forms.NumericUpDown();
            this.nudWaist = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtDate = new System.Windows.Forms.RadioButton();
            this.rbtLoadParameters = new System.Windows.Forms.RadioButton();
            this.rbtDefault = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudButtock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(10, 350);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 42);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Add";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(211, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 42);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxThigh);
            this.groupBox1.Controls.Add(this.cbxWaist);
            this.groupBox1.Controls.Add(this.cbxButtock);
            this.groupBox1.Controls.Add(this.cbxBreast);
            this.groupBox1.Controls.Add(this.cbxWeight);
            this.groupBox1.Controls.Add(this.nudBreast);
            this.groupBox1.Controls.Add(this.nudThigh);
            this.groupBox1.Controls.Add(this.nudWeight);
            this.groupBox1.Controls.Add(this.nudButtock);
            this.groupBox1.Controls.Add(this.nudWaist);
            this.groupBox1.Location = new System.Drawing.Point(10, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(230, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(230, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(230, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label2.Location = new System.Drawing.Point(230, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "cm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "kg";
            // 
            // cbxThigh
            // 
            this.cbxThigh.AutoSize = true;
            this.cbxThigh.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThigh.Location = new System.Drawing.Point(10, 270);
            this.cbxThigh.Name = "cbxThigh";
            this.cbxThigh.Size = new System.Drawing.Size(95, 29);
            this.cbxThigh.TabIndex = 11;
            this.cbxThigh.Text = "Thigh";
            this.cbxThigh.UseVisualStyleBackColor = true;
            this.cbxThigh.CheckedChanged += new System.EventHandler(this.CbxThigh_CheckedChanged);
            // 
            // cbxWaist
            // 
            this.cbxWaist.AutoSize = true;
            this.cbxWaist.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWaist.Location = new System.Drawing.Point(10, 120);
            this.cbxWaist.Name = "cbxWaist";
            this.cbxWaist.Size = new System.Drawing.Size(94, 29);
            this.cbxWaist.TabIndex = 7;
            this.cbxWaist.Text = "Waist";
            this.cbxWaist.UseVisualStyleBackColor = true;
            this.cbxWaist.CheckedChanged += new System.EventHandler(this.CbxWaist_CheckedChanged);
            // 
            // cbxButtock
            // 
            this.cbxButtock.AutoSize = true;
            this.cbxButtock.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxButtock.Location = new System.Drawing.Point(10, 168);
            this.cbxButtock.Name = "cbxButtock";
            this.cbxButtock.Size = new System.Drawing.Size(114, 29);
            this.cbxButtock.TabIndex = 9;
            this.cbxButtock.Text = "Buttock";
            this.cbxButtock.UseVisualStyleBackColor = true;
            this.cbxButtock.CheckedChanged += new System.EventHandler(this.CbxButtock_CheckedChanged);
            // 
            // cbxBreast
            // 
            this.cbxBreast.AutoSize = true;
            this.cbxBreast.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBreast.Location = new System.Drawing.Point(10, 70);
            this.cbxBreast.Name = "cbxBreast";
            this.cbxBreast.Size = new System.Drawing.Size(99, 29);
            this.cbxBreast.TabIndex = 5;
            this.cbxBreast.Text = "Breast";
            this.cbxBreast.UseVisualStyleBackColor = true;
            this.cbxBreast.CheckedChanged += new System.EventHandler(this.CbxBreast_CheckedChanged);
            // 
            // cbxWeight
            // 
            this.cbxWeight.AutoSize = true;
            this.cbxWeight.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWeight.Location = new System.Drawing.Point(10, 20);
            this.cbxWeight.Name = "cbxWeight";
            this.cbxWeight.Size = new System.Drawing.Size(109, 29);
            this.cbxWeight.TabIndex = 3;
            this.cbxWeight.Text = "Weight";
            this.cbxWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxWeight.UseVisualStyleBackColor = true;
            this.cbxWeight.CheckedChanged += new System.EventHandler(this.CbxWeight_CheckedChanged);
            // 
            // nudBreast
            // 
            this.nudBreast.Enabled = false;
            this.nudBreast.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBreast.Location = new System.Drawing.Point(140, 70);
            this.nudBreast.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudBreast.Name = "nudBreast";
            this.nudBreast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudBreast.Size = new System.Drawing.Size(86, 35);
            this.nudBreast.TabIndex = 6;
            // 
            // nudThigh
            // 
            this.nudThigh.Enabled = false;
            this.nudThigh.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThigh.Location = new System.Drawing.Point(135, 270);
            this.nudThigh.Name = "nudThigh";
            this.nudThigh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudThigh.Size = new System.Drawing.Size(88, 35);
            this.nudThigh.TabIndex = 12;
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 1;
            this.nudWeight.Enabled = false;
            this.nudWeight.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudWeight.Location = new System.Drawing.Point(140, 20);
            this.nudWeight.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudWeight.Size = new System.Drawing.Size(86, 35);
            this.nudWeight.TabIndex = 4;
            this.nudWeight.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // nudButtock
            // 
            this.nudButtock.Enabled = false;
            this.nudButtock.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudButtock.Location = new System.Drawing.Point(140, 170);
            this.nudButtock.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudButtock.Name = "nudButtock";
            this.nudButtock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudButtock.Size = new System.Drawing.Size(86, 35);
            this.nudButtock.TabIndex = 10;
            // 
            // nudWaist
            // 
            this.nudWaist.Enabled = false;
            this.nudWaist.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWaist.Location = new System.Drawing.Point(140, 120);
            this.nudWaist.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudWaist.Name = "nudWaist";
            this.nudWaist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudWaist.Size = new System.Drawing.Size(86, 35);
            this.nudWaist.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(140, 20);
            this.dtpDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(135, 33);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtDate);
            this.groupBox2.Controls.Add(this.rbtLoadParameters);
            this.groupBox2.Controls.Add(this.rbtDefault);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Location = new System.Drawing.Point(10, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 102);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // rbtDate
            // 
            this.rbtDate.AutoSize = true;
            this.rbtDate.Location = new System.Drawing.Point(10, 20);
            this.rbtDate.Name = "rbtDate";
            this.rbtDate.Size = new System.Drawing.Size(69, 24);
            this.rbtDate.TabIndex = 5;
            this.rbtDate.Text = "Date";
            this.rbtDate.UseVisualStyleBackColor = true;
            this.rbtDate.CheckedChanged += new System.EventHandler(this.RbtDate_CheckedChanged);
            // 
            // rbtLoadParameters
            // 
            this.rbtLoadParameters.AutoSize = true;
            this.rbtLoadParameters.Location = new System.Drawing.Point(10, 60);
            this.rbtLoadParameters.Name = "rbtLoadParameters";
            this.rbtLoadParameters.Size = new System.Drawing.Size(135, 24);
            this.rbtLoadParameters.TabIndex = 4;
            this.rbtLoadParameters.Text = "Load last data";
            this.rbtLoadParameters.UseVisualStyleBackColor = true;
            this.rbtLoadParameters.CheckedChanged += new System.EventHandler(this.RbtLoadParameters_CheckedChanged);
            // 
            // rbtDefault
            // 
            this.rbtDefault.AutoSize = true;
            this.rbtDefault.Location = new System.Drawing.Point(185, 60);
            this.rbtDefault.Name = "rbtDefault";
            this.rbtDefault.Size = new System.Drawing.Size(86, 24);
            this.rbtDefault.TabIndex = 3;
            this.rbtDefault.Text = "Default";
            this.rbtDefault.UseVisualStyleBackColor = true;
            this.rbtDefault.CheckedChanged += new System.EventHandler(this.RbtDefault_CheckedChanged);
            // 
            // BodyParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(325, 455);
            this.MinimumSize = new System.Drawing.Size(325, 455);
            this.Name = "BodyParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CurrentParam";
            this.Activated += new System.EventHandler(this.BodyParam_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudButtock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxThigh;
        private System.Windows.Forms.CheckBox cbxWaist;
        private System.Windows.Forms.CheckBox cbxButtock;
        private System.Windows.Forms.CheckBox cbxBreast;
        private System.Windows.Forms.CheckBox cbxWeight;
        private System.Windows.Forms.NumericUpDown nudThigh;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudButtock;
        private System.Windows.Forms.NumericUpDown nudWaist;
        private System.Windows.Forms.NumericUpDown nudBreast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtDate;
        private System.Windows.Forms.RadioButton rbtLoadParameters;
        private System.Windows.Forms.RadioButton rbtDefault;
    }
}