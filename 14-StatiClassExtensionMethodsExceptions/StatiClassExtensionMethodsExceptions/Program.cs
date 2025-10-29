using StatiClassExtensionMethodsExceptions.Exception;
using StatiClassExtensionMethodsExceptions.Exception.LoginSystemApp;

internal class Program
{
    static void Main(string[] args)
    {
        LoginSystem system = new LoginSystem();

        while (true)
        {
            try
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                bool success = system.Login(username, password);

                if (success)
                    break;
            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine();
                system.ShowAllUsers();
            }
            catch (IncorrectPasswordException ex)
            {
                Console.WriteLine("WARNING: " + ex.Message);
            }
            catch (AccountLockedException ex)
            {
                Console.WriteLine("CRITICAL: " + ex.Message);
                Console.WriteLine("Zəhmət olmasa adminlə əlaqə saxlayın.");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
            }

            Console.WriteLine();
        }
    }
}