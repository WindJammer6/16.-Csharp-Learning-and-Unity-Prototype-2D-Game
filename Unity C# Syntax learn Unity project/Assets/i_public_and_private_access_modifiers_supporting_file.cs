using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class i_public_and_private_access_modifiers_supporting_file : MonoBehaviour
{
    public class AnotherClass
    {
        // 'public' variables
        public int apples = 5;
        public int bananas;

        // 'private' variables
        private int stapler;
        private int sellotape;


        // 'public' method
        public void FruitMachine(int a, int b)
        {
            int answer;
            answer = a + b;
            print("Fruit total: " + answer);
        }

        // 'private' method
        private void OfficeSort(int a, int b)
        {
            int answer;
            answer = a + b;
            print("Office Supplies total: " + answer);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

