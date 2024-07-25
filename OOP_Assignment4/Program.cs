using OOP_Assignment4.Authentication;
using OOP_Assignment4.Notification;
using OOP_Assignment4.Shape;

namespace OOP_Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            #region Question 1
            // What is the primary purpose of an interface in C#?
            // a) To provide a way to implement multiple inheritance
            // b) To define a blueprint for a class
            // c) To declare abstract methods and properties
            // d) To create instances of objects
            //
            // Answer: c) To declare abstract methods and properties
            #endregion
            #region Question 2
            // Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private
            // b) protected
            // c) internal
            // d) public
            //
            // Answer: a) private
            #endregion
            #region Question 3
            // Can an interface contain fields in C#?
            // a) Yes
            // b) No
            // c) Only if they are static
            // d) Only if they are read only
            //
            // Answer: b) No
            #endregion
            #region Question 4
            // In C#, can an interface inherit from another interface?
            // a) No, interfaces cannot inherit from each other
            // b) Yes, interfaces can inherit from multiple interfaces
            // c) Yes, but only if they have the same methods
            // d) Only if the interfaces are in the same namespace
            //
            // Answer: b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region Question 5
            // Which keyword is used to implement an interface in a class in C#?
            // a) inherit
            // b) use
            // c) extends
            // d) implements
            //
            // Answer: d) implements (اخترتها عشان دي الكلمة اللي ببتقال ان الكلاس بي ايمبليمنت الانترفيس و بنستعمل : عشان نعمل امبليمنت)
            #endregion
            #region Question 6
            // Can an interface contain static methods in C#?
            // a) Yes
            // b) No
            // c) Only if the interface is sealed
            // d) Only if the methods are private
            //
            // Answer: a) Yes (هو نفع لما جربته بس الفانكشن لازم يكون ليها body)
            #endregion
            #region Question 7
            // In C#, can an interface have explicit access modifiers for its members?
            // a) Yes, for all members
            // b) No, all members are implicitly public
            // c) Yes, but only for abstract members
            // d) Only if the interface is sealed
            //
            // Answer: b) No, all members are implicitly public
            #endregion
            #region Question 8
            // What is the purpose of an explicit interface implementation in C#?
            // a) To hide the interface members from outside access
            // b) To provide a clear separation between interface and class members
            // c) To allow multiple classes to implement the same interface
            // d) To speed up method resolution
            //
            // Answer: b) To provide a clear separation between interface and class members
            #endregion
            #region Question 9
            // In C#, can an interface have a constructor?
            // a) Yes, but it must be private
            // b) No, interfaces cannot have constructors
            // c) Yes, but only if the interface is sealed
            // d) Only if the constructor is static
            //
            // Answer: b) No, interfaces cannot have constructors
            #endregion
            #region Question 10
            // How can a C# class implement multiple interfaces?
            // a) By using the "implements" keyword
            // b) By using the "extends" keyword
            // c) By separating interface names with commas
            // d) A class cannot implement multiple interfaces
            //
            // Answer: c) By separating interface names with commas
            #endregion
            #endregion
            #region Part 2
            #region Question 1
            Circle circle = new(15);
            Rectangle rectangle = new(20, 10);
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            #endregion
            #region Question 2
            Console.WriteLine("<===============================================>");
            IAuthenticationService authenticationService = new BasicAuthenticationService();
            UserModel user = new() { UserName = "Karim", Password = "admin", Role = "admin" };
            bool isUserAuthenticated = authenticationService.AuthenticateUser(user);
            Console.WriteLine($"This user is {(isUserAuthenticated ? "" : "not")} authenticated");
            if (isUserAuthenticated)
            {
                bool isUserAutherizied = authenticationService.AuthorizeUser(user);
                Console.WriteLine($"This user is {(isUserAutherizied ? "" : "not")} authorized as {user.Role}");
            }
            #endregion
            #region Question 3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();
            Console.WriteLine("<===============================================>");
            emailService.SendNotification("email@example.com", "Hello Email!");
            smsService.SendNotification("123-456-7890", "Hello SMS!");
            pushService.SendNotification("user123", "Hello Push Notification!");
            #endregion
            #endregion
        }
    }
}