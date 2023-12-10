// What are Namespaces, and what does the 'namespace' statement do?
// Namespaces is an unheard of term in Python that is native to C#, and is not available in Python. To answer this 
// question, we need to fully understand what are Namespaces as an in-built component in C#.

// Namespaces are a set of "bundled classes" in C#. You can declare a namespace of your own in your C# code, using 
// the 'namespace' statement like so,
//     ```
//     namespace MyNamespace
//     {

//     }
//     ```

// You can also declare sub-namespaces by using a 'namespace' statement within another 'namespace' statement like so,
//     ```
//     namespace MyNamespace
//     {
//         namespace MySubNamespace
//         {

//         }
//     }
//     ```

// Note: It must be made clear that namespace are not full libraries/frameworks that you import directly via the 
//       'import' statement in Python (such as 'numpy', 'matplotlib', 'panda', 'scikit learn', etc.), even though 
//       namespaces and libraries/frameworks are similar in the sense that they are a group of code that you can 
//       import into your code. 

//       They are different as a single libraries/frameworks are usually complete groups of code, and bigger, while 
//       namespaces are sometimes incomplete groups of code, and smaller, and may often require you to import multiple 
//       namespaces to have the complete functionality for your programming project while for libraries/frameworks you 
//       just need to import one of them (since they are complete on their own). For example,
//           ```
//           using Newtonsoft.Json;
//           using RestSharp;
//           ```

//       These 2 namespaces usually come as a pair when you are working on a project or part of a codebase that 
//       involves making HTTP requests (e.g., RESTful API calls) and handling JSON data. As you might use 
//       'Newtonsoft.Json' to serialize your objects into JSON before sending them as part of an API request using 
//       'RestSharp'. Similarly, you could use 'Newtonsoft.Json' to deserialize the JSON response received from an API
//       call made with 'RestSharp'.

using MyLibrary;
using ExternalLibrary;
using ExternalLibrary.UI;
using ButtonClass = MyLibrary.ButtonClass;


//////////////////////////////////////////////////////////////////////////////////


// Lets assume that these 2 namespaces are in 2 seperate other files from our C# code,

// The main namespace
namespace ExternalLibrary
{
    // The sub-namespace within the 'ExternalLibrary' namespace
    namespace UI
    {
        public class ButtonClass
        {
            
        }
    }
}

// The main namespace
namespace MyLibrary
{
    public class ButtonClass
    {

    }
}


///////////////////////////////////////////////////////////////////////////////


class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, World!");

        var my_button = new MyLibrary.ButtonClass();
        var external_button = new ExternalLibrary.ButtonClass();
    }
}