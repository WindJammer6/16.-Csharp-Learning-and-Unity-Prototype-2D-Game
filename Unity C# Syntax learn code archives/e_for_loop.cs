using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e_for_loop : MonoBehaviour
{
    int number_of_enemies = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < number_of_enemies; i++)
        {
            print("Creating enemy number: " + i);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
