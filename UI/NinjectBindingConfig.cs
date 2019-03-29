using DomainLayer.Model;
using DomainLayer.Reposytory;
using Ninject.Modules;
using PresentationLayer;
using ServiceLayer.Reposytory;

namespace UI
{
    public class NinjectBindingConfig : NinjectModule,IDIContainer
    {
        public override void Load()
        {
            this.Bind<ILogin, Login>();
            this.Bind<IMainForm, MainForm>();
            this.Bind<IBodyParam, BodyParam>();
            this.Bind<IExercises, Exercises>();
            this.Bind<ICategory, Categories>();
            this.Bind<IAddModifyExercise, AddModifyExercise>();
            this.Bind<IAddModifyCategory, AddModifyCategory>();
            this.Bind<ITrainigProgram, TrainigPrograms>();
            this.Bind<IAddModifyTrainigProgram, AddModifyTrainigProgram>();
            this.Bind<ITrainingProgramHeadReposytory<TrainingProgramHead>, TrainigProgramHeadRepo>();
            this.Bind<IAddTrainigProgramSpecRow, AddRowTrainigProgram>();

            this.Bind<IMessenger, WFUserMessenger>();

            this.Bind<BaseRepo<User>, UserRepo>();
            this.Bind<IUserReposytory<User>, UserRepo>();
            this.Bind<IBodyReposytory<Param>, BodyRepo>();
            this.Bind<IExerciseReposytory<Exercise>, ExercisesRepo>();
            this.Bind<ITrainigSpecReposytory<TrainingSpec>, TrainigSpecRepo>();
            this.Bind<ICategoryReposytory<Category>, CategoryRepo>();
            this.Bind<ISetReposytory<Set>, SetRepo>();

            this.Bind<LoginPresenter>().ToSelf();
            this.Bind<MainMenuPresenter>().ToSelf();
            this.Bind<BodyParamPresenter>().ToSelf();
            this.Bind<ExercisesPresenter>().ToSelf();
            this.Bind<CategoryPresenter>().ToSelf();
            this.Bind<TrainingProgramPresenter>().ToSelf();
        }
    }
}
