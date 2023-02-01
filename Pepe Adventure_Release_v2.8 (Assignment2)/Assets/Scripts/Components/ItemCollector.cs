using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int fruit = 0;

    //private float fruitnum = 0; //number of fruits we want
    //private Character playableCharacter;
    [SerializeField] private int healpoint = 1;
    Health playerHealth;

    private void Awake()
    {
        playerHealth = FindObjectOfType<Health>();
    }

    //connect the player with the coin
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            if (playerHealth.CurrentHealth == playerHealth.maxHealth)
            {
                return;
            }
            Destroy(collision.gameObject);
            fruit++;
            playerHealth.CurrentHealth += healpoint;
            UIManager.Instance.UpdateHealth(playerHealth.CurrentHealth, playerHealth.maxHealth);
        }
        /**if(fruit.transform.tag == "Fruit")
        {
            if(playableCharacter.GetComponent<Health>().CurrentHealth == playableCharacter.GetComponent<Health>().maxHealth)
            {
                return;
            }
            Destroy(fruit.gameObject);
            playableCharacter.GetComponent<Health>().CurrentHealth++;
        }**/
    }


}
