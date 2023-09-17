namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is how you represent 2D Arrays, Arrays within an Array, in a sort of matrix-like
            //structure, via the extra comma in the square brackets, '[,]'

            //If you want your Array to have more dimensions (e.g. 3D, 4D, etc.), you just need to 
            //add more commas iinside the square brackets (e.g. '[,,]' for 3D Arrays, '[,,,]' for 4D 
            //Arrays, etc.)
            int[,] two_dimensional_array = {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            //This is how you access any particular element in the 2D Array

            //In this example, '[1, 1]' means the element in the second ('1' index) row (Array), 
            //and second ('1' index') column (the second element in that Array)
            Console.WriteLine(two_dimensional_array[1, 1]);



            //If you do not know what elements you want to put in your 2D Array (or even higher 
            //dimensional Arrays), you can first initiate your 2D Array by stating it as,
            
                //'new int[2, 3]'

            //where '2' is the number of rows (Arrays) it will contain and '3' is the number of
            //columns (number of elements in each inner Array) it will contain
            int [,] two_dimenional_array_with_unknown_elements = new int[2, 3];

            //Manually inserting all the elements into the 2D Array
            two_dimenional_array_with_unknown_elements[0, 0] = 1;
            two_dimenional_array_with_unknown_elements[0, 1] = 2;
            two_dimenional_array_with_unknown_elements[0, 2] = 3;
            two_dimenional_array_with_unknown_elements[1, 0] = 4;
            two_dimenional_array_with_unknown_elements[1, 1] = 5;
            two_dimenional_array_with_unknown_elements[1, 2] = 6;

            //Printing all the elements in the 2D Array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(two_dimenional_array_with_unknown_elements[i, j] + " ");
                }
                Console.WriteLine("\n");
            }


            Console.ReadLine();
        }   
    }   
}