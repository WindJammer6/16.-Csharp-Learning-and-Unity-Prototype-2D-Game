// This file is not annotated, since I dont think its the most useful functions. I'll leave it the sample C# 
//script code here just in case.

// The 'activeSelf' and 'activeInHierarchy' Unity functions are used to activate GameObjects in Unity(C#)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_activeSelf_and_activeInHierarchy_Unity_functions : MonoBehaviour
{
    public GameObject my_Object;

    // Start is called before the first frame update
    void Start()
    {
        print("Active Self: " + my_Object.activeSelf);
        print("Active in Hierarchy: " + my_Object.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
