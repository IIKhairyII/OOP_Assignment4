using System.Runtime.CompilerServices;

namespace OOP_Assignment4.Authentication
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly List<UserModel> _users = new()
        {
            new(){ ID = 1, UserName = "Karim", Password = "admin", Role= "admin"},
            new(){ ID = 2, UserName = "Ahmed", Password = "123456", Role= "admin"},
            new(){ ID = 3, UserName = "Mona", Password = "ss@123456", Role= "regular"},
            new(){ ID = 4, UserName = "Ali", Password = "regular", Role= "regular"},
            new(){ ID = 5, UserName = "Lobna", Password = "regular@1234", Role= "regular"},
        };
        public bool AuthenticateUser(UserModel loggedinUser)
        {
            UserModel user = _users.FirstOrDefault(u => u.UserName.Equals(loggedinUser.UserName) && u.Password.Equals(loggedinUser.Password));
            return !(user == null);
        }

        public bool AuthorizeUser(UserModel loggedinUser)
        {
            UserModel user = _users.FirstOrDefault(u => u.UserName.Equals(loggedinUser.UserName) && u.Role.Equals(loggedinUser.Role));
            return !(user == null);
        }
    }
}
