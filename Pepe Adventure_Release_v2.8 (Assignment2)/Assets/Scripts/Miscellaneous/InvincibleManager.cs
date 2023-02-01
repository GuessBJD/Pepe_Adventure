using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibleManager : MonoBehaviour
{
    public float duration = 10f;
    
    [SerializeField] private GameObject PlayerShield;
    [SerializeField] private GameObject player;

    public void startInvincible()
    {
        StartCoroutine(invincibleMode());
    }

    IEnumerator invincibleMode()
    {
        player.GetComponent<Health>().invis = true;

        PlayerShield.SetActive(true);

        yield return new WaitForSeconds(10f);

        PlayerShield.SetActive(false);

        player.GetComponent<Health>().invis = false;

    }
}
