using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    [SerializeField] private Character player;
    [SerializeField] private GameObject aura;
    [SerializeField] private GameObject selectionMenu;
    [SerializeField] private GameObject challengeMenu;
    private SpriteRenderer rend;

    void Start()
    {
        rend = aura.GetComponent<SpriteRenderer>();
        Time.timeScale = 0f;
    }

    public void characterGreen()
    {
        player.GetComponent<CharacterMovement>().MoveSpeed = 3;
        selectionMenu.SetActive(false);
        challengeMenu.SetActive(true);
        Time.timeScale = 1f;
    }

    public void characterBlue()
    {
        rend.color = Color.blue;
        player.GetComponent<Health>().maxHealth = 15f;
        player.GetComponent<Health>().initialHealth = 15f;
        player.GetComponent<Health>().CurrentHealth = 15f;
        selectionMenu.SetActive(false);
        challengeMenu.SetActive(true);
        Time.timeScale = 1f;
    }

    public void characterRed()
    {
        rend.color = Color.red;
        player.GetComponent<CollectFruit>().healpoint = 2;
        selectionMenu.SetActive(false);
        challengeMenu.SetActive(true);
        Time.timeScale = 1f;
    }

}
