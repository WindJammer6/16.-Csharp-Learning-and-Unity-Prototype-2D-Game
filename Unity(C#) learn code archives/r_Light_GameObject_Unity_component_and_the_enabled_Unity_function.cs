// In order to use this file, you need to attach a 'Light' component into your GameObject you attached this C# 
// script to, since in this C# script you are trying to access a 'Light' component in the line of code
// 'private Light light_component;', and if you don't attach a 'Light' component to your GameObject you attached 
// this C# script to you will get an error since your C# script is trying to access a 'Light' component that 
// dosent exist


///////////////////////////////////////////////////////////////////////////////////////////////


// What does the '.enabled' Unity(C#) function do?
// The '.enabled' function is used to enable and disable GameObject components.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r_Light_GameObject_Unity_component_and_the_enabled_Unity_function : MonoBehaviour
{
    // Initiallising the 'light_variable' variable as an object of the 'Light' GameObject Untiy 
    // class/component. Since the 'Light' component is an existing component in Unity(C#), you can access it 
    // directly as a class (even though VS code does not recognise it as one, but when you transfer this C# 
    // script into Unity(C#), Unity(C#) should be able to recognise 'Light' as a class, aka a GameObject 
    // component)

    // In order to see what are the possible existing components that you can add to your GameObject in Unity(C#),
    // you can refer to the 'Add Components' drop down widget in the Inspector in Unity(C#) to see all the 
    // available GameObject components available 
    private Light light_component;

    // Start is called before the first frame update
    void Start()
    {
        // Setting the 'light_component' variable as a 'Light' component of the GameObject this C# script is 
        // attached to

        // The angled '<>' brackets take in one parameter, the type of the component/class, which will be the 'Light'
        // component in this C# script

        // (more on the 'GetComponent' functions in the 
        // 'n_GetComponent_Unity_function_and_GameObject_Unity_component.cs' file)
        light_component = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // This if statement continuously checks if the spacebar key (via 'KeyCode.Space' function) has been 
        // pressed (via 'Input.GetKeyUp()' function) since its in the 'Update()' Event function

        // (more on 'GetKeyDown' and other similar functions as well as 'KeyCode' function in the 
        // 'm_Input_Unity_component_and_its_GetButton_and_GetKey_Unity_functions_and_KeyCode_and_its_Unity_functions.cs'
        // file)
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Here is the function that allows us to enable/disable a GameObject component, the '.enabled' 
            // function.
            
            // So how does enabling/disabling a GameObject component look like in the Unity(C#) software/editor?
            // In the Unity(C#) software/editor, when you trigger this line of code (by pressing the spacebar key),
            // the 'Light' component in the GameObject you placed this C# script in will be disabled, indicated
            // by the tick box for the 'Light' component becoming from checked to unchecked as seen in the 
            // Inspector in the Unity(C#) software/editor
            
            // However, the line of code where 'light_component.enabled = false;' will only disable the 'Light' 
            // component, and is unable to enable it again
                // light_component.enabled = false;
            
            // Conversely for the line of code where 'light_component.enabled = True;', which will only enable the 
            // 'Light' component, and is unable to disable it again
                // light_component.enabled = True;


            // In order to make the enabling/disabling (via the '.enabled' function) of the GameObject component 
            // able to toggle between the enabled and disabled states, you can do this, which is effectively 
            // saying 'set this to whatever it is not at the moment' or 'set this to its opposite boolean'.
            light_component.enabled = !light_component.enabled;
        }    
    }
}
