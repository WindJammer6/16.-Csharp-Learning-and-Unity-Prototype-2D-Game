namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {   
            //In any program, only the special method (more on what special methods are in the is in the 'C# OOP' 
            //folder, or the 'Object_Oriented_Programming_(OOP)_learn' folder), called 'Main' is being run. Any 
            //other self-made functions or class/static/special methods are not run by the program. Hence, in order 
            //to run your self-made function or class/static/special method, you need to 'call' them inside the
            //'Main' special method (the main code)
            
            //1. Running/Calling the self-made function 'JustSayHi'
            JustSayHi();

            //2. Getting user input and storing their input, and running/calling that input through the self-made 
            //   function 'SayHiToUser'
            Console.Write("Enter your name: ");
            string name_of_user = Console.ReadLine();
            SayHiToUser(name_of_user);

            //3. Getting user input and storing their input, and running/calling that input through the self-made
            //   function 'SayHiToUserAndAge'
            Console.Write("Enter your name: ");
            string name_of_user2 = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age_of_user = Convert.ToInt32(Console.ReadLine());
            SayHiToUserAndAge(name_of_user2, age_of_user);

            Console.ReadLine();
        }



        //Here are examples on how functions are called in C#. Some background on the first line of the codes in
        //a function in C#, 'static void Function(argument)',
        //-> the 'static' command represents that this is a static method (more on what a static method is in 
        //   the 'C# OOP' folder, or the 'Object_Oriented_Programming_(OOP)_learn' folder)
        //-> the 'void' command represents that the function does not return anything (via the 'return' function)
        //-> the 'Function()' command represents the name of the function
        //-> the 'argument' command represents the argument(s) (can have multiple) being passed into the function


        //About naming functions in C#,
        //Unlike Python, where functions/methods and Classes are named with underscores between words. In C#, the 
        //functions/methods and Classes are named instead of underscores, with a captial of every word in the name, 
        //inclusive of the first letter/word of the name (e.g. the names of existing built-in functions/built-in C# 
        //libraries (Classes) - 'Main', 'Console', 'ToConvert', 'ToInt32()', 'WriteLine()', 'ReadLine()' etc)


        //We will be creating 3 similar functions in C# here,

        //1. This 'JustSayHi' self-made function does not take in any arguments, and simply just says 'Hi'
        static void JustSayHi()
        {
            Console.WriteLine("Hi");
        }

        //2. This 'SayHiToUser' self-made function takes in 1 'string' argument, and says 'Hi' to the user's name 
        static void SayHiToUser(string name)
        {
            Console.WriteLine("Hi " + name);
        }

        //3. This 'SayHiToUserAndAge' self-made function takes in 2 arguments (a 'string' and an 'int'), and says 
        //   'Hi' to the user's name and says the user's age 
        static void SayHiToUserAndAge(string name, int age)
        {
            Console.WriteLine("Hi " + name + ", you are " + age + " years old");
        }
    }
}