// Throughout this Unity(C#) learning journey, we have come across many Unity(C#) components/class,
// Unity(C#) functions and Unity(C#) properties. Here is a summary of all the Unity(C#) components/class, 
// Unity(C#) functions and Unity(C#) properties we have come across so far, and some other commonly used 
// ones that we did not cover through this Unity(C#) learning journey that I will give a quick explanation 
// here:

// 1. 'GameObject' component/class
//    a. 'Transform' component/class
//       -> 'Translate' function
//       -> 'Rotate' function
//       -> 'LookAt' function: is used to make a GameObject's forward direction point at a specified target 
//                             position
//    b. 'BoxCollider' component/class
//       -> 'size' property
//    c. 'Light' component/class
//    d. 'activeSelf' property: is used to check if the GameObject is active in the scene
//    e. 'activeInHierarchy' property: is used to check if the entire hierarchy of the GameObject, checking 
//                                     whether the GameObject and all its ancestors are active. It returns 
//                                     true if the GameObject is active and all of its parent GameObjects (up 
//                                     the hierarchy) are also active; otherwise, it returns false.
// 2. 'Input' component/class
//      -> 'GetButtonDown' function
//      -> 'GetButton' function
//      -> 'GetButtonUp' function
//      -> 'GetKeyDown' function
//      -> 'GetKey' function
//      -> 'GetKeyUp' function
//      -> 'GetAxis' function: is used to retrieve the value of a virtual axis
// 3. 'KeyCode' component/class
//      -> See Unity(C#) documentation for all available functions: 
//         https://docs.unity3d.com/ScriptReference/KeyCode.html
// 4. 'Time' component/class
//      -> 'deltaTime' function
// 5. 'Random' component/class
//      -> 'Range' function: is used to generate a random float within a specified range


// Other Unity(C#) functions/properties/syntax that are not part of any Unity(C#) compoennts/class:
// 1. 'print' function: to print outputs in Unity(C#)'s console (not VS code or any IDE you are coding on!)
// 2. 'GetComponent<>()' function
// 3. 'Vector3' function: represents a three-dimensional vector or a point in 3D space
//    (see the 'q_Transform_GameObject_Unity_component_and_its_translate_and_rotate_Unity_functions.cs' file 
//    for more about this function)
//    -> 'right' property: represents a unit vector in the positive x-axis
//    -> 'up' property: represents a unit vector in the positive y-axis
//    -> 'forward' property: represents a unit vector in the positive z-axis
// 4. 'Destroy' function: is used to destroy a GameObject, a component, or an asset
// 5. 'activeSelf' activeInHierarchy_Unity_functions
// 6. 'enabled' property (This is property that is available in all 'GameObject' components/classes)
// 7. 'Instantiate' function: is used to create clones of GameObjects
// 8. 'Invoke' function: is used to schedule a function call after some specified time delay
// 9. 'InvokeRepeating' function: is used to schedule and repeatedly call a function after some specified 
//                                time delay
