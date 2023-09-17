//This file contains the 'Chef' Class, the superclass of the 'ItalianChef' Class subclass (see the
//'9.2. ItalianChef_class_(subclass).cs' file)

namespace Project
{
    class Chef
    {
        //Here are the 3 Non-Static (Instance methods) that the 'Chef' Class can use, representing the 3 types of
        //food (Chicken, Salad, and Special Dish) that a 'Checf' object/Class Instance can make
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }
        
        //Here is the 'MakeSpecialDish' Non-Static method (Instance method) in the 'Chef' Class (superclass).
        //If we want to allow derived/subclasses ('ItalianChef' Class) of this 'Chef' class (superclass) to be
        //able to make modifications to this same 'MakeSpecialDish' Non-Static method (Instance method), we will
        //need to add an additional 'virtual' modifier command
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ ribs");
        }
    }   
}