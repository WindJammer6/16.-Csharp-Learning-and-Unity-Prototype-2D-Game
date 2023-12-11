// From the 'what_are_event_functions.cs' file,

// 'Start()' and 'Awake()' are Initialization Events functions where:
//    -> 'Start()' - where code within it are called just before the object’s first frame or physics update
//                   on an object
//    -> 'Awake()' - where code within it are called for each object in the scene at the time when the scene 
//                   loads. Note that the codes within the 'Awake()' Initialization Events function will 
//                   be fully executed before the codes within the 'Start()' Initialization Events function
//                   is run. This means that code in the 'Start()' function can make use of other 
//                   initializations previously carried out in the 'Awake()' phase.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_start_and_awake_special_functions : MonoBehaviour
{
    // The 'Awake()' function is called first even if the script component is not enabled, and is best used 
    // to set up any references between scripts and initialization (setting up the settings before enabling
    // the script component). 
    
    // You can see this in Unity(C#)'s terminal that the string "The 'Awake()' initialization event 
    // function is called." is printed first before the string "The 'Start()' initialization event function 
    // is called."
    void Awake()
    {
        print("The 'Awake()' initialization event function is called.");
    }

    // 'Start()' is called after 'Awake()', immediately before the first frame update, but only if the
    // script component is enabled. This means that you can use the 'Start()' function for anything you need
    // to occur when the script component is enabled.

    // This allows you to delay any part of your initialization code until its really needed. 
    void Start()
    {
        print("The 'Start()' initialization event function is called.");
    }
}


// Note: The 'Start()' and 'Awake()' functions will only ever be called once in the lifetime of a script 
// component attached to an object. So you cannot repeat the 'Start()' and 'Awake()' functions by disabling 
// and re-enabling a script.