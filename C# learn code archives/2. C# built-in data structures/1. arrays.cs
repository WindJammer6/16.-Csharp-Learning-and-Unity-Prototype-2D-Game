//What are Arrays in C#?
//In C#, Arrays are fixed-size collections of elements of the same data type (homogeneous).

//In this tutorial we will only explore the built-in Array Data Structure, 'Array', in C#,
//there are other built-in Array Data Structures in C# such as Lists, Sets and Tuples, which
//we will explore in the future.


/////////////////////////////////////////////////


//Background info of the built-in Array Data Structures, Arrays (has the same name), Lists, Sets 
//and Tuples, in C#:

//In Python, there are 3 built-in Array Data Structure, Lists, Sets and Tuples,
//-> Lists are Dynamic/Mutable, items in a List can be replaced or changed, allows duplicates
//   and allows indexing/slicing / is an Ordered collection of items
//-> Sets are Dynamic/Mutable, items in a Set cannot be replaced or changed, dosen't allow 
//   duplicates and dosen't allow indexing/slicing / is an Unordered collection of items
//-> Tuples are Static/Immutable, items in a Tuple cannot be replaced or changed, allows duplicates
//   and allows indexing/slicing / is an Ordered collection of items

//In C#, there are 4 built-in Array Data Structure, Arrays (has the same name), Lists, Sets and 
//Tuples,
//-> Arrays are Static/Immutable, items in an Array can be replaced or changed, allows duplicates 
//   and allows indexing/slicing / is an Ordered collection of items.
//-> Lists (List<T>) are Dynamic/Mutable, items in a List can be replaced or changed. allows 
//   duplicates, allows indexing/slicing / is an Ordered collection of items.
//-> Sets (HashSet<T> or SortedSet<T>) are Dynamic/Mutable, items in a Set cannot be replaced or 
//   changed, dosen't allow duplicates and dosen't allow indexing/slicing / is an Unordered 
//   collection of items
//-> Tuples are Static/Immutable, items in a Tuple cannot be replaced or changed, allows duplicates
//   and allows indexing/slicing / is an Ordered collection of items


namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is how you represent an Array in C#, 
            //-> with the 'int' data type indicating the data type of the elements that the 
            //   Array Data Structure will be holding
            //-> the square brackets, '[]' represents that the 'number_list' variable is 
            //   going to be storing an Array Data Structure
            //-> then you will add the elements you want to put in the Array Data Structure 
            //   in the curly brackets, '{}'

            //Note that Arrays in C# are a collection of homogeneous elements (of the same 
            //data type) hence all the elements in an Array in C# must be of the same data
            //type, and cannot hold multiple data types

            //Creating an Array holding 'int' elements
            int[] number_list = {4, 8, 15, 16, 23, 42};

            Console.WriteLine(number_list[0]);
            Console.WriteLine(number_list[2]);



            //Here is another way of creating an Array, by first initialising the empty Array, 
            //-> indicating the data type of the elements it will be holding ('string'),
            //-> with the 'new' function indicating that this is a newly initialised Array
            //   Data Structure
            //-> the number (5) inside the square brackets of 'string[5]' indicating the
            //   length/number of elements that this Array is going to be able to hold.
            //   The need to specify the length of the Array is due to Arrays in C# being
            //   fixed-size collections of homogeneous elements and you need to pre-set its
            //   size when you initialise an Array.

            //   (if you add more elements than the Array can hold, e.g. adding an 
            //   element to the '5th' index position in the Array, then you'll get an error)

            //Creating an Array holding 'string' elements, and adding the individual elements 
            //to their index in the Array as shown below
            string[] string_list = new string[5];
            string_list[0] = "Jim";
            string_list[1] = "Kelly";



            //Apparently the only way to print the full Array Data Structure is by running
            //a for loop through all the elements in the Array Data Structure and printing
            //each element individually (which we will see later file in the tutorial)
            
            //This will only print out a textual representation of the 'Array' object, 
            //instead of the Array Data Structure itself, similar to how only the textual
            //representation of object classes in Python will end up being printed out if 
            //you only do 'print' on those object classes in Python
            Console.WriteLine(number_list);

            Console.ReadLine();
        }
    }
}
   
   