namespace HW_13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            List<bool> taskStatus = new List<bool>();

            string input;

            do
            {
                Console.WriteLine("\nTo-Do List");
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. Display all tasks");
                Console.WriteLine("3. Mark as completed");
                Console.WriteLine("4. Delete task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option 1-5: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        AddTask(tasks, taskStatus);
                        break;
                    case "2":
                        Console.Clear();
                        DisplayTasks(tasks, taskStatus);
                        break;
                    case "3":
                        Console.Clear();
                        CompleteTask(tasks, taskStatus);
                        break;
                    case "4":
                        Console.Clear();
                        DeleteTask(tasks, taskStatus);
                        break;
                    case "5":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
                Console.WriteLine();
            }
            while (input != "5");
        }
        static void AddTask(List<string> tasks, List<bool> taskStatus)
        {
            Console.Write("\nEnter the name of the task: ");
            string taskName = Console.ReadLine();
            tasks.Add(taskName);
            taskStatus.Add(false);
            Console.Write("Task is successfully added");
        }
        static void DisplayTasks(List<string> tasks, List<bool> taskStatus)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("To-Do List is empty");
                return;
            }
            Console.WriteLine("\nTo-Do List:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = taskStatus[i] ? "[completed]" : "[not/completed]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
            }
        }
        static void CompleteTask(List<string> tasks, List<bool> taskStatus)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("To-Do List is empty");
                return;
            }
            Console.Write("Enter task number to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                taskStatus[taskNumber - 1] = true;
                Console.WriteLine("Task marked as completed");
            }
            else
            {
                Console.WriteLine("Incorrect task number");
            }
        }
        static void DeleteTask(List<string> tasks, List<bool> taskStatus)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("To-Do List is empty");
                return;
            }
            Console.Write("Enter task number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                taskStatus.RemoveAt(taskNumber - 1);
                Console.WriteLine("The task is deleted");
            }
            else
            {
                Console.WriteLine("Incorrect task number");
            }
        }
    }
}

