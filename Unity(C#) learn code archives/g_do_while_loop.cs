using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_do_while_loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool shouldContinue = false;

        //This is the key difference between a do while loop and a while loop
        //-> Do while loops check the condition at the end of the code body, after running the code body.
        //   In a do while loop, the code body is guranteed to run at least once.
        //-> While loops check the condition at the start of the code body, before running the code body
        //   In a while loop, the code body is not guranteed to run at least once.
        do
        {
            print("Hello World");
        }
        while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
