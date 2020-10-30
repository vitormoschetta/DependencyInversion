using DependencyInversion.Commands;
using DependencyInversion.Repositories;

namespace DependencyInversion.Handlers
{
    public class GroupHandler
    {
        public CommandResult Create(GroupCommand command)
        {
            // Estamos dependendo da implementação do repositório e não de uma abstração, que seria correto.
            // Dessa forma não poderemos confiar nos testes, por exemplo, uma vez que não temos certeza se o 
            // banco de dados está disponível.
            var repository = new GroupRepository();
            repository.Create(command);
            return new CommandResult(true, "Message");
        }
    }
}