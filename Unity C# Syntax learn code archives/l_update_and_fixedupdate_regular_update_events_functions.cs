using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_update_and_fixedupdate_regular_update_event_functions : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float UpdateTimer;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        // Called every physics step, and used for regular updates such as:
        // -> Adjusting physics (Rigidbody) objects
        //    -> Side note, when scripting physics in the 'FixedUpdate()' function its good practice to use forces 
        //       for movement

        // (Note: 'FixedUpdate()' function's interval times are consistent) 
        
        // Hence, anything that affects a physics (Rigidbody) object, should be in the 'FixedUpdate()'
        // function, rather than the 'Update()' function
        print("FixedUpdate timer: " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Called every frame, and used for regular updates such as:
        // -> Moving non-physics (Rigidbody) objects
        // -> Simple timers
        // -> Receiving input

        // (Note: Update interval times vary)
        print("Update time: " + Time.deltaTime);   
    }
}
