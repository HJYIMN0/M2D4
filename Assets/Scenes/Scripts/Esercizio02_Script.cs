using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio02_Script : MonoBehaviour
{

    public int numero1 = 5;
    public int numero2 = 4;
    public int numero3 = 12;
    public int numero4 = 1;

    int[] array;

    int interrompere = 2;
   
    // Start is called before the first frame update
    void Start()
    {
       
        }

    // Update is called once per frame
    void Update()
    {

        while (interrompere > 0)
        {
            array = new int[] { numero1, numero2, numero3, numero4 };
            Debug.Log("Questi sono i valori dell'array: " + numero1 + ", " + numero2 + ", " + numero3 + ", " + numero4);
            Debug.Log("Questa è la somma dei valori dell'array: " + (numero1 + numero2 + numero3 + numero4));
            Debug.Log("Questa è la sommail prodotto dei valori dell'array: " + (numero1 * numero2 * numero3 * numero4));
            interrompere--;
        }



    }
}
