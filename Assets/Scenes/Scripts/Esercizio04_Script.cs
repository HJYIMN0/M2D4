using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio04_Script : MonoBehaviour
{

    public int start = 5;
    public int amount =  3;

    // Start is called before the first frame update
    void Start()
    {
        int limite = start + amount;
        while (start <= limite)
        {
            Debug.Log(start);
            start++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
