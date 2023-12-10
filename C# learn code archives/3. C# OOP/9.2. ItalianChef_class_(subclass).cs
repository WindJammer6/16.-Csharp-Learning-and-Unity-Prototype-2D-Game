//This file contains the 'ItalianChef' Class, the subclass of the 'Chef' Class superclass (see the
//'9.1. Chef_class_(superclass).cs' file)

namespace Project
{
    //This is how we 'inherit' all the attributes and methods from the 'Chef' Class superclass to the
    //'ItalianChef' Class subclass, via this line of code, 'class ItalianChef : Chef' 
    class ItalianChef : Chef
    {
        //After this 'ItalianChef' Cslass (subclass) 'inherits' from the 'Chef' Class (superclass), it 
        //now gains all the attributes and methods of the 'Chef' Class (superclass), without having to
        //re-write all the code of the methods in the 'Chef' Class (superclass)

            //Here are the 3 Non-Static (Instance methods) that the 'Chef' Class can use, representing the 3 types of
            //food (Chicken, Salad, and Special Dish) that a 'Checf' object/Class Instance can make
            // public void MakeChicken()
            // {
            //     Console.WriteLine("The Italian Chef makes Chicken");
            // }
            // public void MakeSalad()
            // {
            //     Console.WriteLine("The Italian Chef makes Salad");
            // }
            // public void MakeSpecialDish()
            // {
            //     Console.WriteLine("The Italian Chef makes BBQ ribs");
            // }



        //Here, we are creating a new Non-Static (Instance method) that is unique to the 'ItalianChef' 
        //Class (subclass) that does not exist in the 'Chef' Class (superclass)
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes Pasta");
        }



        //Here is the overriden 'MakeSpecialDish' Non-Static method (Instance method) 'inherited' from the
        //'Chef' Class (superclass). The differences is that instead of the 'virtual' modifier command,
        //we will use the 'override' modifier command in the 'ItalianChef' Class (subclass), and making the
        //desired changes in code to the same 'MakeSpecialDish' Non-Static method (Instance method) from the
        //'Chef' Class (superclass) in this 'ItalianChef' Class (subclass)
            // public virtual void MakeSpecialDish()
            // {
            //     Console.WriteLine("The Chef makes BBQ ribs");
            // }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Mushroom Soup");
        }
    }   
}