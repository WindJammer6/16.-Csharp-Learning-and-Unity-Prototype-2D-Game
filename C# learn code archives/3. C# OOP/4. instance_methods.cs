namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pan", "Arts", 3.6);

            Console.WriteLine(student1.major);
            Console.WriteLine(student2.gpa);

            //Running the Instance method on both 'student1' and 'student2' that checks if a 
            //particular 'Student' object has honours (a 'Student' will have honours if they 
            //have a GPA greater or equal to 3.5)
            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());

            Console.ReadLine();
        }   
    }   
}
