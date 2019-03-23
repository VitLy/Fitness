using PresentationLayer;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class AddModifyExercise : Form, IAddModifyExercise
    {
        public AddModifyExercise()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonOk;
        public event EventHandler ButtonCancel;

        public string GetDescription()
        {
            return txbDescription.Text;
        }

        public string GetName()
        {
            return txbExercise.Text;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ButtonCancel?.Invoke(sender,e);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.ButtonOk?.Invoke(sender, e);
        }

        void IAddModifyExercise.ShowDialog()
        {
           this.ShowDialog();
        }

        void IAddModifyExercise.ClearFields()
        {
            txbExercise.Text = "";
            txbDescription.Text = "";
        }

        public bool IsCorrectInputData()
        {
            return txbExercise.Text != String.Empty;
        }

        public void SetFormName(string formName)
        {
            this.Text = formName;
        }

        public void SetName(string name)
        {
            txbExercise.Text = name;
        }

        public void SetDescription(string description)
        {
            txbDescription.Text = description;
        }

        private void BtnOkAddOrModifyExercise_Click(object sender, EventArgs e)
        {
            ButtonOk?.Invoke(sender, e);
        }

        private void BtnCancelAddOrModifyExercise_Click(object sender, EventArgs e)
        {
            ButtonCancel?.Invoke(sender, e);
        }
    }
}
