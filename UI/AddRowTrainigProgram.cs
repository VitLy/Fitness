using DomainLayer.Model;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class AddRowTrainigProgram : Form, IAddTrainigProgramSpecRow
    {
        public AddRowTrainigProgram()
        {
            InitializeComponent();
        }

        public event EventHandler Ok;
        public event EventHandler Cancel;

        void IAddTrainigProgramSpecRow.ShowDialog()
        {
            this.ShowDialog();
        }

        #region SetDataForm
        public void SetExercise(List<string> exercises)
        {
            cmbExercises.DataSource = exercises;
        }

        public void SetDefaultExercise(string exercises)
        {
            cmbExercises.Text = exercises;
        }

        public void SetFormText(string formText)
        {
            Text = formText;
        }

        public void SetDefaultExercise(int exercises)
        {
            throw new NotImplementedException();
        }

        public void SetSetNum(string set)
        {
            txbSetNum.Text = set;
        }

        public void SetWeight(string weight)
        {
            txbWeight.Text = weight;
        }

        public void SetAmount(string amount)
        {
            txbAmount.Text = amount;
        }

        public void SetExercise(List<Exercise> exercises)
        {
            cmbExercises.DataSource = exercises;
        }

        public void SetDataGrDisplayMember(string parametr)
        {
            cmbExercises.DisplayMember = parametr;
        }

        public void SetDataGrValueMember(string parametr)
        {
            cmbExercises.ValueMember = parametr;
        }

        #endregion SetDataForm

        #region GetDataForm

        public string GetFormText()
        {
            return Text;
        }

        public string GetExercise()
        {
            return cmbExercises.Text;
        }

        public int GetExerciseId()
        {
            int exerciseId = (int)cmbExercises.SelectedValue;

            while (exerciseId == 0)
            {
                throw new ArgumentNullException("Exercise is incorrect");
            }
            return exerciseId;
        }

        public int GetSetNum()
        {
            var flag = Int32.TryParse(txbSetNum.Text, out int set);
            if (flag == false)
            {
                throw new ArgumentNullException("Set num should not be null");
            }
            else
                return set;
        }

        public float GetWeight()
        {
            var flag = float.TryParse(txbWeight.Text, out float weight);
            return weight;
        }

        public byte GetAmount()
        {
            var flag = byte.TryParse(txbAmount.Text, out byte amounnt);
            while (flag == false)
            {
                throw new ArgumentNullException("Amount should not be null");
            }
            return amounnt;
        }

        #endregion

        public void ClearFields()
        {
            this.cmbExercises.Text = String.Empty;
            this.txbSetNum.Text = String.Empty;
            this.txbWeight.Text = String.Empty;
            this.txbAmount.Text = String.Empty;
        }

        private bool CheckedInputDataRow()
        {
            try
            {
                GetSetNum();
                GetAmount();
                GetWeight();
                GetExerciseId();
                return true;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (CheckedInputDataRow() != true) return;
            Ok?.Invoke(sender, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(sender, e);
        }


    }
}
