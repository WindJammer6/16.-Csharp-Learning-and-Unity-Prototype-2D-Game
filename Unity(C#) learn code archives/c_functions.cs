using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_functions : MonoBehaviour
{
    int test_integer_variable = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Both does the same thing:   
        print(MultiplyByTwo(test_integer_variable));
        // Debug.Log(MultiplyByTwo(test_integer_variable));

        print(test_integer_variable * 2);
        // Debug.Log(test_integer_variable * 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This is how to create the self-made function in Unity(C#), exactly the same as how you'll do it normal
    //C# code 
    int MultiplyByTwo(int number)
    {
        number = number * 2;
        return number;

        //OR this works too:
        // int result;
        // result = number * 2;
        // return result;
    }
}
