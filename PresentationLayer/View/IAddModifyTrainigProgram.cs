using DomainLayer.DocumentViewModel;
using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace PresentationLayer
{
    public interface IAddModifyTrainigProgram : IView
    {
        event EventHandler FormLoaded;
        event EventHandler NameFieldChanged;
        event EventHandler AddNewRowButtonClick;
        event EventHandler ModifyRowButtonClick;
        event EventHandler DeleteRowButtonClick;
        event EventHandler OkButtonClick;
        event EventHandler CancelButtonClick;

        void ShowDialog();
        void Hide();

        string FormName { get; set; }

        void SetListCategory(List<Category> listCategory);
        void SetDate(DateTime date);
        void SetCategory(string category);
        void SetName(string name);
        void SetDescription(string description);
        void SetAllRow(IEnumerable<TrainigProgramSpecView> table);
 
        DateTime GetDate();
        string GetCategory();
        string GetName();
        string GetDescription();


        string[] GetCurrentRow();
        void AddRow(string[] row);
        void ModifyCurrentRow(string[] row);
        void DeleteCurrentRow();
        void Clear();
        DataTable GetAllRows();

        void SetDataGrDisplayMember(string parametrName);
        void SetDataGrValueMember(string parametrName);
        int GetCurrentRowIndex();
        void SetButtonOkEnabled(bool buttonStatus);
    }
}
