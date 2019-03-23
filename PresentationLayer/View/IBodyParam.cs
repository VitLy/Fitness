using System;
using System.Collections.Generic;

namespace PresentationLayer
{
    public interface IBodyParam : IView
    {
        event EventHandler ActivatedBodyForm;
        event EventHandler ButtonOkClick;
        event EventHandler ButtonCancelClick;
        event EventHandler DateChanged;
        event EventHandler LoadDateParametersChanged;
        event EventHandler LoadLastParametersChanged;
        event EventHandler LoadDefaultParametersChanged;


        float GetWeight();
        int GetBreast();
        int GetWaist();
        int GetButtock();
        int GetThigh();
        DateTime GetDate();

        void Show();
        void FillGrid(IList<decimal> bodyParam);
        void SetCurrentDate();
        bool IsAnyOneCheckBoxChecked();
    }
}
