namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Holiday", "Green Day", 200);

            //This is how we access the 'static variable' of the 'Song' Class by default. Notice 
            //that we accessed the 'static variable', 'song_count', via the 'Song' Class, rather 
            //than the individual Class Instances, 'song1' and 'song2' since 'static variables' 
            //are attributes about the 'Song' Class, and not about the individual 'Song' 
            //objects/Class Instances.
            Console.WriteLine(Song.song_count);
            Song song2 = new Song("Kashmir", "Led Zepplin", 150);
            Console.WriteLine(song1.GetSongCount());     //see explanation for this in the '7.1. Song_class.cs' file

            
            Console.WriteLine(song1.title);
            Console.WriteLine(song2.title);

            Console.ReadLine();
        }   
    }   
}
