namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hardcording a for loop using a while loop
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }


            //Here is how a for loop in C# actually looks like, it does the exact same thing
            //as the 'hardcoded-for-loop' while loop
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }


            //Using a for loop to traverse through an 'array' Array Data Structure in C#
            int[] number_list = {4, 8, 15, 16, 23, 42};
            for(int k = 0; k < number_list.Length; k++)
            {
                Console.WriteLine(number_list[k]);
            }


            Console.ReadLine();
        }   
    }   
}
