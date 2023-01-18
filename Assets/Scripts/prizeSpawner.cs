using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class prizeSpawner : MonoBehaviour
{
    public GameObject prize;
    public static int Amount;
    void Start()
    {
        for (int i = 0; i < Amount; i++)
        {
            Vector3 vectorPos = new Vector3(Random.Range(-19, 19), 0.5f, Random.Range(-19, 19));
            Instantiate(prize, vectorPos, transform.rotation, transform);
        }
    }

    
    void Update()
    {
        
    }
}
