using DependencyInversion.Commands;
using DependencyInversion.Handlers;
using DependencyInversion.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Mock;

namespace Tests.Handlers
{
    [TestClass]
    public class ProductHandlerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var command = new ProductCommand("name");
            var repository = new ProductRepository();
            //var repositoryFake = new ProductRepositoryFake();
            var handler = new ProductHandler(repository);
            var result = handler.Create(command);
            Assert.IsTrue(result.Success);

            // Não podemos passar um repositorio fake, pois ProductHandler está 
            // dependendo de uma implementação de ProductRepository, e não de uma abstração.

            // Perceba que se precisarmos mudar o repositório, precisaremos modificar o código na classe ProductHandler.

            // Os testes também se tornam inseguros, uma vez que estaríamos dependendo da disponibilidade da 
            // infraestrutura (banco de dados).            
        }
    }
}