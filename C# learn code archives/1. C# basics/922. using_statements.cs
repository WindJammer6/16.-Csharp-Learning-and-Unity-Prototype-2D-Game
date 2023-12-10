// What does the 'using' statement do? (an example of Operator Overloading)
// The 'using' statement has 2 functionalities (an example of Operator Overloading):
// 1. The main functionality of the 'using' statement is to import existing external namespaces 
//    (not the same as libraries!) into your C# code such as 'Newtonsoft' and 'RestSharp' 
//    (basically the almost same concept as the 'import' statement in Python, though it is 
//    slightly different as it import external namespaces, rather than libraries, which are
//    different things, as explained in '920. namespace_statements.cs')
 
// 2. The other less common functionality of the 'using' statement is for resource management, 
//    particularly with objects such as files, database connections and network connections, 
//    that implement the 'IDisposable' interface. The 'using' statement ensures that the 
//    'Dispose' method of the object is called when the block is exited, providing a convenient 
//    way to release resources. Here is a sample code of the 'using' statement being used for
//    this functionality:
//       ```
//       using (FileStream fs = new FileStream("example.txt", FileMode.Open))
//       {
//           // Code to read from the file
//       }
//       ```


// Here, I am importing the 'MyLibrary' and 'ExternalLibrary' namespaces from another external
// file of the same folder/external namepsaces into my C# code (so in this sense, the 'using'
// statement works exactly the same as the 'import' statement in Python, except that it imports
// namespaces, rather than libraries),
using MyLibrary;
using ExternalLibrary;

// Alternatively, you can import a namespace within another namespace, also known as a
// sub-namespace by adding the '.' operator in between the namespace and sub-namespace like so,
using ExternalLibrary.UI;

// Also, if you happen to be importing 2 external namespaces with 2 seperate classes with the same name, like the
// 'ButtonClass' in this case, you can specify which external namespace to take the 'ButtonClass' from when the
// 'ButtonClass' class is called in your C# code by default (calling the 'ButtonClass' by default means like this:
// 'var my_button = new ButtonClass();') in your C# code with the 'using' statement, accompanied by the '='
// operator like so (in which I want to take the 'ButtonClass' from the 'MyLibrary' external namespace by default),

// (Note: You can technically will still be able to call the 'ButtonClass' from the other 'ExternalLibrary' 
// external namespace in your C# code, but you cannot do it by default like so: 'var my_button = new ButtonClass();'
// since it will then refer to the 'ButtonClass' from the 'MyLibrary' external namespace. Rather you can still call 
// it by calling it explicitly like this: 'var external_button = new ExternalLibrary.UI.ButtonClass();')
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

        // This line of code is commented out to show there is no need to specify the name of the 'MyLibrary'
        // Namespace when creating a class instance of the 'ButtonClass' due to the 'using' statement above,
        // 'using ButtonClass = MyLibrary.ButtonClass;'
        // var my_button = new MyLibrary.ButtonClass();
        var my_button = new ButtonClass();
        var external_button = new ExternalLibrary.UI.ButtonClass();
    }
}