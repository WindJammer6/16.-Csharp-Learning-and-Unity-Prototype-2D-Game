namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //The variables 'character_name' and 'character_age',
            string character_name = "John";

            //Another way of creating a variable in C#,
            //This line of code declares that there will the variable, 'character_age'
            int character_age;
            //This line of code assigns that variable, 'character_age', a data
            character_age = 35;


            Console.WriteLine("There once was a an named " + character_name);
            Console.WriteLine("He was " + character_age + " years old");

            //Changing the data that is stored in the variable 'character_name' from "John" to
            //"Mike" 
            character_name = "Mike";
            character_age = 25;
            Console.WriteLine("He really liked the name " + character_name);
            Console.WriteLine("But didn't like being " + character_age);



            //Side note, C# supports this way of printing variables within strings of texts as well
            //similar to how it is done in Python
             Console.WriteLine($"But didn't like being {character_age}");



            Console.ReadLine();
        }
    }
}
   
   