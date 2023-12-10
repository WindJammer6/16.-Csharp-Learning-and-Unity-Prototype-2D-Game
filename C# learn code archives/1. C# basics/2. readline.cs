namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //'Console.ReadLine' function keeps that pop-up console/window open when
            //a console is opened by any previous functions, such as the 'Console.WriteLine'
            //function. You can close that pop-up console/window by enetering any input like
            //a spacebar or anything else (for some reason in VScode, only the 'enter' key 
            //works for me...)

            //'Console.ReadLine()' in reality does more than this, which we will explore in the 
            //'8. get_user_input.cs file'
            Console.ReadLine();
        }
    }
}
   
   