namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is my attempt at it and it works:
            // string word_to_guess = "giraffe";

            // Console.WriteLine("Welcome to the Guess-The-Word game! The word to guess is an animal!");

            // while (true)
            // {
            //     Console.Write("Please guess a word: ");
            //     string guessed_word = Console.ReadLine();

            //     if (guessed_word == word_to_guess)
            //     {
            //         Console.WriteLine("You guessed the correct word! You win!");
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine("That is incorrect, try again!");
            //     }
            // }




            //Here is what the tutorial taught, which has neater code than my attempt:
            string word_to_guess = "giraffe";
            string guessed_word = "";

            Console.WriteLine("Welcome to the Guess-The-Word game! The word to guess is an animal!");

            while (guessed_word != word_to_guess)
            {
                Console.Write("Please guess a word: ");
                guessed_word = Console.ReadLine();
            }
            Console.WriteLine("You guessed the correct word! You win!");

            Console.ReadLine();


            //Creating this guessing game using a do while loop
            // string word_to_guess = "giraffe";
            // string guessed_word = "";

            // Console.WriteLine("Welcome to the Guess-The-Word game! The word to guess is an animal!");

            // do
            // {
            //     Console.Write("Please guess a word: ");
            //     guessed_word = Console.ReadLine();
            // }
            // while (guessed_word != word_to_guess);
            
            // Console.WriteLine("You guessed the correct word! You win!");

            // Console.ReadLine();
        }
    }   
}