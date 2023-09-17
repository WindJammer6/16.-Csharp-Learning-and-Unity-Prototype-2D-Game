namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic mathematical operator symbols, all of which are exactly the same as those in Python
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 / 8);
            Console.WriteLine(5 * 8);
            //The Modulus operator, which returns the remainder of the division of the numbers as the ouput (e.g. 5
            //divided by 2 will give you 1 as a remainder, hence 5 % 2 will give you an output of 1)
            Console.WriteLine(5 % 2);


            //Order of operations and the usage of parenthesis to affect the order of operations
            Console.WriteLine(4 + 2 * 3);       //output -> 10, since youll run multiplication before addition
            Console.WriteLine((4 + 2) * 3);     //output -> 18, since using parenthesis tells the program to 
                                                //run whatever the operation is within the parenthesis as priority
                                                //even though it might not be the priority when without the 
                                                //parenthesis

            
            //Doing mathematical equations with whole numbers (ints) and decimal numbers (mainly doubles (floats and
            //decimals))

            //Numbers are classified into 2 types in C#, whole numbers (ints) and decimal numbers (mainly doubles 
            //(floats and decimals)). 
            
            //When all the numbers in your mathematical equations are integers, youll get an integer back, 
            //regardless if the result is supposed to have a decimal number or not. For example, '5 / 2' by right 
            //should return 2.5. But since both 5 and 2 are ints, the result will be an int, which the compiler 
            //will return 2 (rounded down to the nearest whole number (int), similar to how the '//' operator in 
            //Python)
            Console.WriteLine(5 / 2);

            //However, when all the numbers in your mathematical equations are decimal numbers, or if you have a
            //combination of integers and decimal numbers, 
            //-> if your answer happens to be a whole number, youll just get an integer back instead of a decimal 
            //   number with a '.0' behind. For example, in '5.0 / 2.5' , all the numbers are decimal numbers, but 
            //   since the result should be 2, we got the number 2 as an integer back instead of '2.0', in decimal 
            //   number
            Console.WriteLine(5 / 2.5);
            //-> if your answer has decimal numbers, youll get a decimal number back as expected. (see examples
            //   below)
            Console.WriteLine(5.0 / 2);
            Console.WriteLine(5.0 / 2.0);


            int number = 6;
            number++;                       //Or 'number += 1;' works too in C# like how you would do it in Python
                                            //to increment the integer variable 'number' by 1
            Console.WriteLine(number);

            number--;
            Console.WriteLine(number);      //Or 'number -= 1;' works too in C# like how you would do it in Python
                                            //to decrement the integer variable 'number' by 1



            //More mathematical operations using the 'Math' in-built library in C# (hence there is no need to import 
            //it before using it at the top of the code)
            
            //The 'Abs' in 'Math.Abs()' represents absolute value
            Console.WriteLine(Math.Abs(-40));
            //The 'Pow' in 'Math.Pow()' represents power (first argument is the number you want to get the power of
            //and the second argument is the number of the power)
            Console.WriteLine(Math.Pow(3, 2));
            //The 'Sqrt' in 'Math.Sqrt()' represents square root
            Console.WriteLine(Math.Sqrt(9));
            //The 'Max' in 'Math.Max()' represents maximum value (the 2 arguments are the 2 numbers, which you want
            //to find which is the maximum/largest value)
            Console.WriteLine(Math.Max(4, 90));
            //The 'Min' in 'Math.Min()' represents minimum value (the 2 arguments are the 2 numbers, which you want
            //to find which is the minimum/smallest value)
            Console.WriteLine(Math.Min(4, 90));
            //The 'Round' in 'Math.Round()' represents rounding up of the number you put as its argument/parameter,
            //which is following the standard rounding numbers rules, where the numbers with decimal place '<= 0.5'
            //will be rounded down while the numbers with decimal place '> 4.5' are rounded up
            Console.WriteLine(Math.Round(4.4));
            Console.WriteLine(Math.Round(4.5));            
            Console.WriteLine(Math.Round(4.51));

            Console.ReadLine();
        }
    }
}
   