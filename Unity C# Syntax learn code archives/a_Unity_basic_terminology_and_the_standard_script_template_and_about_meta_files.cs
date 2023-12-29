// What is Unity(C#)?

// Unity(C#) is a game engine software that allows you to develop video games.


///////////////////////////////////////////////////////////////////////////////////////


// Here are some important terminology you need to know when using the Unity(C#) software:
// 1. Game Object: The fundamental object in Unity's scene, representing characters, props, cameras, lights, and 
//    more.

// 2. GameObject Components: A reusable piece of functionality that can be attached to a Game Object. 
//    (Note that there are components/classes in Unity(C#) that are not necessarily required to be attached
//    to a GameObject such as 'Time', 'Input' and 'KeyCode')
//    e.g. 
//         a. C# Scripts
//           -> C# scripts can be attached to Game Objects to define their behavior. You write scripts to control 
//              the functionality of your game. 
//              (Code functions on this component in a C# Script: NIL)

//         b. Colliders 
//           -> Colliders defines the shape of a Game Object's hitbox for collision detection. You can set
//              these Colliders as a Trigger.
//              (Code functions on this component in a C# Script: Via Physics Events functions 'OnCollisionEnter',
//               'OnCollisionStay', 'OnCollisionExit', and you can access this component of the Game Object via
//               '.GetComponent<Collider>()', and use the available functions and properties within it such as 
//               '.GetComponent<Collider>().isTrigger' (for the 'Trigger' property) (see Unity(C#) documentation for 
//               the other functions and properties available in the Collider component))
//              -> Trigger is a property of the Collider component used to detect when other Game Objects enter or 
//                 exit a specific area without necessarily physically colliding with it. 
//                 (Code functions on this component in a C# Script: Via Physics Events functions 'OnTriggerEnter',
//                  'OnTriggerStay', 'OnTriggerExit', and you can access this property within the Collider component
//                  of the Game Object via '.GetComponent<Collider>().isTrigger')

//         c. Rigidbody
//           -> Rigidbody is used to apply physics simulations to Game Objects, making them move, fall, 
//              and interact with other Game Objects.
//              (Code functions on this component in a C# Script: No Physics Events functions for this component.
//               You can access this component of the Game Object via '.GetComponent<Rigidbody>()', and use the 
//               available functions and properties within it such as '.GetComponent<Rigidbody>().AddForce()' (for 
//               the 'AddForce()' function) and '.GetComponent<Rigidbody>().velocity' (for the 'velocity' property) 
//               (see Unity(C#) documentation for the other functions and properties available in the Rigidbody 
//               component))

//         d. Transform
//           -> Transform defines the position, rotation, and scale of a Game Object.
//              (Code functions on this component in a C# Script: No Physics Events functions for this component.
//               You can access this component of the Game Object via '.GetComponent<Transform>()', and use the 
//               available functions and properties within it such as '.GetComponent<Transform>().Translate()' 
//               (for the 'Translate()' function) and '.GetComponent<Transform>().position' and 
//               '.GetComponent<Transform>().rotation' (for the 'position' and 'rotation' properties respectively) 
//               (see Unity(C#) documentation for the other functions and properties available in the Transform 
//               component))
//         e. Audio Sources

// 3. The 5 Panels in the Unity(C#) Editor: 
//    a. Scene Panel: A panel in the Unity(C#) Editor showing the environment of the game created in Unity(C#) that 
//                    contains all the Game Objects and assets for a particular part of your game. (basically it 
//                    shows the 'output' of your game)
//    b. Hierarchy Panel: A panel in the Unity(C#) Editor that shows a list of all the Game Objects in your current 
//                        Scene Panel.
//    c. Inspector Panel: A panel in the Unity(C#) Editor that displays information about the currently selected 
//                        Game Object and its components.
//    d. Project Panel: A panel in the Unity(C#) Editor that displays all the files imported in your Unity(C#) game
//                      such as assets, settings, basically all the files inside your Unity(C#) game/project folder
//    e. Console/Terminal Panel: A panel in the Unity(C#) Editor that shows your debugging outputs of your
//                               C# script components of your Game Objects when your Unity(C#) game in run.

// 4. Other common terminology:
//    - UI: User Interface elements that can be used to create menus, buttons, text, and other on-screen displays.
//    - Physics: Unity's built-in physics engine for simulating real-world interactions like gravity, collisions, 
//      and forces.
//    - Material: Defines the visual appearance of a Game Object. Materials can have textures, colors, and shaders.
//    - Shader: A program that determines how a material's surface should be rendered. You can write custom shaders 
//      for advanced rendering effects.
//    - Texture: An image that is wrapped onto a 3D model or used in a Material to give a Game Object its 
//      appearance.
//    - Lighting: The system used to illuminate and shade objects in the scene. Unity supports real-time and 
//      baked (pre-computed) lighting.
//    - Animation: Unity's animation system allows you to create, edit, and play animations for characters and 
//      objects.
//    - Asset: A file or resource imported into Unity, including textures, models, audio clips, and more.
//    - Prefab Variants: Variations of a Prefab with shared components and structure but different properties.
//    - Scene View: A view in the Unity Editor that allows you to navigate and manipulate the elements of your 
//      scene.
//    - Game View: A view in the Unity Editor that shows what your game will look like when played.


////////////////////////////////////////////////////////////////////////////////////////////////////


// Explaining the Unity(C#) scripts/code default template:
// Here is Unity(C#) scripts/code default template,

        // using System.Collections;
        // using System.Collections.Generic;
        // using UnityEngine;

        // public class a_Unity_basic_terminology_and_the_standard_script_template : MonoBehaviour
        // {
        //     // Start is called before the first frame update
        //     void Start()
        //     {
                
        //     }

        //     // Update is called once per frame
        //     void Update()
        //     {
                
        //     }
        // }

// Explanation for each of the commands in the Unity(C#) scripts/code default template:
// -> The 'using' statements: These are C#'s 'using' functions to import the external Unity(C#) libraries necessary 
//                            to create Unity(C#) C# script files. 
// -> 'public class YourScriptName : MonoBehaviour': This is the class definition of the Unity(C#) C# script. 
//                                                   'Monobehaviour' is the superclass, and 'YourScriptName' (it 
//                                                   will be whatever the name of your C# script/file is), is the 
//                                                   subclass, which inherits all the attributes and methods from 
//                                                   the 'MonoBehaviour' superclass.
// -> 'void Start()': 'Start()' is an initialization event function in Unity(C#), where code wihtin it is called 
//                    just before the object’s first frame or physics update on an object
// -> 'void Update()': 'Update()' is a regular update event function in Unity(C#), where code within it are called 
//                     before a frame update occurs



// Explaining the normal C# script/code:
// Here is the normal C# script/code,

        // namespace Project
        // {
        //     class Program
        //     {
        //         static void Main(string[] args)
        //         {

        //         }
        //     }
        // }

// Explanation for each of the commands in the normal C# script/code:
// -> 'namespace Project': represents a namespace called Project. A namespace is used to 
//    organize and group related types (classes, structs, enums, etc.) in C#. It helps avoid 
//    naming conflicts by providing a hierarchical structure for your code. In OOP, in order
//    to use a Class from a seperate file in the main program file, it must have the same 
//    namespace, 'Project' or else that Class from the seperate file will not be usable in
//    in the main program file
// -> 'class Program': represents a Class called 'Program' in the 'Project' namespace (this
//    is basically how you create a Class in C# OOP). It is conventional to name the main
//    program's file's Class as 'Program'
// -> In the line of code, 'static void Main(string[] args)':
//    => 'static' represents that the 'Main' Special method (can google for the different kinds
//       of Special methods in C#) is a Static Method (see what are Static methods in 
//       '1. static_vs_non_static_methods_and_public_vs_private_methods.txt')
//    => 'void' represents that the function does not return anything/data types
//    => 'Main' represents the Special method in C# that indicates the entry point of a C# 
//       console application. It's where the program starts execution.
//    => '(string[] args)' represents the an 'array' containing strings parameter, stored in
//       the 'args' variable (the name, 'args' can be anything, but 'args' is the naming 
//       convention). We need this because when you run a C# program from the command line, you 
//       can actually provide additional information to the program by specifying command-line 
//       arguments, and this '(string[] args)' in the code itself allows you to do that. These 
//       arguments are passed to the program when it starts executing. For example, if you run 
//       your program like this,
//           'MyProgram.exe arg1 arg2 arg3'

//       Then, arg1, arg2, and arg3 are command-line arguments.



// Explaining the differences between the normal C# scripts/code and the Unity(C#) scripts/code default template:

// They both look quite different, even though they are both C# code. Here are the common potential questions that 
// will be raised on their differences,
// a. Why in the normal C# code it uses 'namespace Project' at the top of the code but in the Unity(C#) C# code 
//    default template, it uses 'using' statements at the top of the code?
//    Answer: In Unity(C#), Unity(C#) C# scripts generally do not include a 'namespace [ProjectName]' by default 
//            because Unity(C#) relies on a particular project structure and compiles scripts in a specific way
//            which is done by the external Unity(C#) libraries imported into Unity(C#) C# scripts via the 'using'
//            statements. 

//            When you create a Unity(C#) C# script in Unity(C#), it's automatically placed in a directory related 
//            to the project and inherits various functionalities from Unity(C#)'s engine. (You can refer to the
//            '920. What_are_namespaces_in_C#_and_a_general_explanation_on_the_namespace_statements_and_using_
//            statements.txt', '921. namespace_statements.cs' and '922. using_statements.cs' in the 
//            '1. C# basics' folder in the 'C# learn code archives' folder)

// b. Why in the normal C# code it uses the 'Program' class but in the Unity(C#) C# code default template it uses
//    the inherited 'YourScriptName' subclass from the 'MonoBehaviour' superclass?
//    Anwer: In C#, the entry point for a console application is typically a class named 'Program' with a 'Main()'
//           method. This is the starting point where the program execution begins. On the other hand, in 
//           Unity(C#)'s, Unity(C#) C# scripts are attached to GameObjects which are derived from the 
//          'MonoBehaviour' superclass. 

//           Unity(C#) follows a component-based architecture, where behaviors are attached to GameObjects to define 
//           their functionality. When you create a C# script for Unity(C#), you inherit from 'MonoBehaviour' 
//           instead of the 'Main()' method, which Unity(C#) takes care of managing the lifecycle and execution of 
//           your Unity(C#) C# script.


//////////////////////////////////////////////////////////////////////////////////////////////////////


// How do I put these files into action in Unity(C#)?

// Put them into a created GameObject in the Unity(C#) software itself by dragging the Unity(C#) file you want to 
// the "GameObject" you want to attach it to, in the 'Hierachy' tab in the Unity(C#) software. 

// You can create a GameObject) by:
// 1. Open Unity: Launch the Unity Editor and open your project.
// 2. Select Hierarchy Window: The Hierarchy window in Unity is where you manage the GameObjects in your scene. 
//    It lists all the GameObjects currently in your scene.
// 3. Create a New GameObject:
// 4. Right-click within the Hierarchy window.
// 5. From the context menu, choose "Create Empty." This will create a new GameObject with a default name like 
//    "GameObject", which you can choose to rename if you wish.


//////////////////////////////////////////////////////////////////////////////////////////////////////


// What are these '.meta' files in my 'Assets' folder that are being created along with my Unity(C#) assets and 
// why are they created?
// In Unity(C#), '.meta' files in the 'Assets' folder store the import settings of the assets/files in that 'Assets' 
// folder in your Unity(C#) project. They tell the Unity(C#) editor/software how to prepare the asset/file in 
// the 'Assets' folder in your Unity(C#) project. 

// If you delete a '.meta' file, Unity(C#) reimports the asset and creates the default '.meta' file for that 
// file type. Hence, it is advised that you don't delete them as the recreated default '.meta' file may not
// be the exact same as the initial '.meta' file that you deleted, potentially leading to missing behaviour 
// errors.

// Source link: 
// https://stackoverflow.com/questions/42462989/what-is-a-meta-file-and-why-does-unity-create-them-for-all-of-my-assets
// (Stack Overflow discussion on 'What is a .meta file and why does Unity create them for all of my assets?') 
