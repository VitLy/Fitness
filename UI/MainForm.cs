using System;
using System.Windows.Forms;
using PresentationLayer;

namespace UI
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler FetchDayTrainigWindow;
        public event EventHandler FetchExerciseWindow;
        public event EventHandler FetchMainParamWindow;
        public event EventHandler FetchBodyParamWindow;
        public event EventHandler FetchSchedulerWindow;
        public event EventHandler FetchCategoryWindow;
        public event EventHandler FetchTrainingProgramWindow;

        private void StartTrainigToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            FetchDayTrainigWindow?.Invoke(sender, e);
        }

        private void Exercises_Click(object sender, EventArgs e)
        {
            FetchExerciseWindow?.Invoke(sender, e);
        }

        private void CurrentBodyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FetchBodyParamWindow?.Invoke(sender, e);
        }

        private void MainUsersParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FetchMainParamWindow?.Invoke(sender, e);
        }

        private void ScedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FetchSchedulerWindow?.Invoke(sender, e);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FetchCategoryWindow?.Invoke(sender, e);
        }

        private void TrainigProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FetchTrainingProgramWindow?.Invoke(sender, e);
        }
    }
}
