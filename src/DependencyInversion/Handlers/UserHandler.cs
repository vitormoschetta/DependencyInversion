using DependencyInversion.Commands;
using DependencyInversion.Interfaces;
using DependencyInversion.Repositories;

namespace DependencyInversion.Handlers
{
    public class UserHandler : IUserHandler
    {
        private readonly IUserRepository _repository;
        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public CommandResult Create(UserCommand command)
        {
            return new CommandResult(true, "Message");
        }
    }
}