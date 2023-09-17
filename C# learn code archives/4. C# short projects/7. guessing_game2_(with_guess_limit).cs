namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is my attempt at it and it works:
            // string word_to_guess = "giraffe";
            // int number_of_attempts_given = 6;
            // int attempts_counter = 1;

            // Console.WriteLine("Welcome to the Guess-The-Word game! The word to guess is an animal! You have 5 attempts!");

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
            //         attempts_counter++;
      
            //         if (attempts_counter > 5)
            //         {
            //             Console.WriteLine("You ran out of attempts! You lose!");
            //             break;
            //         }
      
            //         Console.WriteLine("That is incorrect, try again!");
            //         Console.WriteLine("You have " + (number_of_attempts_given - attempts_counter) + " attempts left!");
            //     }
            // }




            //Here is what the tutorial taught:
            string word_to_guess = "giraffe";
            string guessed_word = "";
            int guess_count = 0;
            int guess_limit = 3;
            bool out_of_guesses = false;

            Console.WriteLine("Welcome to the Guess-The-Word game! The word to guess is an animal!");

            //'!out_of_guesses' means 'not' 'out_of_guesses', since the '!' is the equivalent 'not'
            while (guessed_word != word_to_guess && !out_of_guesses)
            {
                if (guess_count < guess_limit)
                {
                    Console.Write("Please guess a word: ");
                    guessed_word = Console.ReadLine();
                    guess_count++;
                }
                else
                {
                    out_of_guesses = true;
                }
            }
            //This is the equivalent to 'out_of_guesses is true'/'out_of_guesses == true'
            if (out_of_guesses)
            {
                Console.WriteLine("You ran out of attempts! You lose!");
            }
            else
            {
                Console.WriteLine("You guessed the correct word! You win!");
            }

            Console.ReadLine();
        }   
    }   
}
