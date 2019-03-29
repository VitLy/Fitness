using System.Windows.Forms;

namespace ServiceLayer.Commmon
{
    public interface IController
    {
        TInterface GetInstanseWithInterface<TInterface>();
        TInstance GetInstanse<TInstance>();
        void SetMainWindow(Form mainMenuPresenter);

        ApplicationContext GetContext();//test

    }
}
