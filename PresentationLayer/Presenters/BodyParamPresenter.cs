using DomainLayer.Model;
using DomainLayer.Reposytory;
using System;

namespace PresentationLayer
{
    public class BodyParamPresenter : IPresenter
    {
        readonly IBodyParam view;
        readonly IMessenger messenger;
        readonly IBodyReposytory<Param> reposytory;

        public BodyParamPresenter(IBodyParam view, IMessenger messenger, IBodyReposytory<Param> reposytory)
        {
            this.view = view;
            this.messenger = messenger;
            this.reposytory = reposytory;
            this.view.ActivatedBodyForm += ViewActivated;
            this.view.ButtonCancelClick += View_ButtonCancelClick;
            this.view.ButtonOkClick += View_ButtonOkClick;
            this.view.DateChanged += View_DateChanged;
            this.view.LoadLastParametersChanged += View_LoadLastParametersChanged;
            this.view.LoadDefaultParametersChanged += View_LoadDefaultParametersChanged;
            this.view.LoadDateParametersChanged += View_LoadDateParametersChanged;
        }

        private void View_LoadDateParametersChanged(object sender, EventArgs e)
        {
            view.FillGrid(reposytory.SelectParam(view.GetDate()).ToList());
        }

        private void View_LoadDefaultParametersChanged(object sender, EventArgs e)
        {
            view.FillGrid(reposytory.SelectDefaultParam().ToList());
        }

        private void View_LoadLastParametersChanged(object sender, EventArgs e)
        {
            view.FillGrid(reposytory.SelectParam().ToList());
        }

        private void View_DateChanged(object sender, EventArgs e)
        {
            view.FillGrid(reposytory.SelectParam(view.GetDate()).ToList());
        }

        private void View_ButtonOkClick(object sender, EventArgs e)
        {
            var bodyParam = new Param
            {
                ProfileId = 1, // Не забыть переделать под конкретного юзера
                Date = view.GetDate(),
                Weight = view.GetWeight(),
                Breast = view.GetBreast(),
                Waist = view.GetWaist(),
                Buttock = view.GetButtock(),
                Thigh = view.GetThigh()
            };
            reposytory.AddDailyParameters(bodyParam);
            view.Close();
        }
        private void View_ButtonCancelClick(object sender, EventArgs e)
        {
            view.Close();
        }

        private void ViewActivated(object sender, EventArgs e)
        {
            view.SetCurrentDate();
            view.FillGrid(reposytory.SelectParam(DateTime.Today).ToList());            
        }

        public void Run(IView view)
        {
            Run();
        }

        public void Run()
        {
            this.view.Show();
        }
    }
}
