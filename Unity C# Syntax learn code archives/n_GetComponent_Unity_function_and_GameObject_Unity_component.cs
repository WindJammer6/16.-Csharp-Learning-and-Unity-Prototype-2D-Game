// What does the 'GetComponent<>()' function do?
// In Unity(C#), the 'GetComponent<>()' function is a method provided by the 'GameObject' class that allows you to 
// retrieve a reference/create a class instance of a specific component class (since components are defined as 
// classes in Unity(C#)) attached to the GameObject. It's commonly used to access and manipulate the properties and 
// methods of different Unity(C#) components.

// The angled brackets '<>' takes in one parameter, which is the component class type (aka name). I did not check
// what parameters the parenthesis ('()') take in, but usually its empty for most use cases of the 'GetComponent<>()'
// function.

// Using the 'GetComponent<>()' function, you can not only,
// -> make references from other C# scripts as custom components (like this file)
// -> but also make references to existing component classes from Unity(C#) software/editor (though they are not 
//    shown in the VS code autocomplete API here, so you kinda need to know what are the syntax (names) for those 
//    Unity(C#) component classes) such as the 'GameObject', 'BoxCollider', 'Transform', 'RigidBody' and 'Light' 
//    component classes (which are classes you can call that already exists in the Unity(C#) software, without 
//    having to create them yourself) (like in this file, the 'r_enabled_Unity_function.cs' and the 
//    'q_transform_component_translate_and_rotate_functions.cs' files) 




// Function of Unity(C#)'s 'GetComponent<>()' function vs its similar implementation in normal C# code:
// If you recap, the 'GetComponent<>()' function in Unity(C#) actually does something very similar to normal C#
// code. In normal C# code, you would instantiate a class instance like so:
        // public ComponentClassType ComponentVariableName;

        // ComponentVariableName = new ComponentClassType();

// In Unity(C#), using the 'GetComponent<>()' function,
        // public ComponentClassType ComponentVariableName;

        // ComponentVariableName = GetComponent<ComponentClassType>();

// However, in Unity(C#) scripts, it is not recommended to instantiate a class instance the same way as in normal
// C# code, as it might not be correctly integrated with the Unity(C#)'s GameObject class instance's lifecycle 
// and Unity(C#)'s internal systems. It is always recommended to use the 'GetComponent<>()' function.




// Additional notes on the 'GetComponent<>()' function:
// The 'GetComponent<>()' function is expensive in terms of processing power, and is hence should be called as
// infrequently as possible. It is recommended and good practice to call it only in either the 'Start()' or 
// 'Awake()' Event functions, or only once when its needed.


//////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Why in some Unity(C#) C# scripts (like in this file), they instantiate a 'GameObject' class instance at the
// top of the Unity(C#) C# script, and attach the instantiated component class instances to that 'GameObject'
// class instance? But in other Unity(C#) C# scripts, they did not instantiate a 'GameObject' class instance
// at the top of the Unity(C#) C# script, and just ran instantiated component class instances without attaching
// any 'GameObject' class instances (like in the files 'r_enabled_Unity_function.cs' and 
// 'q_transform_component_translate_and_rotate_functions.cs')?
// Before we answer this question, we need to understand that these Unity(C#) C# scripts are always attached to 
// a GameObject in the Unity(C#) software/editor. 

// When we instantiate a 'GameObject' class instance at the top of the Unity(C#) C# script, what we are actually
// doing is not creating a class instance of the 'GameObject' that the C# script is attached to, rather, we
// are actually creating a brand new 'GameObject' class instance.

// -> When we attach an instantiated component class instances to this new 'GameObject' class instance (by calling 
//    whatever variable name we assigned this new 'GameObject' class instance to) (like in this file) like so: 
        // ComponentClassType ComponentVariableName = NewGameObject.GetComponent<ComponentClassType>();

//    We are actually attaching the instantiated component class instance to the new 'GameObject' class instance,
//    rather than the 'GameObject' that the C# script is attached to.

// -> It is only when we just run the instantiated component class instances without attaching any 'GameObject' 
//    class instances (like in the files 'r_enabled_Unity_function.cs' and 
//    'q_transform_component_translate_and_rotate_functions.cs') like so:
        // ComponentClassType ComponentVariableName = GetComponent<ComponentClassType>();

//    When we are actually attaching the instantiated component class instance to the 'GameObject' that the C# script 
//    is attached to, rather than the new 'GameObject' class instance.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n_GetComponent_Unity_function_and_GameObject_Unity_component : MonoBehaviour
{
    // Using the 'GetComponent<>()' function, you to make references to existing component classes from Unity(C#) 
    // software/editor, though they are not shown in the VS code autocomplete API here:

    // Creating a new 'GameObject' class instance and stroing it in the variable 'myGameObject'. Note that this
    // is a new GameObject, not storing a reference (class instance) of the GameObject this C$ script component is
    // attached to!
    public GameObject myGameObject;

    private BoxCollider myboxCollider;



    // Using the 'GetComponent<>()' function to make references from other C# scripts as custom components:

    // Storing references to the other C# scripts (aka creating class instances to the other C# scripts' class,
    // which class' name happens to have the same name as the file name), 
    // 'o_GetComponent_Unity_function_SelfmadeComponentOne_supporting_file' and
    // 'p_GetComponent_Unity_function_SelfmadeComponentTwo_supporting_file'
    private o_GetComponent_Unity_function_SelfmadeComponentOne_supporting_file SelfmadeComponentOne;
    private p_GetComponent_Unity_function_SelfmadeComponentTwo_supporting_file SelfmadeComponentTwo;




    // In the 'Awake' Initialization Event function, we are initializing the variables 'SelfmadeComponentOne'
    // and 'SelfmadeComponentTwo'. We are also attaching the 'SelfmadeComponentTwp' component class instance in 
    // the new 'GameObject''s 'myGameObject' variable
    void Awake()
    {
        // Attaching the component class instance to the 'GameObject' that this C# script is attched to
        SelfmadeComponentOne = GetComponent<o_GetComponent_Unity_function_SelfmadeComponentOne_supporting_file>();

        // Attaching the component class instance to the new 'myGameObject' 'GameObject' class instance
        SelfmadeComponentTwo = myGameObject.GetComponent<p_GetComponent_Unity_function_SelfmadeComponentTwo_supporting_file>();

        // Attaching the existing Unity(C#) component class instance (not shown the VS code autocomplete API) to 
        // the new 'myGameObject' 'GameObject' class instance
        myboxCollider = myGameObject.GetComponent<BoxCollider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Accessing the 'size' property of the 'BoxCollider' component/class (see Unity(C#) documentation for all 
        // existing properties and methods/functions of the 'BoxCollider' component)
        myboxCollider.size = new Vector3(3,3,3);
        print("The player's score is " + SelfmadeComponentOne.playerScore);
        print("The player has died " + SelfmadeComponentTwo.numberOfPlayerDeaths + " times");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

