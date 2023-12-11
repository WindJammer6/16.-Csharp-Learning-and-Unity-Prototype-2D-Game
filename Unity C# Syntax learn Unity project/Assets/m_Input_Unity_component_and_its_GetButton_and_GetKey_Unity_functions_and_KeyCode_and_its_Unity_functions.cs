// In Unity(C#), 'GetButton' and 'GetKey' functions are part of the 'Input' Unity component/class which allows
// you to receive input from keys or joystick buttons.


///////////////////////////////////////////////////////////////////////////////////////////


// Whats the difference between the 'GetButton' and 'GetKey' function?
// -> 'GetButton' requires you to specify the reference name (a string) of a button/key. You can set the
//    reference name of a button/key in the 'Input Manager' in Unity(C#). You can access it in the Unity(C#)
//    editor/software by 'Edit > Project Settings > Input'. In the 'Input Manager', you can decide the
//    reference name such as 'Jump', and specify the button/key in which the 'Jump' reference name represents.

//    To find out what to write into your positive button (aka the button/ley in which the reference name
//    represents, you can check the terms for the button/keys in the documentation: 
//    https://docs.unity3d.com/Manual/class-InputManager.html)

// -> 'GetKey' requires you to specifically name the keys you want to receive input from for an action
//    via the 'KeyCode' function. This function works just fine for games that uses the keyboard, but
//    its recommended you use 'GetButton' instead and specify your own controls.



// Whats the 'KeyCode' Unity component/class?
// The 'KeyCode.' Unity component/class allows the program to detect keyboard input in your Unity(C#) games, 
// where you can specify what keyboard input you want to detect by adding the name of the key/button as a 
// property/variable behind the 'KeyCode' Unity component/class like so: 'KeyCode.[name of the key/button]'. 
// The list of the names of the key/button you can use in 'KeyCode.[name of the key/button]' can found in this 
// Unity(C#) documentation: https://docs.unity3d.com/ScriptReference/KeyCode.html


/////////////////////////////////////////////////////////////////////////////////////////////


// How to use the 'GetButton' and 'GetKey' functions?
// For both the 'GetButton' and 'GetKey' functions, there are actually 3 different functions under each of
// them. 
// For 'GetButton':
// - 'GetButtonDown'
// - 'GetButton'
// - 'GetButtonUp'

// For 'GetKey':
// - 'GetKeyDown'
// - 'GetKey'
// - 'GetKeyUp'

// All of these functions return a boolean, true or false.

// -> For 'GetButtonDown' and 'GetKeyDown', they will only register true at the first frame where the button/key
//    is prressed down, and returns to false in subsequent frames even if the button/key is being held down.

// -> For 'GetButton' and 'GetKey', they will register true or false depending on whether the button/key is 
//    being pressed or not. It will be true for all frames as long as the button/key is being held down.

// -> For 'GetButtonUp' and 'GetKeyUp', they will only register true at the first frame where the button/key
//    is released, and returns to false in subsequen =t frames where the button/key is released/not being held
//    down.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_Input_Unity_component_and_its_GetButton_and_GetKey_Unity_functions_and_KeyCode_and_its_Unity_functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            print("Spacebar is pressed down!");
        }
        if (Input.GetKey(KeyCode.Space) == true)
        {
            print("Spacebar is being pressed!");
        }
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            print("Spacebar is released!");
        }
        else
        {
            print("Spacebar is not being pressed!");
        }
    }
}
 