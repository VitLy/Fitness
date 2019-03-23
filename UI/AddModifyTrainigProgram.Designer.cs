namespace UI
{
    partial class AddModifyTrainigProgram
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lebel1 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteCurrentRow = new System.Windows.Forms.Button();
            this.btnModifyCurrentRow = new System.Windows.Forms.Button();
            this.btnAddNewRow = new System.Windows.Forms.Button();
            this.dgvTraingSpec = new System.Windows.Forms.DataGridView();
            this.Exercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraingSpec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lebel1);
            this.panel1.Controls.Add(this.txbDescription);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 170);
            this.panel1.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(97, 20);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(125, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(313, 18);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(350, 24);
            this.cmbCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // lebel1
            // 
            this.lebel1.AutoSize = true;
            this.lebel1.Location = new System.Drawing.Point(17, 24);
            this.lebel1.Name = "lebel1";
            this.lebel1.Size = new System.Drawing.Size(38, 17);
            this.lebel1.TabIndex = 2;
            this.lebel1.Text = "Date";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(97, 70);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescription.MaxLength = 250;
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(566, 91);
            this.txbDescription.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(97, 45);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(566, 22);
            this.txbName.TabIndex = 0;
            this.txbName.TextChanged += new System.EventHandler(this.TxbName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 519);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteCurrentRow);
            this.panel3.Controls.Add(this.btnModifyCurrentRow);
            this.panel3.Controls.Add(this.btnAddNewRow);
            this.panel3.Controls.Add(this.dgvTraingSpec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 529);
            this.panel3.TabIndex = 0;
            // 
            // btnDeleteCurrentRow
            // 
            this.btnDeleteCurrentRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCurrentRow.Location = new System.Drawing.Point(532, 26);
            this.btnDeleteCurrentRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCurrentRow.Name = "btnDeleteCurrentRow";
            this.btnDeleteCurrentRow.Size = new System.Drawing.Size(131, 30);
            this.btnDeleteCurrentRow.TabIndex = 1;
            this.btnDeleteCurrentRow.Text = "Delete Current";
            this.btnDeleteCurrentRow.UseVisualStyleBackColor = true;
            this.btnDeleteCurrentRow.Click += new System.EventHandler(this.BtnDeleteCurrentRow_Click);
            // 
            // btnModifyCurrentRow
            // 
            this.btnModifyCurrentRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModifyCurrentRow.Location = new System.Drawing.Point(396, 26);
            this.btnModifyCurrentRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyCurrentRow.Name = "btnModifyCurrentRow";
            this.btnModifyCurrentRow.Size = new System.Drawing.Size(131, 30);
            this.btnModifyCurrentRow.TabIndex = 1;
            this.btnModifyCurrentRow.Text = "Modify Current";
            this.btnModifyCurrentRow.UseVisualStyleBackColor = true;
            this.btnModifyCurrentRow.Click += new System.EventHandler(this.BtnDModifyCurrentRow_Click);
            // 
            // btnAddNewRow
            // 
            this.btnAddNewRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewRow.Location = new System.Drawing.Point(260, 26);
            this.btnAddNewRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewRow.Name = "btnAddNewRow";
            this.btnAddNewRow.Size = new System.Drawing.Size(131, 30);
            this.btnAddNewRow.TabIndex = 1;
            this.btnAddNewRow.Text = "Add New Row";
            this.btnAddNewRow.UseVisualStyleBackColor = true;
            this.btnAddNewRow.Click += new System.EventHandler(this.BtnAddNewRow_Click);
            // 
            // dgvTraingSpec
            // 
            this.dgvTraingSpec.AllowUserToAddRows = false;
            this.dgvTraingSpec.AllowUserToDeleteRows = false;
            this.dgvTraingSpec.AllowUserToResizeRows = false;
            this.dgvTraingSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraingSpec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exercise,
            this.SetNum,
            this.Weight,
            this.Amount});
            this.dgvTraingSpec.Location = new System.Drawing.Point(5, 64);
            this.dgvTraingSpec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTraingSpec.Name = "dgvTraingSpec";
            this.dgvTraingSpec.RowTemplate.Height = 28;
            this.dgvTraingSpec.Size = new System.Drawing.Size(657, 463);
            this.dgvTraingSpec.TabIndex = 0;
            this.dgvTraingSpec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTraingSpec_CellDoubleClick);
            // 
            // Exercise
            // 
            this.Exercise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exercise.HeaderText = "Exercise";
            this.Exercise.Name = "Exercise";
            this.Exercise.ReadOnly = true;
            // 
            // SetNum
            // 
            this.SetNum.HeaderText = "№Set";
            this.SetNum.Name = "SetNum";
            this.SetNum.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(342, 704);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(320, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Location = new System.Drawing.Point(5, 704);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(320, 32);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // AddModifyTrainigProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 753);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(695, 800);
            this.MinimumSize = new System.Drawing.Size(695, 800);
            this.Name = "AddModifyTrainigProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddModifyTrainigProgram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddModifyTrainigProgram_FormClosed);
            this.Load += new System.EventHandler(this.AddModifyTrainigProgram_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraingSpec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lebel1;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTraingSpec;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnDeleteCurrentRow;
        private System.Windows.Forms.Button btnModifyCurrentRow;
        private System.Windows.Forms.Button btnAddNewRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}