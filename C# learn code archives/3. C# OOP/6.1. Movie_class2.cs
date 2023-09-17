//This file shows the second step to solving the problem explained in 
//'5. public_vs_private_command.cs'/'6. getter_and_setter_properties.cs', which is,

    //2. Because we closed off access of the 'Movie' Class' 'rating' attribute to external programs/files, 
    //   in order to be able to re-give access while putting in place restrictions to how the 'rating' 
    //   attribute can be defined/accessed by external programs/files from outside the 'Movie' Class, we
    //   will need to the create getters and setters properties
    //   (see '6. getter_and_setter_properties.cs' and '6.1. Movie_class2.cs')

namespace Project
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
            // rating = aRating; (explanation to why we need to do this in the getter property code below)
            Rating = aRating;           
        }



        //This is how you create the getter ('get') and setter ('set') properties in C# (note that the getter 
        //'get' and setter 'set' are not Special methods, but are properties instead, even though they may look 
        //similar)

        //-> 'Rating' represents the overall name of the getter and setter properties

        //(Note that we usually will use getter and setter properties for a particular Class property that we set to
        //'private' instead of 'public')
        public string Rating
        {
            //The getter 'get' property. The getter is a method-like block of code that defines how the value of a 
            //attribute/field is retrieved (read).
            get 
            {
                //It retrieves the provided 'rating' attribute of the 'Movie' Class from the external program/file.
                //This could occur in 2 ways, 
                //1. When the 'rating' attribute of a 'Movie' object/Class Instance is set manually, 
                //   (e.g. 'movie1.Rating = "Dog";')
                //2. When a 'Movie' object/Class Instance is created via the Constructor. However, you will need to
                //   make a change in the Constructor for the 'rating' attribute from,

                //      'rating = aRating' to 'Rating = aRating' (see above in the Constructor's code)

                //  while taking note that 'Rating' represents the name of the overall name of the getter and setter 
                //  properties 
                return rating;
            }
            //The setter 'set' property. The setter is a method-like block of code that defines how the value of a 
            //attribute/field is assigned or modified, and re-assigns the attribute/field the desired data.
            set
            {
                //'value' is a command that exists within the setter ('set') property that represents whatever input 
                //was given as the 'rating' attribute of the 'Movie' Class from the external program/file
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }   
}
