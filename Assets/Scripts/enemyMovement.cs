using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    Rigidbody rb;
    public GameObject player;
    public static bool doFreeze;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.None;
        Vector3 konum = new Vector3(Random.Range(-19, 19), 0.6f, Random.Range(-19, 19));
        transform.position = konum;
        doFreeze = false;
    }

    void Update()
    {
        Vector3 movement = player.transform.position - transform.position;

        rb.AddForce(movement*0.1f);
        
        if (doFreeze)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
