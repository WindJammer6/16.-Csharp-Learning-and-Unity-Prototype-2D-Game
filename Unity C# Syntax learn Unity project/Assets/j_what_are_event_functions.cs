//What are Event functions in Unity(C#)?

// From Unity(C#)'s documentation (link: https://docs.unity3d.com/Manual/EventFunctions.html):
// A script in Unity is not like the traditional idea of a program where the code runs continuously in a 
// loop until it completes its task. Instead, Unity passes control to a script intermittently by calling 
// certain functions that are declared within it. Once a function has finished executing, control is passed 
// back to Unity. These functions are known as event functions since they are activated by Unity in response
// to events that occur during gameplay. Unity uses a naming scheme to identify which function to call for 
// a particular event.

// Link where I got information about Event functions in Unity(C#) from: 
// https://docs.unity3d.com/Manual/EventFunctions.html (Unity(C#) documentation)


///////////////////////////////////////////////////////////////////////////////////////////////


// The types of Event functions include:

// 1. Initialization Events functions:
//    -> 'Start()' - where code within it are called just before the object’s first frame or physics update
//                   on an object
//    -> 'Awake()' - where code within it are called for each object in the scene at the time when the scene 
//                   loads. Note that the codes within the 'Awake()' Initialization Events function will 
//                   be fully executed before the codes within the 'Start()' Initialization Events function
//                   is run. This means that code in the 'Start()' function can make use of other 
//                   initializations previously carried out in the 'Awake()' phase.


// 2. Regular Update Events functions:
//    -> 'Update()'      - where code within it are called before a frame update occurs
//    -> 'FixedUpdate()' - The physics engine also updates in discrete time steps in a similar way to the 
//                         frame rendering. A separate event function called 'FixedUpdate()' is called just 
//                         before each physics update. Since the physics updates and frame updates do not 
//                         occur with the same frequency, you will get more accurate results from physics 
//                         code if you place it in the FixedUpdate function rather than Update.
//    -> 'LateUpdate()'  - where code within it is called after codes within 'Update()' and 'FixedUpdate()' 
//                         Regular Update functions have been called


// 3. GUI Events functions:
//    -> 'OnGUI()' - it is the only function that can implement the "Immediate Mode" GUI (IMGUI) system for 
//                   rendering and handling GUI events. (More on IMGUI in this link in the Unity(C#) 
//                   documentation: https://docs.unity3d.com/Manual/GUIScriptingGuide.html)
//    -> 'OnMouseEnter()' - where code within is called on the first frame the mouse is over the object/Collider
//    -> 'OnMouseOver()'  - where code within is called each frame the mouse is over the object/Collider until 
//                          the mouse moves away, at which point 'OnMouseExit()' is called
//    -> 'OnMouseExit()'  - where code within is called each frame the mouse is not over the object/Collider
//    -> 'OnMouseDown()'  - where code within is called when the user has pressed the mouse button while over 
//                          the object/Collider.


// 4. Physics Events functions:
//    -> 'OnCollisionEnter()' - where code within it is called when this object/Collider has begun touching 
//                              another object/Collider. Takes a Collision type parameter.
//    -> 'OnCollisionStay()'  - where code within is called each frame for every object/Collider that touches 
//                              another object/Collider. Takes a Collision type parameter.
//    -> 'OnCollisionExit()'  - where code within is called each frame the object/Collider has stopped/is not
//                              touching another object/Collider. Takes a Collision type parameter.

//    -> 'OnTriggerEnter()'  - where code within it is called when this object/Collider has begun touching 
//                             the trigger of another object/Collider. Takes a Collider type parameter.
//    -> 'OnTriggerStay()'   - where code within is called each frame for every object/Collider that touches 
//                             the trigger of another object/Collider. Takes a Collider type parameter.
//    -> 'OnTriggerExit()'   - where code within is called each frame the object/Collider has stopped/is not
//                             touching the trigger of another object/Collider. Takes a Collider type parameter.

// (Difference between Collision and Trigger:
//  -> Collisions are used to simulate physical interactions between GameObjects. When two colliders with 
//     Rigidbody components collide, they apply physics forces to each other.
//  -> Triggers are used to detect interactions without causing physical interactions. When a GameObject 
//     enters a trigger zone, it doesn't apply physics forces or push objects. It's more like an event 
//     detector.)
