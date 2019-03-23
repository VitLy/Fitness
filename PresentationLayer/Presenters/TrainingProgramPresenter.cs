using DomainLayer.Model;
using DomainLayer.Reposytory;
using System;

namespace PresentationLayer
{
    public class TrainingProgramPresenter : IPresenter
    {
        readonly ITrainigProgram view;
        readonly IMessenger messenger;
        readonly IController controller;
        readonly ITrainingProgramHeadReposytory<TrainingProgramHead> reposytory;

        public TrainingProgramPresenter(ITrainigProgram view, IMessenger messenger,
                                        ITrainingProgramHeadReposytory<TrainingProgramHead> reposytory, IController controller)
        {
            this.view = view;
            this.messenger = messenger;
            this.reposytory = reposytory;
            this.controller = controller;
            view.TrainigProgramIsActivated += View_TrainigProgramIsActivated;
            view.MouseDgvHeadClick += View_MouseDgvHeadClick;
            view.AddTrainigProgram += View_AddNewTrainigProgram;
            view.ModifyTrainigProgram += View_ModifyTrainigProgram;
            view.DeleteTrainigProgram += View_DeleteTrainigProgram;
        }

        private void View_AddNewTrainigProgram(object sender, EventArgs e)
        {
            controller.GetInstanse<AddModifyTrainigProgramPresenter>().Run();
        }

        private void View_ModifyTrainigProgram(object sender, EventArgs e)
        {
            int currentTrainigHead = (view.GetCurrentRow() as TrainingProgramHead).Id;
            AddModifyTrainigProgramPresenter presenter = new AddModifyTrainigProgramPresenter(
                controller.GetInstanseWithInterface<IAddModifyTrainigProgram>(), controller.GetInstanseWithInterface<IExerciseReposytory<Exercise>>(),
                controller.GetInstanseWithInterface<ICategoryReposytory<Category>>(), controller.GetInstanseWithInterface<ISetReposytory<Set>>(),
                controller.GetInstanseWithInterface<ITrainingProgramHeadReposytory<TrainingProgramHead>>(),
                controller.GetInstanseWithInterface<IAddTrainigProgramSpecRow>(), controller.GetInstanseWithInterface<IMessenger>(), currentTrainigHead);

            presenter.Run();
        }

        private void View_DeleteTrainigProgram(object sender, EventArgs e)
        {
            reposytory.Delete(view.GetCurrentRow() as TrainingProgramHead);
            View_TrainigProgramIsActivated(sender, e);
        }

        private void View_AddNewExercise(object sender, EventArgs e)
        {
            view.GetCurrentRow();
        }

        private void View_MouseDgvHeadClick(object sender, EventArgs e)
        {
            TrainingProgramHead curr = view.GetCurrentRow() as TrainingProgramHead;
            view.FillTrainingProgramSpecGrid(reposytory.GetBindedData(curr.Id));
        }

        private void View_TrainigProgramIsActivated(object sender, EventArgs e)
        {
            view.FillTrainingProgramHeadGrid(reposytory.GetAll());

            if (!(view.GetCurrentRow() is TrainingProgramHead current)) return;

            view.FillTrainingProgramSpecGrid(reposytory.GetBindedData(current.Id));
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Run(IView view)
        {
            this.view.Show(view);
        }
    }
}
