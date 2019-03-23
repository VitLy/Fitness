namespace UI
{
    partial class AddModifyCategory
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
            this.btnCancelAddOrModifyExercise = new System.Windows.Forms.Button();
            this.btnOkAddOrModifyExercise = new System.Windows.Forms.Button();
            this.txbCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelAddOrModifyExercise
            // 
            this.btnCancelAddOrModifyExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAddOrModifyExercise.Location = new System.Drawing.Point(493, 70);
            this.btnCancelAddOrModifyExercise.Name = "btnCancelAddOrModifyExercise";
            this.btnCancelAddOrModifyExercise.Size = new System.Drawing.Size(82, 42);
            this.btnCancelAddOrModifyExercise.TabIndex = 5;
            this.btnCancelAddOrModifyExercise.Text = "Cancel";
            this.btnCancelAddOrModifyExercise.UseVisualStyleBackColor = true;
            this.btnCancelAddOrModifyExercise.Click += new System.EventHandler(this.BtnCancelAddOrModifyExercise_Click);
            // 
            // btnOkAddOrModifyExercise
            // 
            this.btnOkAddOrModifyExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkAddOrModifyExercise.Location = new System.Drawing.Point(17, 70);
            this.btnOkAddOrModifyExercise.Name = "btnOkAddOrModifyExercise";
            this.btnOkAddOrModifyExercise.Size = new System.Drawing.Size(82, 42);
            this.btnOkAddOrModifyExercise.TabIndex = 4;
            this.btnOkAddOrModifyExercise.Text = "Ок";
            this.btnOkAddOrModifyExercise.UseVisualStyleBackColor = true;
            this.btnOkAddOrModifyExercise.Click += new System.EventHandler(this.BtnOkAddOrModifyExercise_Click);
            // 
            // txbCategory
            // 
            this.txbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCategory.Location = new System.Drawing.Point(107, 10);
            this.txbCategory.MaxLength = 40;
            this.txbCategory.Name = "txbCategory";
            this.txbCategory.Size = new System.Drawing.Size(468, 26);
            this.txbCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 49);
            this.panel1.TabIndex = 3;
            // 
            // AddModifyCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 124);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelAddOrModifyExercise);
            this.Controls.Add(this.btnOkAddOrModifyExercise);
            this.MaximumSize = new System.Drawing.Size(600, 180);
            this.Name = "AddModifyCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddModifyCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelAddOrModifyExercise;
        private System.Windows.Forms.Button btnOkAddOrModifyExercise;
        private System.Windows.Forms.TextBox txbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}