namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double first_number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double second_number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter mathematical operation to be done on the 2 numbers (Please enter '+', '-', '*', or '/'): ");
            string math_operator = Console.ReadLine();

            if (math_operator == "+")
            {
                Console.WriteLine(first_number + second_number);
            }
            else if (math_operator == "-")
            {
                Console.WriteLine(first_number - second_number);
            }
            else if (math_operator == "*")
            {
                Console.WriteLine(first_number * second_number);
            }
            else if (math_operator == "/")
            {
                Console.WriteLine(first_number / second_number);
            }
            else
            {
                Console.WriteLine("Please enter a valid input!");
            }


            Console.ReadLine();
        }   
    }
}
