using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public Rigidbody2D platformrb;
    public bool isOnPlatform;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            platformrb = other.gameObject.GetComponent<Rigidbody2D>();
            isOnPlatform = true;
        }

    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOnPlatform = false;
        }


    }

    void FixedUpdate()
    {
        Debug.Log("Player in collider");
        if (isOnPlatform)
        {
            player.transform.SetParent(this.transform);
            platformrb.AddForce(1000 * (rb.velocity - platformrb.velocity));
            Debug.Log("Player entered");
        }

        else
        {
            player.transform.SetParent(null);
            Debug.Log("Player exited");
        }
    }
}
