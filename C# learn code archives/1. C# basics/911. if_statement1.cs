//In this file, we will learn about if else statements, where we will use new commands such as,
//-> 'if' 
//-> 'else if' (note that the 'elif' statement does not exist in C#, unlike in Python)
//-> 'else'

//As well as commands used in defining the if else statements conditions such as, 
//-> '&&' (the equivalent of the 'and' operator in Python)
//-> '||' (the equivalent of the 'or' operator in Python)
//-> '!' (the equivalenet of the 'not' operator in Python) (there is a different way of how it is used in C#
//   that you cant do in Python (see the code below))
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {   
            //The tutorial's code:
            //Lets say that this particular person is a male, and is short
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.Write("You are a male and is tall");
            }
            //The '!isTall' in this else if condition basically mean not tall. Hence, 'isMale && !isTall' means
            //if this person is a male and is not tall
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a male and is short");
            }
            //The '!isMale' in this else if condition basically mean not tall. Hence, '!isMale && isTall' means
            //if this person is not a male and is tall
            else  if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male and is tall");
            }
            //The condition for this else statement is only going to be '!isMale && !isTall' which means if this 
            //person is not a male and is not tall 
            else
            {
                Console.WriteLine("You are not a male and is not tall");
            }
            

            /////////////////////////////////////////////////////////
            

            //My own code:
            bool isMale2;
            isMale2 = true;

            Console.Write("Are you male or female (please type 'm' for male or 'f' for female): ");
            string response = Console.ReadLine();
            if (response == "m")
            {
                isMale2 = true;
            }
            else if (response == "f")
            {
                isMale2 = false;
            }
            else
            {
                Console.WriteLine("Please enter 'm' or 'f'!");
            }


            if (response == "f" || response == "m")
            {
                if (isMale2 is true)                     //OR just 'if (isMale2)' works too
                {
                    Console.WriteLine("You are a male");
                } 
                else
                {
                    Console.WriteLine("You are female");
                }
            }

            Console.ReadLine();
        }
    }
}
