using System.Windows.Forms;

namespace PresentationLayer
{
    public interface IController
    {
        TInterface GetInstanseWithInterface<TInterface>();
        TInstance GetInstanse<TInstance>();
        void SetMainWindow(Form mainMenuPresenter);

        ApplicationContext GetContext();//test

    }
}
