using DomainLayer.Model;
using DomainLayer.Reposytory;
using System;
using System.Collections.Generic;

namespace PresentationLayer
{
    public class CategoryPresenter : IPresenter
    {
        readonly ICategory view;
        readonly IAddModifyCategory viewDialog;
        readonly IMessenger messenger;
        readonly ICategoryReposytory<Category> catalogReposytory;

        Category category;

        public CategoryPresenter(ICategory view, IMessenger messenger, ICategoryReposytory<Category> reposytory, IAddModifyCategory viewDialog)
        {
            this.view = view;
            this.viewDialog = viewDialog;
            this.messenger = messenger;
            this.catalogReposytory = reposytory;

            this.view.CategoryFormIsActivated += View_CategoryFormIsActivated;
            this.view.AddNewCategory += View_AddNewCategory;
            this.view.DeleteCategory += View_DeleteCategory;
            this.view.ModifyCategory += View_ModifyCategory;

            this.viewDialog.ButtonOk += ViewDialog_ButtonOk;
            this.viewDialog.ButtonCancel += ViewDialog_ButtonCancel;
            this.viewDialog.SetMaxLengthNameCategory(40);
        }

        private void View_CategoryFormIsActivated(object sender, EventArgs e)
        {
            view.FillCategoryGrid(catalogReposytory.GetAll() as List<Category>);
        }

        private void View_AddNewCategory(object sender, EventArgs e)
        {
            viewDialog.SetFormName("Add category");
            category = new Category();
            viewDialog.ShowDialog();
            view.FillCategoryGrid(catalogReposytory.GetAll() as List<Category>);
            view.SetEndGridCursorPosition();
        }

        private void View_ModifyCategory(object sender, EventArgs e)
        {
            if (view.GetCurrentRow() is Category currentCategory)
            {
                category = currentCategory;
            }

            viewDialog.SetFormName("Modify category");
            viewDialog.SetName((view.GetCurrentRow() as Category).Name);
            viewDialog.ShowDialog();
            view.FillCategoryGrid(catalogReposytory.GetAll() as List<Category>);
        }

        private void View_DeleteCategory(object sender, EventArgs e)
        {
            if (view.GetCurrentRow() is Category currentCategory)
            {
                catalogReposytory.Delete(currentCategory);
                view.FillCategoryGrid(catalogReposytory.GetAll() as List<Category>);
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
            if (!viewDialog.IsCorrectInputData()) return;
            category.Name = viewDialog.GetName();
            if (category.Id == 0)
            {
                catalogReposytory.Add(category);
            }
            else catalogReposytory.Save(category);

            viewDialog.ClearFields();
            viewDialog.Hide();
        }

        public void Run(IMainForm view)
        {
            this.view.Show(view);
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
