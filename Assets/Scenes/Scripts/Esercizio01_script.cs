using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio01_script : MonoBehaviour
{
    public int index = 5;
    public int num = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        while (index > 0)
        {
            num++;
            Debug.Log("questo è il valore di num: " + num);
            index--;
        }
    }
}
