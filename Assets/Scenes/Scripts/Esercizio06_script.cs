using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Esercizio06_script : MonoBehaviour
{
    public int[] randomArray = new int[20];
    public int[] sommaArray = new int[2];
    public int[] stampaArray = new int[20];



    void GeneraArray()
    {
        for (int i = 0; i < randomArray.Length; i++) 
        {
           
            randomArray[i] = Random.Range(0, 101);
            UnityEngine.Debug.Log("Elemento " + i + ": " + randomArray[i]); 

        }

    }

    void SommaArray()
    {
        int somma = 0;
        for (int i = 0; i < sommaArray.Length; i++) 
        {
            somma = somma + sommaArray[i];
        }
        UnityEngine.Debug.Log("Questa è la somma: " + somma);
    }

    void StampaArray()
    {
        for (int i = 0; i < stampaArray.Length; i++)
        { 
            UnityEngine.Debug.Log("Questi sono tutti gli elementi dell'array: " + stampaArray[i]);
        }
           


    }

   


    // Start is called before the first frame update
    void Start()
    {
        GeneraArray();
        SommaArray();
        StampaArray();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
