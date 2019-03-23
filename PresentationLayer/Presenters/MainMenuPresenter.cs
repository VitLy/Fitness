using System;
using System.Windows.Forms;
using DomainLayer.Reposytory;

namespace PresentationLayer
{
    public class MainMenuPresenter:IPresenter
    {
        private readonly IMainForm view;
        readonly IController controller;
        readonly IMessenger messenger;

        public MainMenuPresenter(IMainForm view,IController controller, IMessenger messenger)
        {
            this.view = view;
            this.controller = controller;
            this.messenger = messenger;
            this.controller.SetMainWindow(this.view as Form);
            view.FetchDayTrainigWindow += View_FetchDayTrainigWindow;
            view.FetchBodyParamWindow += View_FetchBodyParamWindow;
            view.FetchExerciseWindow += View_FetchExerciseWindow;
            view.FetchMainParamWindow += View_FetchMainParamWindow;
            view.FetchSchedulerWindow += View_FetchSchedulerWindow;
            view.FetchCategoryWindow += View_FetchCategoryWindow;
            view.FetchTrainingProgramWindow += View_FetchTrainingProgramWindow; 
        }

        private void View_FetchTrainingProgramWindow(object sender, EventArgs e)
        {
            controller.GetInstanse<TrainingProgramPresenter>().Run(view);
        }

        private void View_FetchCategoryWindow(object sender, EventArgs e)
        {
            controller.GetInstanse<CategoryPresenter>().Run(view);
        }

        private void View_FetchBodyParamWindow(object sender, EventArgs e)
        {
            controller.GetInstanse<BodyParamPresenter>().Run(view);
        }

        private void View_FetchSchedulerWindow(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_FetchMainParamWindow(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_FetchExerciseWindow(object sender, EventArgs e)
        {
            controller.GetInstanse<ExercisesPresenter>().Run(view);
        }

        private void View_FetchDayTrainigWindow(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            view.Show();
        }
    }
}
