using CTRL.Domain.Classes;

namespace CTRL.Domain.Interfaces
{
    public interface ILoginRepository
    {
        UserProfile GetUser(LoginContract contract);
    }
}
