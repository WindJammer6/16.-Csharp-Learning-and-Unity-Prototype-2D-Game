namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is my attempt at it and it works:
                //Console.Write("Enter a colour: ");
                //string colour = Console.ReadLine();
                //Console.Write("Enter a plural noun: ");
                //string plural_noun = Console.ReadLine();
                //Console.Write("Enter a celebrity's name: ");
                //string celebrity = Console.ReadLine();

                //Console.WriteLine("\nThis is the Mad Lib passage:");
                //Console.WriteLine($"Roses are {colour}");
                //Console.WriteLine($"{plural_noun} are blue");
                //Console.WriteLine($"I love {celebrity}");


            //Here is what the tutorial taught, which has neater code than my attempt:

            //This line of code declares all the string variables 'colour', 'plural_noun' and 'celebrity' 
            //in one neat line, using commas (which we will later then individually put in string data,
            //and by doing so, we removed the need to specify that the data type of the 'colour', 
            //'plural_noun' and 'celebrity' and strings again every single time later, making the code 
            //look neater)
            string colour, plural_noun, celebrity;

            Console.Write("Enter a colour: ");
            colour = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            plural_noun = Console.ReadLine();
            Console.Write("Enter a celebrity's name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("\nThis is the Mad Lib passage:");
            Console.WriteLine("Roses are " + colour);
            Console.WriteLine(plural_noun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
    }
}
   
   