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
            if (string.IsNullOrWhiteSpace(this.tbxUser.Text)) { }
            return this.tbxUser.Text;
        }

        public string GetPassword()
        {
            if (string.IsNullOrWhiteSpace(this.tbxPassword.Text)) { }
            return this.tbxPassword.Text;
        }

        public bool GetShowPasswordFlag()
        {
            return this.cbxIsShowPassword.Checked;
        }

        public void SetViewPassword(bool flag)
        {
            this.tbxPassword.UseSystemPasswordChar = flag;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ButtonOkClick?.Invoke(sender, e);
        }

        private void CbxIsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChanged?.Invoke(sender, e);
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            this.tbxUser.Text = "VitLy";
            this.tbxPassword.Text = "19791979";
        }
    }
}
