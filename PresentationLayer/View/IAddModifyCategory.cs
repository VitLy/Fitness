using System;

namespace PresentationLayer
{
    public interface IAddModifyCategory:IView
    {
        event EventHandler ButtonOk;
        event EventHandler ButtonCancel;

        void ShowDialog();
        void Hide();
        void ClearFields();

        string GetName();
        void SetName(string name);
        void SetMaxLengthNameCategory(int maxlength);

        bool IsCorrectInputData();
        void SetFormName(string formName);
    }
}
