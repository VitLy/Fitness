using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class BodyParam : Form, IBodyParam
    {
        public BodyParam()
        {
            InitializeComponent();
        }

        public event EventHandler ActivatedBodyForm;
        public event EventHandler ButtonOkClick;
        public event EventHandler ButtonCancelClick;
        public event EventHandler DateChanged;
        public event EventHandler LoadLastParametersChanged;
        public event EventHandler LoadDefaultParametersChanged;
        public event EventHandler LoadDateParametersChanged;

        public void FillGrid(IList<decimal> bodyParam)
        {
            if (bodyParam == null)
            {
                throw new ArgumentNullException();
            }
            nudWeight.Value = bodyParam[0];
            nudBreast.Value = bodyParam[1];
            nudWaist.Value = bodyParam[2];
            nudButtock.Value = bodyParam[3];
            nudThigh.Value = bodyParam[4];
        }

        public void SetMDIParent(IView view)
        {
            MdiParent = view as Form;
        }

        private void BodyParam_Activated(object sender, EventArgs e)
        {
            this.Text = "Add parameters for " + DateTime.Today;
            ActivatedBodyForm?.Invoke(sender, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ButtonCancelClick?.Invoke(sender, e);
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateChanged?.Invoke(sender, e);
        }

        private void SetEnableAddButton()
        {
            btnOk.Enabled = IsAnyOneCheckBoxChecked();
        }

        private void CbxWeight_CheckedChanged(object sender, EventArgs e)
        {
            nudWeight.Enabled = cbxWeight.Checked;
            SetEnableAddButton();
        }

        private void CbxBreast_CheckedChanged(object sender, EventArgs e)
        {
            nudBreast.Enabled = cbxBreast.Checked;
            SetEnableAddButton();
        }

        private void CbxWaist_CheckedChanged(object sender, EventArgs e)
        {
            nudWaist.Enabled = cbxWaist.Checked;
            SetEnableAddButton();
        }

        private void CbxButtock_CheckedChanged(object sender, EventArgs e)
        {
            nudButtock.Enabled = cbxButtock.Checked;
            SetEnableAddButton();
        }

        private void CbxThigh_CheckedChanged(object sender, EventArgs e)
        {
            nudThigh.Enabled = cbxThigh.Checked;
            SetEnableAddButton();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ButtonOkClick?.Invoke(sender, e);
        }

        public float GetWeight()
        {
            if (cbxWeight.Checked == true)
                return (float)nudWeight.Value;
            else return 0;
        }

        public int GetBreast()
        {
            if (cbxBreast.Checked == true)
                return (int)nudBreast.Value;
            else return 0;
        }

        public int GetWaist()
        {
            if (cbxWaist.Checked == true)
                return (int)nudWaist.Value;
            else return 0;
        }

        public int GetButtock()
        {
            if (cbxButtock.Checked == true)
                return (int)nudButtock.Value;
            else return 0;
        }

        public int GetThigh()
        {
            if (cbxThigh.Checked == true)
                return (int)nudThigh.Value;
                        else return 0;
        }

        public DateTime GetDate()
        {
            return dtpDate.Value;
        }

        public void SetCurrentDate()
        {
            dtpDate.Value = DateTime.Today;
        }

        private void RbtDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = rbtDate.Checked;
            LoadDateParametersChanged?.Invoke(sender, e);
        }

        private void RbtLoadParameters_CheckedChanged(object sender, EventArgs e)
        {
            LoadLastParametersChanged?.Invoke(sender, e);
        }

        private void RbtDefault_CheckedChanged(object sender, EventArgs e)
        {
            LoadDefaultParametersChanged?.Invoke(sender, e);
        }

        public bool IsAnyOneCheckBoxChecked()
        {
            return (cbxWeight.Checked | cbxBreast.Checked | cbxWaist.Checked | cbxButtock.Checked | cbxThigh.Checked);
        }
    }
}
