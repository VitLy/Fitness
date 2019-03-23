using PresentationLayer;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class AddModifyCategory : Form,IAddModifyCategory
    {
        public AddModifyCategory()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonOk;
        public event EventHandler ButtonCancel;

        public void ClearFields()
        {
            txbCategory.Text = "";
        }

        public string GetName()
        {
            return txbCategory.Text;
        }

        public bool IsCorrectInputData()
        {
            return txbCategory.Text != String.Empty;
        }

        public void SetFormName(string formName)
        {
            this.Text = formName;
        }

        public void SetName(string name)
        {
            txbCategory.Text = name;
        }

        void IAddModifyCategory.ShowDialog()
        {
            this.ShowDialog();
        }

        private void BtnOkAddOrModifyExercise_Click(object sender, EventArgs e)
        {
            ButtonOk?.Invoke(sender, e);
        }

        private void BtnCancelAddOrModifyExercise_Click(object sender, EventArgs e)
        {
            ButtonCancel?.Invoke(sender, e);
        }

        public void SetMaxLengthNameCategory(int maxlength)
        {
            txbCategory.MaxLength = maxlength;
        }
    }
}
