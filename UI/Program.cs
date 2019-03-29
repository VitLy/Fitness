using Initialize;
using PresentationLayer;
using System;
using System.Data.Entity;
using System.Windows.Forms;


namespace UI
{
    static class Program
    {
        /// <summary>
        /// Инициализация базы данных начальными данными
        /// </summary>
        private static void InitalDB()
        {
            Database.SetInitializer(new MyInitializerDB());
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IAdapter adapter = new NinjectAdapter();
            adapter.LoadConfig(new NinjectBindingConfig());
           
            ContainerController controller = new ContainerController(adapter);
            adapter.RegistryInstanceToConst<IController, ContainerController>(controller);

            InitalDB();

            controller.GetInstanse<LoginPresenter>().Run();
        }
    }
}
