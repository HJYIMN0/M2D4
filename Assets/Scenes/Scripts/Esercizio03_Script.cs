using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio03_Script : MonoBehaviour
{

    public int numero;

    // Start is called before the first frame update
    void Start()
    {
        for (int numero = 0; numero <= 30; numero++)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Debug.Log("FizzBuzz" + "(" + numero + ")");
            }
            else if (numero % 3 == 0)
            {
                Debug.Log("Fizz " + "(" + numero + ")");
            }
            else if (numero % 5 == 0)
            {
                Debug.Log("Buzz " + "(" + numero + ")");
            }
            else
            {
                Debug.Log(numero);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
