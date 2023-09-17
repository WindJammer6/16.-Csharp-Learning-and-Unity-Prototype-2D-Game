//In this file we will learn about Exception Handling. 

//Normally, when we encounter a bug where the program crashes, the program will throw an error and will terminate.

//What Exception Handling does instead for our program is that, 
//-> it allows the program to keep running even though you encountered a bug instead of terminating on the spot
//-> and will allow you to tell the program how it should react when it encounters such a bug


////////////////////////////////////////


//The way the program does Exception Handling is via the 'try', 'catch' (the equivalent to the 'except' command in 
//Python), and 'finally' (optional) function/block

//Here's how the 'try', 'catch' and 'except' function/block work in Exceptions Handling,
//1. Code within the 'try' block is executed sequentially.
//2. If an exception occurs during the execution of the 'try' block, the program immediately transfers control to 
//   the first matching 'catch' block, based on the type of exception. Note that you can have multiple 'catch' 
//   function/block to handle different types of error.
//3. If there is no matching 'catch' block, the program may terminate/run the code in the 'finally' function/block
//   (if present), depending on how the exception is handled. Note that the code in the 'finally' function/block
//   which will always be executed, whether or not an exception occurred in the 'try' block and if the exception
//   was caught by a 'catch' function/block, or the exception was not caught. 
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is a simple program that gets user input for two 'int' integer numbers, 'number1' and 'number2', 
            //and dividing 'number1' with 'number2' to get the ouput
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(number1 / number2);



            //However, in certain parts of your code where you might expect an error, you may want the program to
            //raise that error (you can tell what you want the program to do in the case of that type of error
            //under the 'catch' function/block) but still continue to run the rest of the program/code instead of
            //just terminating the program at where the error occured. 
            
            //To do this, you will want to do Exception Handling, the usage of the 'try', 'catch' and 'finally' 
            //(optional) function/block) at that part of your code (as shown in the code below)

            //In this example, the part of the code where you might expect an error is when the user made an 
            //unexpected input that your program cannot handle. Here the 2 examples are,
            //a. when the user try to divide an 'int' integer number by 0, where 'number2' is zero (and 'number1'
            //   is any 'int' integer number) 
            //b. when the user enter in an input that is not an 'int' integer, e.g. 'char', 'string', 'double', 
            //   'float', 'bool' etc.
            try
            {
                Console.Write("Enter a number: ");
                int number3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int number4 = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine(number3 / number4);
            }

            //Here is how you work with the 'catch' function/block. Here are what each of the unfamiliar 
            //functions/variables do,
            //-> 'Exception' represents a class or a base class that represents the concept of an exception or an 
            //   error that can occur during the execution of a program. The 'Exception' class consists of various 
            //   sub-classes that represents other types of errors such as 'DivideByZeroException', 'FormatException'
            //   'FileNotFoundException', 'ArgumentNullException', etc. (you can google for the full list of the 
            //   sub-classes of the 'Exception' class), that you can use in your 'catch' function/block's condition
            //   (you can even use the 'Exception' class itslf to represent the condition to 'catch' any kind of
            //   error like so,

                // catch(Exception error)
                // {

                // }      

            //  as shwon above)

            //-> the 'error' variable  represents the 'Exception' object, and you can access its message using 
            //   'ex.Message' to get information about the error
            //-> the '.Message' function is used to get information about the error
            catch(DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
            }
            catch(FormatException error)
            {
                Console.WriteLine(error.Message);
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("The 'finally' function/block was run.");
            }

            Console.WriteLine("This code lies outside of the 'try', 'catch' and 'finally' function/blocks." );

            Console.ReadLine();
        }   
    }   
}
