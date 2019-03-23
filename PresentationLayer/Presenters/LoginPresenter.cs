using DomainLayer.Model;
using DomainLayer.Reposytory;
using Initialize;
using ServiceLayer;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class LoginPresenter : IPresenter
    {
        readonly IController controller;
        readonly ILogin view;
        readonly IUserReposytory<User> userRepo;
        readonly IMessenger messenger;

        public LoginPresenter(IController controller, ILogin view, IMessenger messenger, IUserReposytory<User> userReposytory)
        {
            this.view = view;
            this.view.ButtonOkClick += View_ButtonOkClick;
            this.view.CheckboxChanged += View_CheckboxChanged;
            this.userRepo = userReposytory;
            this.messenger = messenger;
            this.controller = controller;
        }

        public void Run()
        {
            controller.SetMainWindow(view as Form);
            Application.Run(controller.GetContext());
        }

        private void View_CheckboxChanged(object sender, EventArgs e)
        {
            if (view.GetShowPasswordFlag() == true) view.SetViewPassword(false);
            else
                view.SetViewPassword(true);
        }

        private void View_ButtonOkClick(object sender, EventArgs e)
        {
            InitalDB();
            if (userRepo.IsUserPresentDB(view.GetLogin(), view.GetPassword()))
            {
                controller.GetInstanse<MainMenuPresenter>().Run();
                view.Close();
            }
            else messenger.ShowMessageError("Operation Login", "Login or Password are incorrect");
        }

        private static void InitalDB()
        {
            Database.SetInitializer(new MyInitializerDB());

            using (Context context = new Context())
            {
                var querry = from user in context.Users.ToList()
                             select user;
            }
        }
    }
}
