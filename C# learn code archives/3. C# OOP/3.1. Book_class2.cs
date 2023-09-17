namespace Project
{
    class Book
    {
        //Attributes of the 'Book' Class
        public string title;
        public string author;
        public int total_pages;

        //Here, we are creating a Constructor, which is aka the equivalent to how the '__init__' special method
        //works in Python. We create a Constructor in C# by naming the method as the same name as the Class (which
        //is the 'Book' Class in this case)

        //A Constructor is a special method within a Class (similarly to the 'Main' special method) that is 
        //automatically called when an object of the Class is created or instantiated, and it makes creating an 
        //instance of a Class much easier/efficiently (see in the main code file 
        //'2. using_a_constructor_to_create_a_Class_Instance')

        //This is the naming convention of the Constructor's arguments, all with a letter 'a' in front, and a capital 
        //first letter for subsequent words
        public Book(string aTitle, string aAuthor, int aTotal_Pages)
        {
            title = aTitle;
            author = aAuthor;
            total_pages = aTotal_Pages;
        }



        //Note that you can actually have multiple Constructors inside of a Class in C#, and in doing so, you are
        //actually doing Constructor Overloading. What this means is that you can actually create in your 'Book'
        //object/Class instances in various states (see below to see what it means)

        //Note that this is how you create your 'Book' object/Class instances in the main code,

            //'Book book1 = new Book("Harry Potter", "JK Rowling", 400);'

        //If you create your 'Book' object/Class instance with 3 arguments (with the 'title' of the 'Book' object
        //as an 'int' integer data type), the Class will use this Constructor to create the 'Book' object/Class 
        //instance
        public Book(int aTitle, string aAuthor, int aTotal_Pages)
        {

        }
        //If you create your 'Book' object/Class instance with 2 arguments (with the 'title' of the 'Book' object
        //as a 'string' data type), the Class will use this Constructor to create the 'Book' object/Class 
        //instance
        public Book(string aTitle, string aAuthor)
        {

        }
        //If you create your 'Book' object/Class instance with 0 arguments, the Class will use this Constructor to 
        //create the 'Book' object/Class instance
        public Book()
        {

        }

    }
}
