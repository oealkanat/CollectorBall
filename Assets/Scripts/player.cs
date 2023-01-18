using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rb;
    public int eaten = 0;
    public TextMeshProUGUI guiText;
    public GameObject lostPanel;
    public GameObject winPanel;
    public TextMeshProUGUI rtText;
    public int touchesLeft = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        guiText.text = "Prizes Left: " + prizeSpawner.Amount.ToString();
        rtText.text = touchesLeft.ToString();
        eaten = 0;
        touchesLeft = 5;
    }
    void Update()
    {
        float axisX = Input.GetAxis("Horizontal");
        float axisZ = Input.GetAxis("Vertical");

        Vector3 eksen = new Vector3(axisX, 0, axisZ);

        rb.AddForce(eksen);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Prize")
        {
            Destroy(other.gameObject);
            eaten++;
            Debug.Log(eaten);

            guiText.text = "Prizes Left: " + (prizeSpawner.Amount - eaten).ToString();

            if (prizeSpawner.Amount == eaten)
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
                enemyMovement.doFreeze = true;

                winPanel.SetActive(true);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && touchesLeft != 1)
        {
            /*
            Vector3 enemyVelocity = new Vector3(
                (collision.rigidbody.mass / (rb.velocity.x * rb.mass)),
                0,
                (collision.rigidbody.mass / (rb.velocity.z * rb.mass))
                );
            collision.rigidbody.velocity = enemyVelocity;

            Vector3 playerVelocity = new Vector3(
                (rb.mass / (collision.rigidbody.velocity.x * collision.rigidbody.mass)),
                0,
                (rb.mass / (collision.rigidbody.velocity.z * collision.rigidbody.mass))
                );
            collision.rigidbody.velocity = enemyVelocity;
            rb.velocity = playerVelocity;
            */

            touchesLeft--;
            rtText.text = touchesLeft.ToString();
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            collision.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            touchesLeft--;
            lostPanel.SetActive(true);
        }
    }
}
