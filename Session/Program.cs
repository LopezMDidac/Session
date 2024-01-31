using System.Diagnostics.Metrics;

namespace Session
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menuOption = "";
            var users = new List<User>();

            while (menuOption != "4")
            {
                Console.WriteLine("What do you want to do?" +
                    "\n\t1. Add user" +
                    "\n\t2. List all users" +
                    "\n\t3. List internal users" +
                    "\n\t4. Exit");
                menuOption = Console.ReadLine();
                switch (menuOption)
                {
                    case "1":
                        var user = AddNewUser();
                        // Check if user already exists in the users list
                        // if (userNotExists())
                        //{
                        users.Add(user);
                        //}
                        break;
                    case "2":
                        ListUsers(users);
                        break;

                    case "3":
                        ListInternalUsers(users);
                        break;

                    default:
                        break;
                }

            }
        }

        public static bool userNotExists()
        {
            throw new NotImplementedException();
        }

        public static User AddNewUser()
        {
            var userName = "";
            var age = -1;
            var isIntern = false;

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();

            Console.WriteLine("What is your age");
            var rawAge = Console.ReadLine();
            age = int.Parse(rawAge);

            Console.WriteLine("Are you intern?- (Y/N)");
            var intern = Console.ReadLine();

            if (string.Equals(intern.ToUpper(), "Y"))
            {
                isIntern = true;
            }

            var user = new User(userName, age, isIntern);


            Console.WriteLine(user.GreetingMessage());
            return user;
        }


        public static List<string> ListInternalUsers(List<User> users)
        {
            return ListUsers(users, true, false);
        }

        public static List<string> ListExternalUsers(List<User> users)
        {
            return ListUsers(users, false, true);
        }
        public static List<string> ListUsers(List<User> users)
        {
            return ListUsers(users, true, true);
        }

        public static List<string> ListUsers(List<User> users, bool showInternals, bool showExternals)
        {
            var listedUsers = new List<string>();
            foreach (var user in users)
            {
                if (showInternals && user.IsIntern)
                {
                    listedUsers.Add(user.Name);
                }
                else if (showExternals && !user.IsIntern) {
                    listedUsers.Add(user.Name);
                }
                else
                {
                    continue;
                }
                Console.WriteLine(user.Name);
            }
            return listedUsers;
        }
    }
}
