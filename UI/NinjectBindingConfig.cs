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
            this.Bind<ILogin>().To<Login>();

            this.Bind<IMainForm>().To<MainForm>();
            this.Bind<IBodyParam>().To<BodyParam>();
            this.Bind<IExercises>().To<Exercises>();
            this.Bind<ICategory>().To<Categories>();
            this.Bind<IAddModifyExercise>().To<AddModifyExercise>();
            this.Bind<IAddModifyCategory>().To<AddModifyCategory>();
            this.Bind<ITrainigProgram>().To<TrainigPrograms>();
            this.Bind<IAddModifyTrainigProgram>().To<AddModifyTrainigProgram>();
            this.Bind<ITrainingProgramHeadReposytory<TrainingProgramHead>>().To<TrainigProgramHeadRepo>();
            this.Bind<IAddTrainigProgramSpecRow>().To<AddRowTrainigProgram>();

            this.Bind<IMessenger>().To<WFUserMessenger>();

            this.Bind<BaseRepo<User>>().To<UserRepo>();
            this.Bind<IUserReposytory<User>>().To<UserRepo>();
            this.Bind<IBodyReposytory<Param>>().To<BodyRepo>();
            this.Bind<IExerciseReposytory<Exercise>>().To<ExercisesRepo>();
            this.Bind<ITrainigSpecReposytory<TrainingSpec>>().To<TrainigSpecRepo>();
            this.Bind<ICategoryReposytory<Category>>().To<CategoryRepo>();
            this.Bind<ISetReposytory<Set>>().To<SetRepo>();

            this.Bind<LoginPresenter>().ToSelf();
            this.Bind<MainMenuPresenter>().ToSelf();
            this.Bind<BodyParamPresenter>().ToSelf();
            this.Bind<ExercisesPresenter>().ToSelf();
            this.Bind<CategoryPresenter>().ToSelf();
            this.Bind<TrainingProgramPresenter>().ToSelf();
        }
    }
}
