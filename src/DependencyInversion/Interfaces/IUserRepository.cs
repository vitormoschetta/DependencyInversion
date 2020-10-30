using DependencyInversion.Commands;

namespace DependencyInversion.Interfaces
{
    public interface IUserRepository
    {
        void Create(UserCommand command);
    }
}