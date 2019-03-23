using PresentationLayer;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class TrainigPrograms : Form, ITrainigProgram
    {
        public TrainigPrograms()
        {
            InitializeComponent();
        }

        public event EventHandler TrainigProgramIsActivated;
        public event EventHandler MouseDgvHeadClick;
        public event EventHandler AddTrainigProgram;
        public event EventHandler ModifyTrainigProgram;
        public event EventHandler DeleteTrainigProgram;

        public void FillTrainingProgramHeadGrid(IEnumerable trainingProgramHead)
        {
           dgvTrainigProgramHead.DataSource = trainingProgramHead;               
        }

        public void FillTrainingProgramSpecGrid(IEnumerable trainingProgramSpec)
        {
             dgvTrainigProgramSpec.DataSource = trainingProgramSpec;       
        }

        public void Show(IView view)
        {
            MdiParent = view as MainForm;
            this.Show();
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void TrainigPrograms_Activated(object sender, EventArgs e)
        {
            TrainigProgramIsActivated?.Invoke(sender, e);
        }

        private void TrainigPrograms_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            this.AddTrainigProgram?.Invoke(sender, e);
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            this.ModifyTrainigProgram?.Invoke(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteTrainigProgram?.Invoke(sender, e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public object GetCurrentRow()
        {
            if (dgvTrainigProgramHead.RowCount > 0)
            {
                return dgvTrainigProgramHead.CurrentRow.DataBoundItem;
            }
            else return null;
        }

        private void DgvTrainigProgramHead_MouseClick(object sender, MouseEventArgs e)
        {
            MouseDgvHeadClick?.Invoke(sender, e);
        }
    }
}
