using DomainLayer.Model;
using DomainLayer.Reposytory;
using System;
using System.Collections.Generic;

namespace PresentationLayer
{
    public class ExercisesPresenter : IPresenter
    {
        readonly IExercises view;
        IAddModifyExercise viewDialog;
        Exercise currentExercise;
        readonly IMessenger messenger;
        readonly IController controller;
        readonly IExerciseReposytory<Exercise> exerciseReposytory;
        readonly ITrainigSpecReposytory<TrainingSpec> trainigSpecReposytory;

        public ExercisesPresenter(IController controller, IExercises view, IAddModifyExercise addModDialog, IMessenger messenger,
                     IExerciseReposytory<Exercise> exerciseReposytory, ITrainigSpecReposytory<TrainingSpec> trainigSpecReposytory)
        {
            this.controller = controller;
            this.view = view;
            this.messenger = messenger;
            this.exerciseReposytory = exerciseReposytory;
            this.trainigSpecReposytory = trainigSpecReposytory;

            view.ExercisesFormIsActivated += View_ExercisesFormIsActivated;
            view.AddNewExercise += View_AddNewExercise;
            view.DeleteExercise += View_DeleteExercise;
            view.ModifyExercise += View_ModifyExercise;
            //view.DoubleMouseClick += View_ModifyExercise;
            viewDialog = controller.GetInstanseWithInterface<IAddModifyExercise>();
            viewDialog.ClearFields();
            viewDialog.ButtonOk += ViewDialog_ButtonOk;
            viewDialog.ButtonCancel += ViewDialog_ButtonCancel;
        }

        private void View_AddNewExercise(object sender, EventArgs e)
        {
            viewDialog.ClearFields();
            viewDialog.SetFormName("Add new exercise");
            currentExercise = new Exercise { };
            viewDialog.ShowDialog();
            view.SetEndGridCursorPosition();
            FillGrid();
            //view.SetEndGridCursorPosition();
        }

        private void View_ModifyExercise(object sender, EventArgs e)
        {
            var positionModifyingRow = view.CurrentGridCursorPosition;
            viewDialog.SetFormName("Modify existed exercise");
            currentExercise = (view.GetCurrentRow() as Exercise);
            if (currentExercise != null)
            {
                var exercise = exerciseReposytory.GetOne(currentExercise.Id);
                viewDialog.SetName(exercise.Name);
                viewDialog.SetDescription(exercise.Description);
                viewDialog.ShowDialog();
                FillGrid();
                view.CurrentGridCursorPosition = positionModifyingRow;
            }
        }

        private void View_DeleteExercise(object sender, EventArgs e)
        {
            if (view.GetCurrentRow() is Exercise exercise)
            {
                exerciseReposytory.Delete(exercise);
                FillGrid();
                view.SetEndGridCursorPosition();
            }
        }

        private void ViewDialog_ButtonCancel(object sender, EventArgs e)
        {
            viewDialog.ClearFields();
            viewDialog.Hide();
        }

        private void ViewDialog_ButtonOk(object sender, EventArgs e)
        {
            Exercise modifyedExercise;
            string modifyedName = viewDialog.GetName();
            string modifyedDescription = viewDialog.GetDescription();

            switch (currentExercise.Id != 0)
            {
                case true:
                    {
                        if (modifyedName != currentExercise.Name | modifyedDescription != currentExercise.Description)
                        {
                            modifyedExercise = new Exercise { Id = currentExercise.Id, Name = modifyedName, Description = modifyedDescription };
                            exerciseReposytory.Modify(modifyedExercise);
                        }
                    };
                    break;
                case false:
                    {
                        modifyedExercise = new Exercise { Name = modifyedName, Description = modifyedDescription };
                        exerciseReposytory.Add(modifyedExercise);
                        break;
                    }
            }
            viewDialog.Hide();
        }

        void FillGrid()
        {
            view.FillExercisesGrid(exerciseReposytory.GetAllExercises() as List<Exercise>);
        }

        private void View_ExercisesFormIsActivated(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void Run(IView view)
        {
            this.view.Show(view);
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
