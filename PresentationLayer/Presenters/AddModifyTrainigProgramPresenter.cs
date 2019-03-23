using DomainLayer.Model;
using DomainLayer.Reposytory;
using System;
using System.Collections.Generic;
using System.Data;

namespace PresentationLayer
{
    #region fields and constructor 

    public class AddModifyTrainigProgramPresenter : IPresenter
    {
        readonly IAddModifyTrainigProgram view;
        readonly IAddTrainigProgramSpecRow viewAddRowDialog;
        readonly ICategoryReposytory<Category> reposytoryCategory;
        readonly IExerciseReposytory<Exercise> reposytoryExercise;
        readonly ITrainingProgramHeadReposytory<TrainingProgramHead> reposytoryTrainigProgramHead;
        readonly IMessenger messenger;
        private int trainigProgramHeadId = 0;

        public AddModifyTrainigProgramPresenter(IAddModifyTrainigProgram view, IExerciseReposytory<Exercise> reposytoryExercise, ICategoryReposytory<Category> reposytoryCategory, ISetReposytory<Set> reposytorySet,
            ITrainingProgramHeadReposytory<TrainingProgramHead> reposytoryTrainigProgramHead, IAddTrainigProgramSpecRow dialog, IMessenger messenger, int trainigProgramHeadId)
        {
            this.view = view;
            this.viewAddRowDialog = dialog;
            this.reposytoryCategory = reposytoryCategory;
            this.reposytoryExercise = reposytoryExercise;
            this.reposytoryTrainigProgramHead = reposytoryTrainigProgramHead;
            this.messenger = messenger;
            this.trainigProgramHeadId = trainigProgramHeadId;

            view.AddNewRowButtonClick += View_AddNewRow;
            view.ModifyRowButtonClick += View_ModifyRow;
            view.DeleteRowButtonClick += View_DeleteRow;
            view.OkButtonClick += View_Ок;
            view.CancelButtonClick += View_Cancel;
            view.FormLoaded += View_IsLoad;
            view.NameFieldChanged += View_NameFieldChanged;

            viewAddRowDialog.Ok += ViewAddRowDialog_Ok;
            viewAddRowDialog.Cancel += ViewAddRowDialog_Cancel;
        }

        public AddModifyTrainigProgramPresenter(IAddModifyTrainigProgram view, IExerciseReposytory<Exercise> reposytoryExercise, ICategoryReposytory<Category> reposytoryCategory, ISetReposytory<Set> reposytorySet,
            ITrainingProgramHeadReposytory<TrainingProgramHead> reposytoryTrainigProgramHead, IAddTrainigProgramSpecRow dialog, IMessenger messenger)
        {
            this.view = view;
            this.viewAddRowDialog = dialog;
            this.reposytoryCategory = reposytoryCategory;
            this.reposytoryExercise = reposytoryExercise;
            this.reposytoryTrainigProgramHead = reposytoryTrainigProgramHead;
            this.messenger = messenger;
            view.AddNewRowButtonClick += View_AddNewRow;
            view.ModifyRowButtonClick += View_ModifyRow;
            view.DeleteRowButtonClick += View_DeleteRow;
            view.OkButtonClick += View_Ок;
            view.CancelButtonClick += View_Cancel;
            view.FormLoaded += View_IsLoad;
            view.NameFieldChanged += View_NameFieldChanged;

            viewAddRowDialog.Ok += ViewAddRowDialog_Ok;
            viewAddRowDialog.Cancel += ViewAddRowDialog_Cancel;
        }

        private void View_NameFieldChanged(object sender, EventArgs e)
        {
            if (view.GetName() == string.Empty)
            {
                view.SetButtonOkEnabled(false);
            }
            else view.SetButtonOkEnabled(true);
        }

        #endregion

        private void View_IsLoad(object sender, EventArgs e)
        {
            switch (trainigProgramHeadId == 0)
            {
                case true:
                    {
                        view.FormName = "Add New Trainig Programm";
                        break;
                    }
                case false:
                    {
                        view.FormName = "Modify Trainig Programm";
                        view.SetDate(reposytoryTrainigProgramHead.GetOne(trainigProgramHeadId).Date);
                        view.SetName(reposytoryTrainigProgramHead.GetOne(trainigProgramHeadId).Name);
                        view.SetDescription(reposytoryTrainigProgramHead.GetOne(trainigProgramHeadId).Description);
                        view.SetAllRow(reposytoryTrainigProgramHead.GetTrainigProgramSpec(trainigProgramHeadId));
                        break;
                    }
            }

            view.SetListCategory(reposytoryCategory.GetAll() as List<Category>);
            view.SetDataGrDisplayMember("Name");
            view.SetDataGrValueMember("Id");
            view.SetButtonOkEnabled(false);
        }

        private void View_AddNewRow(object sender, EventArgs e)
        {
            viewAddRowDialog.SetExercise(reposytoryExercise.GetAllExercises() as List<Exercise>); //TODO: лишнее обращение к базе при добавлении строки
            viewAddRowDialog.SetDataGrDisplayMember("Name");
            viewAddRowDialog.SetDataGrValueMember("Id");
            viewAddRowDialog.SetFormText("Add new row");
            viewAddRowDialog.ShowDialog();
        }

        private void View_ModifyRow(object sender, EventArgs e)
        {
            string[] currentRow = view.GetCurrentRow();

            if (currentRow != null)
            {
                viewAddRowDialog.SetFormText("Modify current row");
                viewAddRowDialog.SetExercise(reposytoryExercise.GetAllExercises() as List<Exercise>);
                viewAddRowDialog.SetDefaultExercise(currentRow[0]);
                viewAddRowDialog.SetSetNum(currentRow[1]);
                viewAddRowDialog.SetWeight(currentRow[2]);
                viewAddRowDialog.SetAmount(currentRow[3]);
                viewAddRowDialog.ShowDialog();
            }
            else return;
        }

        private void View_DeleteRow(object sender, EventArgs e)
        {
            view.DeleteCurrentRow();
        }

        private void ViewAddRowDialog_Ok(object sender, EventArgs e)
        {
            switch (viewAddRowDialog.GetFormText())
            {
                case "Add new row":
                    string[] row = new string[] { viewAddRowDialog.GetExercise(), viewAddRowDialog.GetSetNum().ToString(), viewAddRowDialog.GetWeight().ToString(), viewAddRowDialog.GetAmount().ToString() };
                    if (IsPresentDoubledData(row, view.GetAllRows()))
                    {
                        view.AddRow(row);
                        viewAddRowDialog.ClearFields();
                        viewAddRowDialog.Close();
                    }
                    else
                    {
                        messenger.ShowMessageError("Error", "Adding row is incorrect");
                        return;
                    }
                    break;
                case "Modify current row":
                    row = new string[] { viewAddRowDialog.GetExercise(), viewAddRowDialog.GetSetNum().ToString(), viewAddRowDialog.GetWeight().ToString(), viewAddRowDialog.GetAmount().ToString() };
                    DataTable table = view.GetAllRows();
                    table.Rows.RemoveAt(view.GetCurrentRowIndex());
                    if (IsPresentDoubledData(row, table))
                    {
                        view.ModifyCurrentRow(row);
                        viewAddRowDialog.ClearFields();
                        viewAddRowDialog.Close();
                    }
                    else
                    {
                        messenger.ShowMessageError("Error", "Adding row is incorrect");
                        return;
                    }
                    break;
            }
        }

        private void ViewAddRowDialog_Cancel(object sender, EventArgs e)
        {
            this.trainigProgramHeadId = 0;
            viewAddRowDialog.ClearFields();
            viewAddRowDialog.Close();
        }

        private bool IsPresentDoubledData(string[] row, DataTable dataTable)
        {
            foreach (DataRow item in dataTable.Rows)
            {
                if (row[0] + row[1] == (string)item[0] + (string)item[1]) return false;
            }
            return true;
        }

        public void Run()
        {
            view.ShowDialog();
        }

        private void View_Ок(object sender, EventArgs e)
        {

        }

        private void View_Cancel(object sender, EventArgs e)
        {
            viewAddRowDialog.ClearFields();
            view.Clear();
            view.Hide();
        }
    }
}
