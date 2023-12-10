//In this file, we will learn more about if else statements, more specifically on using
//comparison operators such as, '>', '<', '>=', '<=', '!=', '=='
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(20, 21, 20));
            Console.ReadLine();
        }   

        static int GetMax(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
