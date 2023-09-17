namespace Project
{
    class Song
    {
        //Attributes of the 'Song' Class
        public string title;
        public string artist;
        public int duration;

        //This is a 'static variable' (which is the equivalent to a 'class variable' in Python, since 
        //in C#, Static methods and Class methods are effectively the same thing, while in Python they
        //are different)(see the '1. static_vs_non_static_methods_and_public_vs_private_methods.txt' file)

        //A 'static variable' (or class variable in Python) is an attribute about the Class, and is the 
        //same/shared between all the 'Song' objects/Class Instances (since they are all of the same 
        //'Song' Class)
        
        //The 'static variable' (or class variable in Python) is unlike the normal attributes as it is 
        //not unique between the 'Song' objects/Class Instances, since it is an attribute about the Class,
        //not on the Class Instances
        public static int song_count = 0;



        //Constructor of the 'Song' Class

        //To demonstrate how the 'static variable' does, we will incremenet the 'song_count' 'static variable'
        //everytime this Constructor is run, which will run everytime a 'Song' object/Class Instance is 
        //created in the external/main program/file
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;   
            song_count++;        
        }



        //This Non-Static (Instance) method allows you to retrieve the 'song_count' 'static variable from a 
        //'Song' object/Class Instance in the external/main program/file instead of from the 'Song' Class only
        public int GetSongCount()
        {
            return song_count;
        }
    }   
}