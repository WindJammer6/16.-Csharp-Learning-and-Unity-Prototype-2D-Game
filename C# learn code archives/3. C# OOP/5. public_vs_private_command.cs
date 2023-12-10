//Lets say we have this program that creates a 'Movie' object (the 'Movie' Class is created in the
//'5.1 Movie_class.cs' file)

//There is a problem here, which is that we want all our 'Movie' objects' (or Class Instance)
//'rating' attribute to only be 'G', 'PG', 'PG-13', 'R' or 'NR', and not anything else. However, in
//the code below, we accidentally created a 'Movie' object with a 'rating' attribute, 'Dog', which
//does not make any sense, but it works.

//So what can we do to somehow allow the program to detect an unexpected 'rating' attribute input
//during the creation of a 'Movie' object, and maybe just let it be 'NR' (not rated) as a 
//placeholder in the event of unexpected 'rating' attribute inputs?


////////////////////////////////////////////////////////


//The answer to this is broken into 2 steps:
//1. We will need to first close off access of the 'Movie' Class' 'rating' attribute to external
//   programs/files (from from the internal file, where the 'Movie' Class is created in the 
//   '5.1 Movie_class.cs' file), but changing the 'rating' attribute of the 'Movie' Class in the 
//   '5.1 Movie_class.cs' file from 'public' to 'private'
//   (see '5. public_vs_private_command.cs' and '5.1. Movie_class1.cs')

//2. Because we closed off access of the 'Movie' Class' 'rating' attribute to external programs/files, 
//   in order to be able to re-give access while putting in place restrictions to how the 'rating' 
//   attribute can be defined/accessed by external programs/files from outside the 'Movie' Class, we
//   will need to the create getters and setters properties
//   (see '6. getter_and_setter_properties.cs' and '6.1. Movie_class2.cs')

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "Cat");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

            //Notice that after changing the 'rating' attribute of the 'Movie' Class from 'public' to 
            //'private' in the '5.1. Movie_class.cs1' file, we are getting an error in this line of code
            //(with red squiggly lines under the 'rating' attribute)
            movie1.rating = "Dog";

            Console.WriteLine(movie1.title);
            //Notice that after changing the 'rating' attribute of the 'Movie' Class from 'public' to 
            //'private' in the '5.1. Movie_class.cs1' file, we are getting an error in this line of code
            //(with red squiggly lines under the 'rating' attribute)
            Console.WriteLine(movie1.rating);

            Console.ReadLine();
        }   
    }   
}
