namespace OOP_Assignment4.Authentication
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(UserModel user);
        public bool AuthorizeUser(UserModel user);
    }
}
