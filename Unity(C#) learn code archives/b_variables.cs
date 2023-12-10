using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_variables : MonoBehaviour
{
    //This is how to create a variable in Unity(C#), exactly the same as how you'll do it normal
    //C# code 
    int  test_int_variable = 5;

    // Start is called before the first frame update
    void Start()
    {
        //There are 2 equivalent function in Unity(C#) to 'print' in Python in the terminal, but instead of 
        //the output being shown in your IDE, its shown in the Unity(C#) software's terminal instead
        //-> 'print()'  (aka the shorthand function of the 'Debug.Log()' function)
        //-> 'Debug.Log()'

        //For the sake of this Unity(C#) syntax tutorial, we will standardise using the 'print'
        //function, rather than the 'Debug.Log()' function
        print(test_int_variable);
        Debug.Log(test_int_variable);

        print(test_int_variable * 2);
        // Debug.Log(test_int_variable * 2);

        test_int_variable = 55;

        print(test_int_variable);
        // Debug.Log(test_int_variable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



// MUST ALWAYS CREATE THE FILE IN UNITY(C#), NOT ON FOLDER ELSE IT WILL CRASH THE UNITY(CS) SOFTWARE!!!
