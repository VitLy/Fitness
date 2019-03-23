using PresentationLayer;
using System;
using System.Windows.Forms;
using ServiceLayer.Reposytory;
using DomainLayer.Reposytory;
using DomainLayer.Model;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IAdapter adapter = new NinjectAdapter();
            adapter.Registry<ILogin, Login>();
            adapter.Registry<IMainForm, MainForm>();
            adapter.Registry<IBodyParam, BodyParam>();
            adapter.Registry<IExercises, Exercises>();
            adapter.Registry<ICategory, Categories>();
            adapter.Registry<IAddModifyExercise, AddModifyExercise>();
            adapter.Registry<IAddModifyCategory, AddModifyCategory>();
            adapter.Registry<ITrainigProgram, TrainigPrograms>();
            adapter.Registry<IAddModifyTrainigProgram, AddModifyTrainigProgram>();
            adapter.Registry<ITrainingProgramHeadReposytory<TrainingProgramHead>, TrainigProgramHeadRepo>();
            adapter.Registry<IAddTrainigProgramSpecRow, AddRowTrainigProgram>();

            adapter.Registry<IMessenger, WFUserMessenger>();

            adapter.Registry<BaseRepo<User>, UserRepo>();
            adapter.Registry<IUserReposytory<User>, UserRepo>();
            adapter.Registry<IBodyReposytory<Param>, BodyRepo>();
            adapter.Registry<IExerciseReposytory<Exercise>, ExercisesRepo>();
            adapter.Registry<ITrainigSpecReposytory<TrainingSpec>, TrainigSpecRepo>();
            adapter.Registry<ICategoryReposytory<Category>, CategoryRepo>();
            adapter.Registry<ISetReposytory<Set>, SetRepo>();

            adapter.RegistryInstance<LoginPresenter>();
            adapter.RegistryInstance<MainMenuPresenter>();
            adapter.RegistryInstance<BodyParamPresenter>();
            adapter.RegistryInstance<ExercisesPresenter>();
            adapter.RegistryInstance<CategoryPresenter>();
            adapter.RegistryInstance<TrainingProgramPresenter>();
          //  adapter.RegistryInstance<AddModifyTrainigProgramPresenter>();

            ContainerController controller = new ContainerController(adapter);
            adapter.RegistryInstanceToConst<IController, ContainerController>(controller);

            controller.GetInstanse<LoginPresenter>().Run();
        }
    }
}
