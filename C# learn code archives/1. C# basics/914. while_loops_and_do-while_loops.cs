//In this file we will be exploring while loops and do while loops in C#. The fundanebtal difference between these
//2 statements are in how they check their loop condition and when that condition is evaluated.

//-> For a while loop, the loop condition is evaluated at the beginning of each iteration.
//-> For a do while loop (aka the repeat-until loop in some languages), evaluates its loop condition at the end 
//   of each iteration. This means that the code block within the loop is guaranteed to execute at least once 
//   before checking the condition.
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrating a while loop,
            int index = 1;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }


            //Demonstrating a do while loop (this type of loop dosen't exist in Python),

            //You can see that even though the condition in the while statement in this do while loop is not met, 
            //the code inside the do statement is still run at least once, before the condition in the while
            //statement is checked (if the condition is true, then the code inside the do statement is looped, 
            //otherwise if the condition is immediately false, the program will then exit the do while loop, but
            //it ran the code inside the do statement at least once already).

            //-> This is proven by the printing of the '6' integer, since in a do while loop, the code inside the 
            //   while loop is ran first before checking the condition of the while statement (which will be false). 
            //-> If this do while loop is just a while loop, the '6' integer will not be printed since the condition 
            //   in the while statement is false, and that in a while loop the condition in the while statement is
            //   checked first (which will be false) before the code inside the while loop is ran
            int index2 = 6;

            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index2 <= 5);

            Console.ReadLine();
        }
    }   
}
