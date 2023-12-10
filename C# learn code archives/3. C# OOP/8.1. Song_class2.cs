namespace Project
{
    //Side note, if you create a Class with the 'static' command, you will not be able to create any Class
    //Instances with it. This is a Static Class, a special type of class that cannot be instantiated, and
    //requires all its members (methods, fields, properties) must be static as well. Here is how you create 
    //a Static Class.
        // static class Song

    class Song
    {
        //Attributes of the 'Song' Class
        public string title;
        public string artist;
        public int duration;


        //Constructor of the 'Song' Class
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;   
        }


        //Creating a Static Method (or class method in Python) that just prints 'Hello'

        //To do this, we simply just need to specify that this method is static via the 'static' command.
        public static void SayHi()
        {
            Console.WriteLine("Hello");
        }
    }   
}