namespace UI
{
    partial class AddModifyExercise
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbExercise = new System.Windows.Forms.TextBox();
            this.btnOkAddOrModifyExercise = new System.Windows.Forms.Button();
            this.btnCancelAddOrModifyExercise = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbDescription);
            this.panel1.Controls.Add(this.txbExercise);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 216);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exercise";
            // 
            // txbDescription
            // 
            this.txbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescription.Location = new System.Drawing.Point(107, 42);
            this.txbDescription.MaxLength = 250;
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(468, 171);
            this.txbDescription.TabIndex = 1;
            // 
            // txbExercise
            // 
            this.txbExercise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbExercise.Location = new System.Drawing.Point(107, 10);
            this.txbExercise.MaxLength = 40;
            this.txbExercise.Name = "txbExercise";
            this.txbExercise.Size = new System.Drawing.Size(468, 26);
            this.txbExercise.TabIndex = 0;
            // 
            // btnOkAddOrModifyExercise
            // 
            this.btnOkAddOrModifyExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkAddOrModifyExercise.Location = new System.Drawing.Point(17, 235);
            this.btnOkAddOrModifyExercise.Name = "btnOkAddOrModifyExercise";
            this.btnOkAddOrModifyExercise.Size = new System.Drawing.Size(82, 42);
            this.btnOkAddOrModifyExercise.TabIndex = 1;
            this.btnOkAddOrModifyExercise.Text = "Ок";
            this.btnOkAddOrModifyExercise.UseVisualStyleBackColor = true;
            this.btnOkAddOrModifyExercise.Click += new System.EventHandler(this.BtnOkAddOrModifyExercise_Click);
            // 
            // btnCancelAddOrModifyExercise
            // 
            this.btnCancelAddOrModifyExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAddOrModifyExercise.Location = new System.Drawing.Point(493, 235);
            this.btnCancelAddOrModifyExercise.Name = "btnCancelAddOrModifyExercise";
            this.btnCancelAddOrModifyExercise.Size = new System.Drawing.Size(82, 42);
            this.btnCancelAddOrModifyExercise.TabIndex = 2;
            this.btnCancelAddOrModifyExercise.Text = "Cancel";
            this.btnCancelAddOrModifyExercise.UseVisualStyleBackColor = true;
            this.btnCancelAddOrModifyExercise.Click += new System.EventHandler(this.BtnCancelAddOrModifyExercise_Click);
            // 
            // AddModifyExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 294);
            this.Controls.Add(this.btnCancelAddOrModifyExercise);
            this.Controls.Add(this.btnOkAddOrModifyExercise);
            this.Controls.Add(this.panel1);
            this.Name = "AddModifyExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbExercise;
        private System.Windows.Forms.Button btnOkAddOrModifyExercise;
        private System.Windows.Forms.Button btnCancelAddOrModifyExercise;
    }
}