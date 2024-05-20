namespace PersonellPayrollSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Register personellPayrollRegister = new Register();

            Console.WriteLine("Choose the operation to do:");
            Console.WriteLine("1 - Add en employee");
            Console.WriteLine("2 - Print employee List");
            Console.WriteLine("3 - close the program");
            Console.Write("insert your choice: ");
            string choice = Console.ReadLine();
            int chs = -1;
            var correctInsertion = int.TryParse(choice, out chs);
           
            while (correctInsertion == true && chs < 3 && chs > 0)
            {
                switch (chs) {
                    case 1:
                        personellPayrollRegister.addEmplyee();
                        break;
                    case 2:
                        personellPayrollRegister.printEmplyeeList();
                        break;
                    case 3:
                        Console.WriteLine("good Bye!");
                        break;
                    default:
                        Console.WriteLine("No good choice");
                        break;

                }

                Console.WriteLine("Choose the operation to do:");
                Console.WriteLine("1 - Add en employee");
                Console.WriteLine("2 - Print employee List");
                Console.WriteLine("3 - close the program");
                Console.Write("insert your choice: ");
                choice = Console.ReadLine();
                correctInsertion = int.TryParse(choice, out chs);
                if (correctInsertion == false)
                {
                    Console.WriteLine("No good choice");
                }
            }

            
        }


    }
}
