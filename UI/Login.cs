using PresentationLayer;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form, ILogin
    {
        public Login()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonOkClick;
        public event EventHandler CheckboxChanged;

        public string GetLogin()
        {
            if (string.IsNullOrWhiteSpace(tbxUser.Text)) { }
            return tbxUser.Text;
        }

        public string GetPassword()
        {
            if (string.IsNullOrWhiteSpace(tbxPassword.Text)) { }
            return tbxPassword.Text;
        }

        public bool GetShowPasswordFlag()
        {
            return cbxIsShowPassword.Checked;
        }

        public void SetViewPassword(bool flag)
        {
            tbxPassword.UseSystemPasswordChar = flag;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ButtonOkClick?.Invoke(sender, e);
        }

        private void CbxIsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChanged?.Invoke(sender, e);
        }
       
        /// <summary>
        /// Временный метод, для автоматического заполнения имени и пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Activated(object sender, EventArgs e)
        {
            tbxUser.Text = "VitLy";
            tbxPassword.Text = "19791979";
        }
    }
}
