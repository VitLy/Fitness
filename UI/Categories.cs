using PresentationLayer;
using System;
using System.Collections;
using System.Windows.Forms;

namespace UI
{
    public partial class Categories : Form, ICategory
    {
        public Categories()
        {
            InitializeComponent();
        }

        public event EventHandler CategoryFormIsActivated;
        public event EventHandler AddNewCategory;
        public event EventHandler ModifyCategory;
        public event EventHandler DeleteCategory;

        public void FillCategoryGrid(IList list)
        {
            dgvCategory.DataSource = list;
        }

        public object GetCurrentRow()
        {
            if (dgvCategory.RowCount > 0)
            {
                return dgvCategory.CurrentRow.DataBoundItem;
            }
            else return null;
        }

        public void GridUpdate()
        {
            dgvCategory.Refresh();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            AddNewCategory?.Invoke(sender,e);
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            ModifyCategory?.Invoke(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteCategory?.Invoke(sender, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Show(IView view)
        {
            this.MdiParent = view as MainForm;
            this.Show();
        }

        private void Categories_Activated(object sender, EventArgs e)
        {
            CategoryFormIsActivated?.Invoke(sender, e);
        }

        public void SetEndGridCursorPosition()
        {
            dgvCategory.CurrentCell = dgvCategory[0,dgvCategory.RowCount - 1];
        }
    }
}
