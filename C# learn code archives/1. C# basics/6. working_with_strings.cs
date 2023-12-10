namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //In C# there is also the '\n' command, which tells the compiler to go to the next line in the 
            //output
            Console.WriteLine("Giraffe\nAcademy");
            //If you want to add certain special characters such as " and ' within a string to be printed out instead
            //of treating it as a command to end the string, you can just add the backslash (\) in front of them to
            //tell the compiler to treat them as part of the string to be printed out instead of as a command
            Console.WriteLine("Giraffe\"Academy");


            //The 'string phrase = "Giraffe Academy" + " is cool";' wont work since below if we want to restate 
            //the string data being stored inside the same 'phrase' variable we can  have to do this instead for 
            //it to work
            string phrase;
            //Concatenation of 2 seperate strings via the '+' operator
            phrase = "Giraffe Academy" + " is cool";
            Console.WriteLine("The " + phrase);


            //To get length of string
            phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Length);

            //To make all the characters in the string uppercase/lowercase
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());

            //The 'Contains()' function in C# is the equivalent to the 'in' operator in Python, which finds a 
            //substring/character in a string/an element in a list
            Console.WriteLine(phrase.Contains("Acad"));     //ouput -> True
            Console.WriteLine(phrase.Contains("Dog"));      //output -> False

            //Strings are basically a list/array of characters. In C# you can access individual characters/elements 
            //in a string via indexing, similar to Python
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase[5]);

            //This is the equivalent to 'phrase[0:5]' (list indexing) in Python, since C# dosen't support the exact 
            //this list indexing method naming
            Console.WriteLine(phrase.Substring(0, 5));

            //The 'IndexOf()' function in C# is equivalent to the 'index()' function in Python, which returns the 
            //index of the element/first element of a substring being passed through its parameter
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf("f"));
            //If the element not present in the 'phrase' string is passed through its parameter, the 'IndexOf' 
            //function will retrun -1 to indicate a false result
            Console.WriteLine(phrase.IndexOf("z"));

            Console.ReadLine();
        }
    }
}