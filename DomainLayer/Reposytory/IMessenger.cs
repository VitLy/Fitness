using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Reposytory
{
    public interface IMessenger
    {
        void ShowMessageWarning(string headline, string message);
        void ShowMessageError(string headline, string message);
        void ShowMessageSucсess(string headline, string message);
    }
}
