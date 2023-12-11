// What is the 'Transform' GameObject Unity component?
// The 'Transform' GameObject Unity component defines the position, rotation, and scale of a Game Object.


///////////////////////////////////////////////////////////////////////////////////////////


// What does the 'Transform' GameObject Unity component's 'Translate' and 'Rotate' Unity(C#) functions do?
// -> The 'Translate' Unity(C#) function moves the GameObject in the specified direction by the given 
//    translation vector.
//    (Declaration: 'Translate(Vector3 translation, Space relativeTo = Space.Self);')
// -> The 'Rotate' Unity(C#) function rotates the GameObject by the specified rotation vector.
//    (Declaration: 'public void Rotate(Vector3 axis, float angle, Space relativeTo = Space.Self);')

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q_transform_component_translate_and_rotate_functions : MonoBehaviour
{
    private Transform transform;

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        // For the 'Translate' Unity(C#) funciton:

        // What this line of code does is that it translate the GameObject this C# script is attached to 
        // down the z-axis by metres every frame

        // However, this line of code translates the GameObject too quickly because its updating the 
        // translation every frame
            // transform.Translate(new Vector3(0, 0, 1));


        // To slow it down, we can multiply the vector by 'Time.deltatime' and a self-made variable, 
        // 'moveSpeed', so we can control the tranlsation speed and cause the tranlsation to update every 
        // second, rather than every frame

        // Note: -> '.forward', a property of the 'Vector3' existing/built-in component/class in
        //          Unity(C#), can be used as a shortcut as the 'new Vector3(0,0,1)' line of code, 
        //          representing the positive z-axis direction 

        //       -> 'moveSpeed' is a variable that we create ourselves to store seperately a 'float' value 
        //          that we will multiply to the 'Vector3.forward' and 'Time.deltaTime'. This way, we can 
        //          control the speed of the translation by adjusting the variable inside the Inspector in the 
        //          Unity(C#) software/editor

        //       -> 'Time.deltaTime' tells the Unity(C#) software/editor to update the translation by metres 
        //          per second, rather than metres per frame
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);



        // For the 'Rotate' Unity(C#) funciton:
        
        // What this line of code does is that it rotate the GameObject this C# scriprt is attached to 
        // up the z-axis by degrees every frame

        // However, this line of code rotates the GameObject too quickly because its updating the 
        // rotation every frame
            // transform.Rotate(new Vector3(0, 1, 0));


        // To slow it down, we can multiply the vector by 'Time.deltatime' and a self-made variable, 
        // 'moveSpeed', so we can control the tranlsation speed and cause the tranlsation to update every 
        // second, rather than every frame

        // Note: -> '.up', a property of the 'Vector3' existing/built-in component/class in
        //          Unity(C#), can be used as a shortcut as the 'new Vector3(0,1,0)' line of code, 
        //          representing the positive y-axis direction 

        //       -> 'turnSpeed' is a variable that we create ourselves to store seperately a 'float' value 
        //          that we will multiply to 'Time.deltaTime'. This way, we can control the speed of the 
        //          rotation by adjusting the variable inside the Inspector in the Unity(C#) software/editor

        //       -> 'Time.deltaTime' tells the Unity(C#) software/editor to update the rotation by degrees 
        //          per second, rather than degrees per frame
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);





        // What if we want the GameObject to only undergo translation/rotation based on a key press? 

        // To do this we can add if statements and checking if the corresponding keys are being pressed using
        // the 'Input.GetKey(KeyCode.[key that we want to check if its being pressed])' line of code like so:
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.up * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-Vector3.up * turnSpeed * Time.deltaTime);
        }
    }
}




// Additional notes: 
// - There is a shortcut property/variable of the 'Vector3' function for representing a 'Vector3' for every 
//   3D dimension, 
//   -> For the positive x-axis: 'Vector3.right'
//   -> For the positive y-axis: 'Vector3.up'
//   -> For the positive z-axis: 'Vector3.forward'
// - The 'Translate' and 'Rotate' Unity(C#) functions only work on the local axis, rather than in the world
//   axis. This means that where I'm using the 'Vector3.forward' or 'Vector3.up' Unity(C#) functions, this
//   is relative to the axis of the GameObject, rather than the game world
// - Also, if you want to move an object with a 'Collider' component, something thats gonna be interacting 
//   with physics, then it is not recommended to use the 'Translate' and 'Rotate' Unity(C#) functions, but
//   the 'Physics' component/class' functions instead