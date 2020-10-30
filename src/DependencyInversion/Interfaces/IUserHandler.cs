using DependencyInversion.Commands;

namespace DependencyInversion.Interfaces
{
    public interface IUserHandler
    {
        CommandResult Create(UserCommand command);
    }
}