namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alphabet/Text related:
            string phrase = "Giraffe Academy";
            char character = 'C';           //must be ', not ". In C#, they are not interchangable unlike Python


            //Number related (numbers are classified into 2 types in C#, integer numbers and decimal numbers):

            //Integer number related:
            //There are 3 data types that can store integer numbers, 'short', 'int' and 'long' (in order of smallest 
            //number size range it can take, with 'short' up to 5 s.f., 'int' up to 9 s.f., 'long' up to 19 s.f.). 
            //But the most commonly used data type for integer numbers in C# is the 'int' data type

            //- The 'short' data type may sometimes be called 'Int16', which indicates it is using 16 bits (2 bytes)
            //  in memory to store a 'short' data type
            //- The 'int' data type may sometimes be called 'Int32', which indicates it is using 32 bits (4 bytes)
            //  in memory to store an 'int' data type
            //- The 'long' data type may sometimes be called 'Int64', which indicates it is using 64 bits (8 bytes)
            //  in memory to store a 'long' data type
            short short_number = 30000;
            int whole_number = 300000000;
            long long_number = 30000000000000;

            //Decimal number related:
            //There are 3 data types in C# that can store decimal numbers, 'float', 'double', 'decimal '
            //(in order of least precise to most precise data type, with 'float' up to 7 s.f., 'double' up to 
            //15-17 s.f. and 'decimal' up to 28-29 s.f.) But the most commonly used data type for decimal
            //numbers in C# is the 'double' data type

            //Whats with the additional alphabets, 'f', and 'm' behind for the 'float' and 'decimal' variables?
            //They are additional suffixes that you need to add in at the end of your 'float' and 'decimal' 
            //variables respectively to tell the C# compiler understand the data type you are using. The
            //'double' data type also have one, the 'd' suffix, though it is optional only for the 'double' data
            //type.
            double double_decimal_numer = 60.6;
            // double double_decimal_numer = 60.6d;
            float float_decimal_number = 60.6f;
            decimal decimal_decimal_number = 60.6m;


            //Boolean related (for Python the booleans need to have capital (e.g. True/False), for C# the 
            //booleans must not have capital (e.g. true/false)):
            bool is_male = true;
            bool is_female = false;


            Console.WriteLine(phrase);
            Console.WriteLine(character);

            Console.WriteLine(short_number);
            Console.WriteLine(whole_number);
            Console.WriteLine(long_number);

            Console.WriteLine(double_decimal_numer);
            Console.WriteLine(float_decimal_number);
            Console.WriteLine(decimal_decimal_number);

            Console.WriteLine(is_male);
            Console.WriteLine(is_female);  
            

            Console.ReadLine();
        }
    }
}
   
   