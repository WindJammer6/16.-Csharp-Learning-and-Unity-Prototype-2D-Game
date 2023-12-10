namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDayFromNumber(0));
        
            Console.ReadLine();
        }


        static string GetDayFromNumber(int day_number)
        {
            string day_name;

            // The 'switch' statement in C# is used for multi-way branching, allowing you to easily handle different 
            // cases via the 'case' statement based on the value of a variable.

            // If no case matches, the default case is executed via the 'default' statement.
            switch (day_number)
            {
                case 0:
                day_name = "Sunday";
                break;

                case 1:
                day_name = "Monday";
                break;

                case 2:
                day_name = "Tuesday";
                break;

                case 3:
                day_name = "Wednesday";
                break;

                case 4:
                day_name = "Thursday";
                break;

                case 5:
                day_name = "Friday";
                break;

                case 6:
                day_name = "Saturday";
                break;

                default:
                day_name = "Invalid Day Number (only the number 0 to 6 allowed)";
                break;
            }
        }
    }
}

