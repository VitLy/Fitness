using System.Windows.Forms;

namespace PresentationLayer
{
    public class ContainerController : IController
    {
        readonly IAdapter adapter;
        readonly ApplicationContext context = new ApplicationContext();

        public ContainerController(IAdapter adaper)
        {
            this.adapter = adaper;
        }

        public TInstance GetInstanse<TInstance>()
        {
            return adapter.GetInstanse<TInstance>();
        }

        public TInterface GetInstanseWithInterface<TInterface>()
        {
            return adapter.GetInstanseWithInterface<TInterface>();
        }

        public void SetMainWindow(Form contextForm)
        {
            context.MainForm = contextForm;
        }

        public Form GetMainWindow()
        {
            return context.MainForm;
        }

        public ApplicationContext GetContext()
        {
            return this.context;
        }

    }
}
