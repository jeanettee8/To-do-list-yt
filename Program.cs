namespace To_do_list_yt;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<string>Tasks = new List<string>();
        while (running) {
            Console.WriteLine("Welcome to the to do list program.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter 1 to add a task to the list.");
            Console.WriteLine("Enter 2 to remove a task from the list.");
            Console.WriteLine("Enter 3 to view the list.");
            Console.WriteLine("Enter e t exit the program.");
        
            string userInput = Console.ReadLine();
            if (userInput == "e")
            {
                break;
            }

            int input;
            while (!int.TryParse(userInput, out input)) {
                Console.WriteLine("Please enter a valid number or \"e\" to exit.");
                userInput = Console.ReadLine();
            }

            switch (input)
            {
                case 1:
                Console.WriteLine("Please enter the name of the task to add to the list.");
                string addList = Console.ReadLine();
                Tasks.Add(addList);
                if (Tasks.Contains(addList))
                {
                    Console.WriteLine("Task successfully added to the list.");
                }
                else
                {
                    Console.WriteLine("Something went wrong.");
                }
                Console.WriteLine(); //Readability
                break;

                case 2:
                Console.WriteLine("Write the task you would like to remove:");
                string removeTask = Console.ReadLine();
                Tasks.Remove(removeTask);
                Console.WriteLine("Task removed from the list.");
                Console.WriteLine(); //Readability
                break;

                case 3:
                Console.WriteLine("Current tasks in the list:");
                foreach (string tasks in Tasks)
                {
                    Console.WriteLine(tasks); //tasks, not Tasks = tasks is each string, Tasks is the whole list (cannot be printed out this way)
                }
                Console.WriteLine(); //Readability
                break;

                default:
                break;
        
            }
        }
    
    }
}
