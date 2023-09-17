namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notice that after creating our Constructor (aka the '__init__' special method in Python) in the other 
            //file 'Book_class2.cs', we are able to create the 'Book' object (Class Instance) much more easily and
            //efficiently, in one line of code, instead of 4 lines of code
            // Book book1 = new Book();
            // book1.title = "Harry Potter";
            // book1.author = "JK Rowling";
            // book1.total_pages = 400;

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            // Book book2 = new Book();
            // book2.title = "Lord of the Rings";
            // book2.author = "Tolkein";
            // book2.total_pages = 600;

            Book book2 = new Book("Lord of the Rings", "Tolkein", 600);


            //You can also update an attribute of the 'Book' object (Class Instance) manually as well later in the 
            //code if you want like so, changing the 'title' attribute of the 'Book' object stored in the 'book2' 
            //variable from "Lord of the Rings" to "The Hobbit"
            book2.title = "The Hobbit";
            

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);

            Console.ReadLine();
        }   
    }   
}
