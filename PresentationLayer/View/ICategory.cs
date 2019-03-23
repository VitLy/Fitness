using System;
using System.Collections;

namespace PresentationLayer
{
    public interface ICategory : IView
    {
        event EventHandler CategoryFormIsActivated;
        event EventHandler AddNewCategory;
        event EventHandler ModifyCategory;
        event EventHandler DeleteCategory;

        void Show(IView view);

        object GetCurrentRow();
        void FillCategoryGrid(IList list);

        void GridUpdate();
        void SetEndGridCursorPosition();
    }
}
