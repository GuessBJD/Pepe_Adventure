using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            TriggerInvincible();
        }
    }

    public void TriggerInvincible()
    {
        FindObjectOfType<InvincibleManager>().startInvincible();
    }
}


