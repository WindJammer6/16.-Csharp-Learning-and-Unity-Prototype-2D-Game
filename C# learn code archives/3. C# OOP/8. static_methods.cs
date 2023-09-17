namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Notice that Static methods (or class variable in Python) are methods that belong to the Class, 
            //instead of an individual Class Instance. Hence, there is no need for us to create any Class 
            //Instances beforehand before having to use the Static method of a Class
            Song.SayHi();

            Console.ReadLine();
        }   
    }   
}
