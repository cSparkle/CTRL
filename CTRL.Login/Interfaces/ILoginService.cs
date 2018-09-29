using CTRL.Domain.Classes;

namespace CTRL.Login.Interfaces
{
    public interface ILoginService
    {
        UserProfile GetUser(LoginContract contract);
    }
}
