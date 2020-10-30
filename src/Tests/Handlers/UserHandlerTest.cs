using DependencyInversion.Commands;
using DependencyInversion.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Mock;

namespace Tests.Handlers
{
    [TestClass]
    public class UserHandlerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var command = new UserCommand("name");
            var repositoryFake = new UserRepositoryFake();
            var handler = new UserHandler(repositoryFake); // <-- Graças a Interface IUserRepository podemos passar um repositorio fake
            var result = handler.Create(command);           // uma vez que tanto UserRepository, quanto UserRepositoryFake implementam 
            Assert.IsTrue(result.Success);                  // IUserRepository. Estamos dependendo de uma abstração e não da implementação.

            // Perceba que se quisemos mudar o repositório basta que passemos esse novo repositório como parâmetro ao UserHandler, desde
            // que esse novo repositório implemente a interface IUserRepository. Dessa forma não precisamos mexer no UserHandler.
        }
    }
}