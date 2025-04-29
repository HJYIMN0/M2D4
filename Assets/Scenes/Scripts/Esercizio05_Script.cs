using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio05_Script : MonoBehaviour
{
    int find = 130;
    public int[] count = new int[10];

    // Start is called before the first frame update
    void Start()
    {

        int x = find;
        count[Random.Range(0, count.Length)] = x;
        for (int fine = 0; fine < count.Length; fine++)
        {
            count[fine] = Random.Range(0, find + 1);
            


            if (count[fine] == find)
            {
                Debug.Log("Found! (" + count[fine] + ")");
            }
            else
            {
                Debug.Log("Not found! (" + count[fine] + ")");
            }
            
        }

        Debug.Log("Iterations finished.");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
