using DependencyInversion.Commands;
using DependencyInversion.Controllers;
using DependencyInversion.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Mock;

namespace Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repository = new UserRepositoryFake();
            var handler = new UserHandler(repository);
            var controller = new UserController(handler, repository); //<-- graças a IUserRepository e IUserHandler podemos testar o Controller
            var command = new UserCommand("Name");
            var result = handler.Create(command);
            Assert.IsTrue(result.Success);
        }
    }
}