using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_while_loop : MonoBehaviour
{
    int cupsInTheSink = 4;

    // Start is called before the first frame update
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            print("I've washed a cup!");
            cupsInTheSink--;            //'cupsInTheSink -= 1' works too for C#, similarly to Python's syntax
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
