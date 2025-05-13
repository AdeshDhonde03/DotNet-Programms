using JWT.Authentication.Models;

namespace JWT.Authentication.Interfaces
{
    public interface IAuthServices
    {
        User AddUser(User user);
        string LogIn(LogInRequest logInRequest);
        Role AddRole(Role role);
        bool AssignRoleToUser(AddUserRole addUserRole);
    }
}
