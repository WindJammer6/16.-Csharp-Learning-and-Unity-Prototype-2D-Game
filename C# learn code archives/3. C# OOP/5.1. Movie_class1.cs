//This file shows the first step to solving the problem explained in 
//'5. public_vs_private_command.cs'/'6. getter_and_setter_properties.cs', which is,

    //1. We will need to first close off access of the 'Movie' Class' 'rating' attribute to external
    //   programs/files (from from the internal file, where the 'Movie' Class is created in the 
    //   '5.1. Movie_class.cs' file), but changing the 'rating' attribute of the 'Movie' Class in the 
    //   '5.1. Movie_class.cs' file from 'public' to 'private'
    //   (see '5. public_vs_private_command.cs' and '5.1. Movie_class1.cs')

namespace Project1
{
    class Movie
    {
        //Attributes of the 'Movie' Class
        public string title;
        public string director;

        //Changing the 'rating' attribute of the 'Movie' Class from 'public' to 'private'
        // public string rating;
        private string rating;


        //Constructor of the 'Movie' Class
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }
    }
}