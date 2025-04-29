using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio03__Script : MonoBehaviour
{
    public int num = 15;



    // Start is called before the first frame update
    void Start()
    {

        
        for (int i= 0; i < 30; i++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }

            else if (num % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (num % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(i);
            }
            
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
