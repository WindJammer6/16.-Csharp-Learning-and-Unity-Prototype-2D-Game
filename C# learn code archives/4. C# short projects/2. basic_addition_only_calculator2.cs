namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the first integer (int) number
            Console.Write("Enter the first number: ");

            //Since 'Console.ReadLine' will return us a string, we cannot simply just
            //insert the returned string into the integer 'num1' variable. We need to first
            //convert the data type from a string to an 'int' (Int32) data type via the 
            //'Convert.ToInt32' function

            //A more step-by-step way would be,
                //string is_string = Console.ReadLine();
                //int num1 = Convert.ToInt32(is_string);
            //but in this tutorial we would want to do it via a faster way like so:
            int num1 = Convert.ToInt32(Console.ReadLine());


            //Getting the second integer (int) number
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
   

//However, there is a flaw in our program, where it will give us an error if the user made
//any inputs of decimal numbers since it is not created to handle decimal numbers, only
//integer inputs. We will see how we can improve our Basic Addition Only Calculator in the 
//next file '3. basic_addition_only_calculator3' 
   