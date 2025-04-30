using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio07_Script : MonoBehaviour
{
    public int dimensioneArray = 10;
    public int valoreMassimo = 100;
    public int valoreMinimo = 20;

    void GeneraArray()
    { 
        int [] array = new int[dimensioneArray + 1];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(valoreMinimo, valoreMassimo);
            Debug.Log("Questo è il valore nella posizione " + i + " dell'array (" + array[i] + ")");
        }
        
    }



    // Start is called before the first frame update
    void Start()
    {
        GeneraArray();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
