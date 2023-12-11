// What are Modifiers?
// Modifiers are keywords that appear in front of the datatype of a declared variable or functions. For
// example:
// - the 'public' command in 'public int alpha' (for variables)
// - the 'private' and 'static' commands in 'public void ExampleFunction()' (for functions)

// There are many types of modifiers such as:
// -> Access Modifiers ('public', 'private', 'protected', 'internal', etc.)
// -> Static Modifiers ('static')
// -> Read-Only Modifiers ('readnoly')
// -> etc...


/////////////////////////////////////////////////////////////////////////////////////////////////


// In this Unity(C#) file, we will only be looking at 2 Access Modifiers, the 'public' vs 'private' Access 
// Modifiers:
// -> A Public Access Modifer causes the class/variable/function it is attached to be accessible from outside 
//    the Class in which it is defined. It is part of the Class's public interface, meaning that code in other 
//    Classes or parts of the program can call and use the Public Access Modifer.

// -> A Private Access Modifer causes the class/variable/function it is attached to to only be accessible 
//    within the Class in which it is defined. It is not part of the Class's public interface and cannot be 
//    called from outside the Class.

// Note: In a class/variable/function in C# (or in Unity(C#)'s code syntax), if you do not specify if the 
//       class/variable/function is a 'public' or 'private' class/variable/function, it will be a 'private' 
//       class/variable/function by default.


//////////////////////////////////////////////////////////////////////////////////////////////////


// In an additional context of Unity(C#) for public/private variables:
// - In addition to being able to be accessed from outside the class,
//   -> Public variables such as the 'alpha' variable in this C# script, within the '[filename] : MonoBehaviour' 
//      class in the C# scripts will be shown and editable on the C# scripts component in the Inspector, allowing 
//      users to modify these 'public' variables in the Unity(C#) software/editor when they are testing their 
//      games without having to keep re-opening the C# script to modify the 'public' variables manually

//   Conversely, in addition to not being able to be accessed from outside the class,
//   -> Private variables such as 'beta' and 'gamma'  variables in this C# script, within the 
//      '[filename] : MonoBehaviour' class in the C# scripts will not be shown and editable on the C# scripts 
//      component in the Inspector
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h_public_and_private_access_modifiers : MonoBehaviour
{
    public int alpha;
    // public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    // Start is called before the first frame update
    void Start()
    {
        // About overriding the public 'alpha' variable using the Inspector in the Unity(C#) editor, the 
        // 'Start()' Event function, and 'Update()' Event function:
        // If the public 'alpha' variable is initialized in the '[filename] : MonoBehaviour' class to a
        // default value (as shown by the commented out 'public int alpha = 5;' code), then it will still
        // be overridden by the value thats written in the Inspector.

        // However, if these public 'alpha' variable values are set in functions, such as 'Start()' and 
        // 'Awake()' Event functions, these functions occur after the public 'alpha' variable is set in the
        // Inspector initially and will not be overridden by the value in the Inspector initially, but will 
        // override the value in the Inspector initially instead.

        // However, when the game is running and the user tweak the valu of the public 'alpha' variable in 
        // the Inspector again, or if the public 'alpha' variable is set in the 'Update()' Event function,
        // then this public 'alpha' variable in the 'Start()' Event function will be overridden by either
        // cases again.

        // Note: The public 'alpha' variable values modified via the Inspector while the Unity(C#) game is 
        //       in 'Play' mode will be reset and not saved, in the Inspector when we exit 'Play' mode 
        alpha = 29;



        // Testing importing public classes ('AnotherClass()'), functions ('FruitMachine()') and variables 
        // ('apples') from another file 'i_public_and_private_access_modifiers_supporting_file.cs':
        // As you can see from these 2 lines of code, it demonstrated how you can import public classes, 
        // as well as functions and variables from that public class from another file into this one, while
        // you cannot import private classes, functions ('OfficeSort()') and variables ('stapler' and 'sellotape')
        // (see the 'i_public_and_private_access_modifiers_supporting_file.cs' file) 
        i_public_and_private_access_modifiers_supporting_file.AnotherClass myOtherClass = new i_public_and_private_access_modifiers_supporting_file.AnotherClass();

        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    // Update is called once per frame
    void Update()
    {
        print("Alpha is set to: " + alpha);
    }
}
