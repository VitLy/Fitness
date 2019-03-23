using System.Windows.Forms;
using DomainLayer.Reposytory;

namespace ServiceLayer.Reposytory
{
    public class WFUserMessenger : IMessenger
    {
        public void ShowMessageError(string headline, string message)
        {
            MessageBox.Show(message, headline, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowMessageSucсess(string headline, string message)
        {
            MessageBox.Show(message, headline, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public void ShowMessageWarning(string headline, string message)
        {
            MessageBox.Show(message, headline, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
