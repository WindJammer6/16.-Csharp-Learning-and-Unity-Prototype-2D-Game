//Here is the basic C# code template, notice that there are a lot of commands that are
//foreign to us. In this file, we will be attempting to explain them.
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}



//Explanation for each command:
//-> 'namespace Project' represents a namespace called Project. A namespace is used to 
//   organize and group related types (classes, structs, enums, etc.) in C#. It helps avoid 
//   naming conflicts by providing a hierarchical structure for your code. In OOP, in order
//   to use a Class from a seperate file in the main program file, it must have the same 
//   namespace, 'Project' or else that Class from the seperate file will not be usable in
//   in the main program file. (more about 'namespaces' statements in the
//   '920. What_are_namespaces_in_C#_and_the_namespace_statements_and_using_statements.txt'
//   and '921. namespace_statements.cs' files)

//-> 'class Program' represents a Class called 'Program' in the 'Project' namespace (this
//   is basically how you create a Class in C# OOP). It is conventional to name the main
//   program's file's Class as 'Program'

//-> In the line of code, 'static void Main(string[] args)',
//   => 'static' represents that the 'Main' Special method (can google for the different kinds
//      of Special methods in C#) is a Static Method (see what are Static methods in 
//      '1. static_vs_non_static_methods_and_public_vs_private_methods.txt')

//   => 'void' represents that the function does not return anything/data types

//   => 'Main' represents the Special method in C# that indicates the entry point of a C# 
//      console application. It's where the program starts execution.

//   => '(string[] args)' represents the an 'array' containing strings parameter, stored in
//      the 'args' variable (the name, 'args' can be anything, but 'args' is the naming 
//      convention). We need this because when you run a C# program from the command line, you 
//      can actually provide additional information to the program by specifying command-line 
//      arguments, and this '(string[] args)' in the code itself allows you to do that. These 
//      arguments are passed to the program when it starts executing. For example, if you run 
//      your program like this,
//          'MyProgram.exe arg1 arg2 arg3'

//      Then, arg1, arg2, and arg3 are command-line arguments.