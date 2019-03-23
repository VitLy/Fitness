using System;
using System.Collections;

namespace PresentationLayer
{
    public interface IExercises : IView
    {
        event EventHandler ExercisesFormIsActivated;
        //event EventHandler DoubleMouseClick;
        event EventHandler AddNewExercise;
        event EventHandler ModifyExercise;
        event EventHandler DeleteExercise;

        void FillExercisesGrid(IList list);
        void Show(IView view);
        void Update();

        object GetCurrentRow();
        void GridUpdate();
        void SetEndGridCursorPosition();

        int CurrentGridCursorPosition
        {
            get;set;
        }
    }
}
