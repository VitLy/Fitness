using DomainLayer.Model;
using PresentationLayer;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DomainLayer.DocumentViewModel;

namespace UI
{
    public partial class AddModifyTrainigProgram : Form, IAddModifyTrainigProgram
    {
        #region fields and events

        public AddModifyTrainigProgram()
        {
            InitializeComponent();
        }

        public string FormName { get => this.Text; set => this.Text = value; }

        public event EventHandler FormLoaded;
        public event EventHandler NameFieldChanged;
        public event EventHandler AddNewRowButtonClick;
        public event EventHandler ModifyRowButtonClick;
        public event EventHandler DeleteRowButtonClick;
        public event EventHandler OkButtonClick;
        public event EventHandler CancelButtonClick;

        #endregion

        #region GetParameters


        public string GetFormText()
        {
            return Text;
        }

        public DateTime GetDate()
        {
            return dtpDate.Value;
        }

        public string GetCategory()
        {
            return this.cmbCategory.Text;
        }

        public string GetName()
        {
            return txbName.Text;
        }

        public string GetDescription()
        {
            return txbDescription.Text;
        }

        public string[] GetCurrentRow()
        {
            try
            {
                var x = dgvTraingSpec.CurrentRow.Cells;
                string exercise = x[0].FormattedValue.ToString();
                string set = x[1].FormattedValue.ToString();
                string weight = x[2].FormattedValue.ToString();
                string amount = x[3].FormattedValue.ToString();

                return new string[] { exercise, set, weight, amount };
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        public DataTable GetAllRows()
        {
            DataTable dataGridTable = new DataTable();
            foreach (DataGridViewColumn currentDataGridColumn in dgvTraingSpec.Columns)
            {
                dataGridTable.Columns.Add(currentDataGridColumn.Name);
            }

            foreach (DataGridViewRow currentDataGridRow in dgvTraingSpec.Rows)
            {
                DataRow row = dataGridTable.NewRow();
                foreach (DataGridViewCell currentDataGridCell in currentDataGridRow.Cells)
                {
                    row[currentDataGridCell.ColumnIndex] = currentDataGridCell.Value;
                }
                dataGridTable.Rows.Add(row);
            }
            return dataGridTable;
        }

        public int GetCurrentRowIndex()
        {
            return dgvTraingSpec.CurrentCell.RowIndex;
        }

        #endregion

        #region SetParameters

        public void SetButtonOkEnabled(bool buttonOkStatus)
        {
            btnOk.Enabled = buttonOkStatus;
        }

        public void SetCategory(string category)
        {
            cmbCategory.Text = category;
        }

        public void SetListCategory(List<Category> listCategory)
        {
            cmbCategory.DataSource = listCategory;
        }

        public void SetDataGrDisplayMember(string parametr)
        {
            cmbCategory.DisplayMember = parametr;
        }

        public void SetDataGrValueMember(string parametr)
        {
            cmbCategory.ValueMember = parametr;
        }

        public void SetDate(DateTime date)
        {
            dtpDate.Value = date;
        }

        public void SetDescription(string description)
        {
            txbDescription.Text = description;
        }

        public void SetName(string name)
        {
            txbName.Text = name;
        }

        public void SetAllRow(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                dgvTraingSpec.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
            }
        }

        #endregion

        #region EventHandlers

        private void AddModifyTrainigProgram_Load(object sender, EventArgs e)
        {
            this.FormLoaded?.Invoke(sender, e);
        }

        private void TxbName_TextChanged(object sender, EventArgs e)
        {
            NameFieldChanged?.Invoke(sender, e);
        }

        private void BtnAddNewRow_Click(object sender, EventArgs e)
        {
            AddNewRowButtonClick?.Invoke(sender, e);
        }

        private void BtnDModifyCurrentRow_Click(object sender, EventArgs e)
        {
            ModifyRowButtonClick?.Invoke(sender, e);
        }

        private void DgvTraingSpec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyRowButtonClick?.Invoke(sender, e);
        }

        private void BtnDeleteCurrentRow_Click(object sender, EventArgs e)
        {
            DeleteRowButtonClick?.Invoke(sender, e);
        }

        public void DeleteCurrentRow()
        {
            try
            {
                var index = dgvTraingSpec.CurrentCell.RowIndex;
                dgvTraingSpec.Rows.RemoveAt(index);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            OkButtonClick?.Invoke(sender, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelButtonClick?.Invoke(sender, e);
        }

        #endregion

        void IAddModifyTrainigProgram.ShowDialog()
        {
            this.ShowDialog();
        }

        public void AddRow(string[] rows)
        {
            dgvTraingSpec.Rows.Add(rows);
        }

        public void ModifyCurrentRow(string[] row)
        {
            var index = dgvTraingSpec.CurrentCell.RowIndex;
            dgvTraingSpec[0, index].Value = row[0];
            dgvTraingSpec[1, index].Value = row[1];
            dgvTraingSpec[2, index].Value = row[2];
            dgvTraingSpec[3, index].Value = row[3];
        }
        public void Clear()
        {
            txbName.Text = string.Empty;
            txbDescription.Text = string.Empty;
            while (dgvTraingSpec.Rows.Count != 0)
                dgvTraingSpec.Rows.RemoveAt(0);
        }

        private void AddModifyTrainigProgram_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Clear();
            this.Hide();
        }

        public void SetAllRow(IEnumerable<TrainigProgramSpecView> table)
        {
            if (table != null)
            {
                foreach (var item in table)
                {
                    dgvTraingSpec.Rows.Add( item.Exercise, item.Set, item.Weight, item.Amount );
                }
            }

        }
    }
}
