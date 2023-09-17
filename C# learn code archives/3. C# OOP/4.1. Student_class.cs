namespace Project
{
    class Student
    {
        //Attributes of the 'Student' Class
        public string name;
        public string major;
        public double gpa;


        //Constructor of the 'Student' Class
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        //Creating a Non-Static Method (aka an Instance Method) that checks if a particular 'Student' object 
        //has honours (a 'Student' will have honours if they have a GPA greater or equal to 3.5)
        public bool HasHonours()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }   
}

