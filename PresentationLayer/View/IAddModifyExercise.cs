using System;

namespace PresentationLayer
{
    public interface IAddModifyExercise : IView
    {
        event EventHandler ButtonOk;
        event EventHandler ButtonCancel;

        void ShowDialog();
        void Hide();
        void ClearFields();

        string GetName();
        string GetDescription();
        void SetName(string name);
        void SetDescription(string description);


        bool IsCorrectInputData();
        void SetFormName(string formName);
    }
}
