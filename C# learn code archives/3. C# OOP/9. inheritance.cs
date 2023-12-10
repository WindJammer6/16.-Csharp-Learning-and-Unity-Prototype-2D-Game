//In this file, we will learn about the concept of Inheritance in C# OOP.

//Important terminology relating to the concept of Inheritance in C# OOP:
//-> 'superclass' represents a class that is higher in the class hierarchy and serves as the 
//   "parent" or "base" class. It is a class that defines common attributes (fields) and behaviors 
//   (methods) that are shared by one or more subclasses. The superclass provides a blueprint for 
//   creating related subclasses with shared characteristics.

//-> 'subclass' represents a class that inherits attributes and behaviors from a superclass. It is 
//   also called a "derived" or "child" class because it derives its properties and methods from a 
//   superclass. Subclasses can extend the superclass by adding their own attributes and behaviors 
//   or by modifying the behavior of inherited methods. Inheritance allows for code reuse, 
//   specialization, and the creation of more specific classes based on a common foundation.

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here, we can observe that after the 'ItalianChef' Class (subclass) 'inherits' all the 
            //attributes of the 'Chef' Class (superclass), the 'ItalianChef' object/Class Instance can 
            //also use the same methods as the 'Chef' object/Class Instance
            Chef chef1 = new Chef();
            chef1.MakeChicken();

            ItalianChef italianchef1 = new ItalianChef();
            italianchef1.MakeChicken();



            //The 'MakePasta' Non-Static method (Instance method) is a Non-Static method (Instance 
            //method) that only exists in the 'ItalianChef' Class (subclass) and not in the 'Chef' 
            //Class (superclass)

            //So, when we try to use the 'MakePasta' Non-Static method (Instance method) on both 
            //the 'Chef' Class (superclass) and the 'ItalianChef' Class (subclass), it will give us an
            //error when we try to use the 'MakePasta' Non-Static method (Instance method) on the 
            //'Chef' object/Class Instance, but not the 'ItalianChef' object/Class Instance
            Chef chef2 = new Chef();
            // chef2.MakePasta();           //there will be an error here

            ItalianChef italianchef2 = new ItalianChef();
            italianchef2.MakePasta();       //there will not be any error here




            //Now, lets say we want the 'ItalianChef' Class (subclass) to have a different 'Special Dish'
            //from the 'Chef' Class (superclass), and do something else (create another food item, say 
            //'mushroom soup' instead of the 'BBQ ribs' 'Special Dish' of the 'Chef' Class (superclass)) 
            //despite calling the same 'MakeSpecialDish' Non-Static method (Instance method).

            //The way we can do this is to,
            //1. add the modifier command, 'virtual' to the 'MakeSpecialDish' Non-Static method (Instance 
            //   method) inside of the 'Chef' Class (superclass) (see the '9.1. Chef_class_(superclass).cs' 
            //   file) 
            //2. and then copy-pasting the same 'MakeSpecialDish' Non-Static method (Instance method) into 
            //   the 'ItalianChef' Class (subclass), but changing the 'virtual' modifier command to the 
            //   'override' modifier command, and making the desired changes in code to the same 
            //   'MakeSpecialDish' Non-Static method (Instance method) in the 'ItalianChef' Class (subclass) 
            //   (see the '9.2. ItalianChef_class_(subclass).cs' file)
            Chef chef3 = new Chef();
            chef3.MakeSpecialDish();

            ItalianChef italianchef3 = new ItalianChef();
            italianchef3.MakeSpecialDish();

            Console.ReadLine();
        }   
    }   
}
