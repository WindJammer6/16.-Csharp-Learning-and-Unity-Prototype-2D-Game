namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPower(2, 4));
            Console.ReadLine();
        }   


        //Here, we are building a function that will return us the power of a number. It takes in
        //2 arguments, the 'base_number' and the 'power_number', and returns the 'powered_total'

        //Remember to tell C# in your function that it returns an 'int' integer, instead of leaving
        //it as 'void' like so,

            //'static void GetPower(int base_number, int power_number)' 
            
        //which will give you an error
        static int GetPower(int base_number, int power_number)
        {
            int powered_total = base_number;

            for (int i = 0; i < power_number - 1; i++)
            {
                powered_total = powered_total * base_number;
            }

            return powered_total;
        }
    }   
}
