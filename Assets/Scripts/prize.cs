using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prize : MonoBehaviour
{
    Vector3 spinner;
    void Start()
    {
        spinner = new Vector3(0,100,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinner * Time.deltaTime);
    }
}
