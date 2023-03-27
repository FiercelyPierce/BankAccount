using BankAccount;

internal class Program
{
    // Instansiates the User object withing a list
    static List<User> user = new List<User>();
    private static void Main(string[] args)
    {
        // Will keep the while loop running until the user wants to quite
        Boolean run = true;

        Console.WriteLine("You can create new user accounts here.");

        do
        {
            Console.WriteLine("Please provide your user's ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Please provide your user's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please provide your user's age:");
            string age = Console.ReadLine();
            Console.WriteLine("Please provide your user's account balance:");
            string balance = Console.ReadLine();

            createUsers(Convert.ToInt32(id), name, Convert.ToInt32(age), Convert.ToInt32(balance));

            Console.WriteLine("Type 'q' to quit, or 'c' to continue");
            string doIRun = Console.ReadLine();
            if (doIRun.ToLower() == "q") { run = false; }

        } while (run);

        displayUsers();
    }

    public static void createUsers(int id,string name,int age,int balance)
    {

        user.Add(new User(id, name, age, balance));

    }

    public static void displayUsers()
    {
        foreach (User i in user)
        {
            Console.WriteLine("ID: " + i.Id + ", Name: " + i.Name + ", Age: " + i.Age + ", Balance: " + i.Balance);
        }
    }
}