using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio07_Script : MonoBehaviour
{
    public int dimensioneArray = 10;
    public int valoreMassimo = 100;
    public int valoreMinimo = 20;
    int[] array = new int[0];

    void GeneraArray(int a, int b, int c)
    { 
        array = new int[a];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(b, c);
            
        }
        Debug.Log("Fine funzione GeneraArray");
        
    }

    void StampaArray(int[] a)
    {
        for (int i = 0; i < dimensioneArray; i++) 
        {
            Debug.Log("Questo è il valore nella posizione " + i + " dell'array (" + array[i] + ")");
        
        }
        Debug.Log("Fine funzione StampaArray");

    }



    // Start is called before the first frame update
    void Start()
    {
        GeneraArray(dimensioneArray, valoreMassimo, valoreMinimo);
        StampaArray(array[dimensioneArray]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
