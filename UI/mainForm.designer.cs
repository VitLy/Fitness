namespace UI
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StartTrainigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentBodyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExercisesStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BodyParamStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainUsersParamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExercisesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScedulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тренировочныеПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииТренировокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.статистикаToolStripMenuItem,
            this.настройкаToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartTrainigToolStripMenuItem,
            this.CurrentBodyDataToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 29);
            this.toolStripMenuItem1.Text = "Активность";
            // 
            // StartTrainigToolStripMenuItem
            // 
            this.StartTrainigToolStripMenuItem.Name = "StartTrainigToolStripMenuItem";
            this.StartTrainigToolStripMenuItem.Size = new System.Drawing.Size(332, 30);
            this.StartTrainigToolStripMenuItem.Text = "Начать тренировку";
            this.StartTrainigToolStripMenuItem.Click += new System.EventHandler(this.StartTrainigToolStripMenuItem_DoubleClick);
            // 
            // CurrentBodyDataToolStripMenuItem
            // 
            this.CurrentBodyDataToolStripMenuItem.Name = "CurrentBodyDataToolStripMenuItem";
            this.CurrentBodyDataToolStripMenuItem.Size = new System.Drawing.Size(332, 30);
            this.CurrentBodyDataToolStripMenuItem.Text = "Текущие физические данные";
            this.CurrentBodyDataToolStripMenuItem.Click += new System.EventHandler(this.CurrentBodyDataToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExercisesStatToolStripMenuItem,
            this.BodyParamStatToolStripMenuItem});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // ExercisesStatToolStripMenuItem
            // 
            this.ExercisesStatToolStripMenuItem.Name = "ExercisesStatToolStripMenuItem";
            this.ExercisesStatToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.ExercisesStatToolStripMenuItem.Text = "Упражнения";
            // 
            // BodyParamStatToolStripMenuItem
            // 
            this.BodyParamStatToolStripMenuItem.Name = "BodyParamStatToolStripMenuItem";
            this.BodyParamStatToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.BodyParamStatToolStripMenuItem.Text = "Физические параметры";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainUsersParamToolStripMenuItem,
            this.ExercisesToolStripMenuItem1,
            this.ScedulerToolStripMenuItem,
            this.тренировочныеПрограммыToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // MainUsersParamToolStripMenuItem
            // 
            this.MainUsersParamToolStripMenuItem.Name = "MainUsersParamToolStripMenuItem";
            this.MainUsersParamToolStripMenuItem.Size = new System.Drawing.Size(394, 30);
            this.MainUsersParamToolStripMenuItem.Text = "Основные параметры пользователя";
            this.MainUsersParamToolStripMenuItem.Click += new System.EventHandler(this.MainUsersParamToolStripMenuItem_Click);
            // 
            // ExercisesToolStripMenuItem1
            // 
            this.ExercisesToolStripMenuItem1.Name = "ExercisesToolStripMenuItem1";
            this.ExercisesToolStripMenuItem1.Size = new System.Drawing.Size(394, 30);
            this.ExercisesToolStripMenuItem1.Text = "Упражнения";
            this.ExercisesToolStripMenuItem1.Click += new System.EventHandler(this.Exercises_Click);
            // 
            // ScedulerToolStripMenuItem
            // 
            this.ScedulerToolStripMenuItem.Name = "ScedulerToolStripMenuItem";
            this.ScedulerToolStripMenuItem.Size = new System.Drawing.Size(394, 30);
            this.ScedulerToolStripMenuItem.Text = "Расписание занятий";
            this.ScedulerToolStripMenuItem.Click += new System.EventHandler(this.ScedulerToolStripMenuItem_Click);
            // 
            // тренировочныеПрограммыToolStripMenuItem
            // 
            this.тренировочныеПрограммыToolStripMenuItem.Name = "тренировочныеПрограммыToolStripMenuItem";
            this.тренировочныеПрограммыToolStripMenuItem.Size = new System.Drawing.Size(394, 30);
            this.тренировочныеПрограммыToolStripMenuItem.Text = "Тренировочные программы";
            this.тренировочныеПрограммыToolStripMenuItem.Click += new System.EventHandler(this.TrainigProgramToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииТренировокToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // категорииТренировокToolStripMenuItem
            // 
            this.категорииТренировокToolStripMenuItem.Name = "категорииТренировокToolStripMenuItem";
            this.категорииТренировокToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.категорииТренировокToolStripMenuItem.Text = "Категории тренировок";
            this.категорииТренировокToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PerfectBuild running";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem StartTrainigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CurrentBodyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExercisesStatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BodyParamStatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainUsersParamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExercisesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ScedulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тренировочныеПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииТренировокToolStripMenuItem;
    }
}