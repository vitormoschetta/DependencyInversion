using DependencyInversion.Commands;
using DependencyInversion.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Mock;

namespace Tests.Handlers
{
    [TestClass]
    public class GroupHandlerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var command = new GroupCommand("name");
            var handler = new GroupHandler();
            var result = handler.Create(command);
            Assert.IsTrue(result.Success);

            // Veja que GroupHandler não usa Injeção de Dependencia, ele está 
            // altamente acoplado ao GroupRepository.

            // Além do problema de acoplamento, os testes se tornam inseguros, 
            // uma vez que estaríamos dependendo da disponibilidade da infraestrutura (banco de dados).            
        }
    }
}