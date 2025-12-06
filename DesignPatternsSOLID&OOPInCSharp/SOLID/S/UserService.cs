namespace DesignPatternsSOLID_OOPInCSharp.SOLID.S
{
    internal class UserService
    {
        public void Register(User user)
        {
            // registration logic
            Console.WriteLine("User registered successfully.");
            // send email notification
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome " + user.Username + "!");
        }
    }
}
