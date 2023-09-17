namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we are creating a 'Book' object in our main code. Note that in programming, an 'object' is an 
            //instance of a Class (something of that type Class)). In this case, an instance of the 'Book' 
            //class/'Book' object is being stored in the 'book1' variable
            Book book1 = new Book();
            //Defining the attributes of this 'Book' object
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.total_pages = 400;


            //Creating another 'Book' object, storing it in the 'book2' variable, and then defining the attributes 
            //for this other 'Book' object (that is being stored in the 'book2' variable) 
            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.total_pages = 600;


            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);


            Console.ReadLine();
        }   
    }   
}
