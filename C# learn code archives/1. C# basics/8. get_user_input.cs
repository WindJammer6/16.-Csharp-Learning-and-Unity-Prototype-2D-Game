//In this file, we will only cover how to get user input as strings, this may not work if you want to
//take the user input as other data types such as integers/floats/doubles/decimals. We will be exploring
//taking user input as other data types such as integers/floats/doubles/decimals in the
//'1. calculator.cs' file in the 'C# short projects' folder

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //The difference between 'Console.WriteLine' and 'Console.Write' is more on just formatting
            //where,
            //-> 'Console.WriteLine' is used to display text and inserts a line break at the end, and it 
            //   writes the text to the console and moves the cursor to the beginning of the next line, 
            //   ensuring that subsequent output appears on a new line.
            //-> 'Console.Write' is used to display text without inserting a line break at 
            //   the end, and it writes the text to the console and leaves the cursor at the end of the 
            //   text, allowing subsequent output to appear on the same line.

            //Both the 'Console.WriteLine' and 'Console.Write' functions work, but it is conventional to
            //use 'Console.Write' when trying to get user input so that the user will provide their input
            //on the same line in the output as the prompt instead
            Console.WriteLine("What's your name: ");

            //The ability for the program to really 'get' the input of the user comes from the 
            //'Console.ReadLine' function, which reads the entire line of text entered by the user, 
            //including any spaces or special characters, and returns it as a 'string' data type 
            //(IMPORTANT NOTE!!).
            string name = Console.ReadLine();

            Console.Write("What's your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", you are " + age + " years old");

            Console.ReadLine();
        }
    }
}
   
   
