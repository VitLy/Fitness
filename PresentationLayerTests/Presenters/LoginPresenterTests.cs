using DomainLayer.Model;
using DomainLayer.Reposytory;
using Moq;
using NUnit.Framework;
using PresentationLayer;

namespace ServiceLayer.Tests
{
    [TestFixture]
    class LoginPresenterTests
    {
        Mock<IUserReposytory<User>> userReposytory;
        Mock<IMessenger> messenger;
        Mock<IController> controller;
        Mock<ILogin> view;
        Mock<MainMenuPresenter> mockMainMenu;
        LoginPresenter loginPresenter;

        [SetUp]
        public void Setup()
        {
            userReposytory = new Mock<IUserReposytory<User>>(MockBehavior.Strict);
            messenger = new Mock<IMessenger>();
            mockMainMenu = new Mock<MainMenuPresenter>();
            view = new Mock<ILogin>();
            controller = new Mock<IController>();
        }

        [Test]
        public void EnteredNamePasswordIsNotPresentInDB()
        {
            userReposytory.Setup(x => x.GetUserFromDB(It.IsAny<string>(), It.IsAny<string>())).Returns(It.IsAny<User>()); //Return Null

            loginPresenter = new LoginPresenter(controller.Object, view.Object, messenger.Object, userReposytory.Object);
            view.Raise(x => x.ButtonOkClick += null, new System.EventArgs());

            view.Verify(x => x.GetLogin());
            view.Verify(x => x.GetPassword());
            userReposytory.Verify();
            messenger.Verify(x=>x.ShowMessageError("Operation Login", "Login or Password are incorrect"));
        }

    }
}
