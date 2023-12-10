//In this file, we will only cover how to get user input as strings, this may not work if you want to
//take the user input as other data types such as integers/floats/doubles/decimals. We will be exploring
//taking user input as other data types such as integers/floats/doubles/decimals in the
//'1. calculator.cs' file in the 'C# short projects' folder

//The first problem we need to overcome if we want to build a calculator in C# is that we need
//to be able to convert the string user input into an integer/float/double/decimal after we
//use 'Console.ReadLine' to take the user input as a string

//(We never had this problem to manipulate the data type of our data in our variables in Python 
//since Python automates this for us by sort of 'autodetecting' the data type of the data in our 
//variables)
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lets say we have a string, "54", which is a number as the string data type. If you
            //try to store this "54" data in an integer 'number' variable like so,
                //int number = "54";
            
            //you'll get an error since "54" is a string, not an integer, and cannot be stored in
            //the integer 'number' variable 

            //To convert a data from one data type to another, we will need to use the built-in
            //'Convert' library in C#, and specify the data type you want to convert your data to
            //after the 'Convert.', which we will want it as an integer, so we will use 'ToInt32' 
            //(or the 'int' data type, recall that 'ToInt16' is for the 'short' data type and 'ToInt64'
            //is for the 'long' data type) (see the '5. data_types.cs' file in the 'C# basics' folder)

            //After this, the data is now not a string ("54"), but an integer (54) instead, and can
            //be stored in the integer 'number' variable
            int number = Convert.ToInt32("54");
            
            //We can now see that it behaves in like an (integer) number instead of a string
            Console.WriteLine(number + 6);              //output -> 60


            //(Note: If we did 'Console.WriteLine("54" + "6");' we will just end up concatnating the 2 
            //strings with output as "546", and if we did 'Console.WriteLine("54" + 6);' we will get an 
            //error since "54" (string) and 6 (int) are 2 different data types)

            Console.ReadLine();
        }
    }
}
   
   