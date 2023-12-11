//Rename this file to 'if_statements, the 'Input.GetKeyDown' and 'KeyCode.Space' functions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_if_statements : MonoBehaviour
{
    //Whats with the additional alphabet, 'f', and 'm' behind for the 'float' and 'decimal' variables?
    //They are additional suffixes that you need to add in at the end of your 'float' and 'decimal' 
    //variables respectively to tell the C# compiler understand the data type you are using.
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }


    //About the 'Input.GetKeyDown' and the 'KeyCode.Space' functions:
    //-> the 'Input.GetKeyDown' function is used to check if a specific key or mouse button is pressed during a 
    //   single frame. It is often used for detecting user input, such as keyboard or mouse input, in Unity(C#) or 
    //   applications. It takes a single argument, which is the key or button you want to check for, depicted in as
    //   'KeyCode.[name of the key/button]'.
   
    //   the 'Input.GetKeyDown' is typically used in the 'Update()' method of a MonoBehaviour/Unity(C#) script, 
    //   as you want to check for input in every frame. Which is hence why the code in this Unity(C#) C# file is 
    //   under the 'Update()' method instead of the 'Start()' method

    //-> the 'KeyCode.' function allows the program to detect keyboard input in your Unity(C#) games, where you can
    //   specify what keyboard input you want to detect by adding the name of the key/button behind the function
    //   like so: 'KeyCode.[name of the key/button]' (In this case '.Space' indicates you want to detect if the
    //   Spacebar key/button is being pressed during the running of the Unity(C#) game). The list of the names of 
    //   the key/button you can use in 'KeyCode.[name of the key/button]' can found in this documentation:
    //   https://docs.unity3d.com/ScriptReference/KeyCode.html

    //   (more on 'GetKeyDown' and other similar functions as well as 'KeyCode' function in the 
    //   'GetButton_and_GetKey_and_KeyCode.cs' file)

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        coffeeTemperature -= Time.deltaTime * 5f;   
    }

    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            // Debug.Log("Coffee is too hot");
            print(("Coffee is too hot"));
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // Debug.Log("Coffee is too cold");
            print("Coffee is too cold");
        }
        else
        {
            // Debug.Log("Coffee is just right");
            print("Coffee is just right");
        }
    }
}
