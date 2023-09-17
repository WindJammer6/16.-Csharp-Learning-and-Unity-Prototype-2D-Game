//To tackle the flaw in our Basic Addition Only Calculator mentioned in '2. basic_addition_only_calculator2'
//we will instead store the two numbers as decimal numbers, of the 'double' data type instead

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the first decimal (double) number
            Console.Write("Enter the first number: ");
            //Here, to convert the returned string output from the 'Console.ReadLine' function to a double,
            //we will use 'ToDouble' instead of 'ToInt32', and specify that the 'num1' variable will contain
            //a 'double' data type instead of an 'int' data type 
            double num1 = Convert.ToDouble(Console.ReadLine());


            //Getting the second decimal (double) number
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
   
   