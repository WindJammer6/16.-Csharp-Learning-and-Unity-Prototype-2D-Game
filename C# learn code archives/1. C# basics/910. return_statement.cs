namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter a number to cube: ");
            int number_to_cube = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cube(number_to_cube));
            Console.ReadLine();
        }

        //Here we introduce the 'return' function in this self-made function ('Cube'). Recall that we have always 
        //been letting the returned value be instead of 'void', now be whatever the data type of the data we
        //want this self-made function ('Cube') to return, which will be an integer ('int') in this case.

        //Know that we can actually return any kind of data type, 'string', 'double', etc. And even Array Data 
        //Structures such as 'string[]', 'double[]', etc.
        static int Cube(int number)
        {
            int cubed_number = number * number * number;
            return cubed_number;
        }
    }
}
