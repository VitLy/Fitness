using PresentationLayer;
using System;
using System.Collections;
using System.Windows.Forms;

namespace UI
{
    public partial class Exercises : Form, IExercises
    {
        public int CurrentGridCursorPosition
        {
            get
            {
                return dgvExercises.CurrentRow.Index;
            }

            set
            {
                if (value<=dgvExercises.RowCount&value>=0)
                dgvExercises.CurrentCell = dgvExercises[0, value];
            }
        }

        public Exercises()
        {
            InitializeComponent();
        }

        public event EventHandler AddNewExercise;
        public event EventHandler ModifyExercise;
        //public event EventHandler DoubleMouseClick;

        public event EventHandler ExercisesFormIsActivated;
        public event EventHandler DeleteExercise;

        public void FillExercisesGrid(IList list)
        {
            dgvExercises.DataSource = list;
        }

        private void Exercises_Activated(object sender, EventArgs e)
        {
            ExercisesFormIsActivated?.Invoke(sender, e);
        }

        public void Show(IView view)
        {
            this.MdiParent = view as MainForm;
            this.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            AddNewExercise?.Invoke(sender, e);
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            ModifyExercise?.Invoke(sender, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public object GetCurrentRow()
        {
            if (dgvExercises.RowCount > 0)
            {
                return dgvExercises.CurrentRow.DataBoundItem;
            }
            else return null;
        }

        public void GridUpdate()
        {
            dgvExercises.Update();
        }

        private void DgvExercises_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DoubleMouseClick?.Invoke(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteExercise?.Invoke(sender, e);
        }

        public void SetEndGridCursorPosition()
        {
            if (dgvExercises.RowCount > 0)
            {
                dgvExercises.CurrentCell = dgvExercises[0, dgvExercises.RowCount - 1];
            }
        }
    }
}
