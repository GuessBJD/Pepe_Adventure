using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewCharTest : MonoBehaviour
{
    [SerializeField] private Character player;
    [SerializeField] private GameObject aura;
    [SerializeField] private GameObject Greenaura;
    [SerializeField] private GameObject Blueaura;
    [SerializeField] private GameObject Redaura;
    [SerializeField] private GameObject selectionMenu;
    [SerializeField] private GameObject challengeMenu;
    [SerializeField] public TextMeshProUGUI abilitiesText;
    public int selectCharacter = 0;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = aura.GetComponent<SpriteRenderer>();
        Time.timeScale = 0f;
    }

    public void nextCharac()
    {
        selectCharacter += 1;
        if(selectCharacter > 2)
        {
            selectCharacter = 0;
        }
    }

    public void prevCharac()
    {
        selectCharacter -= 1;
        if (selectCharacter < 0)
        {
            selectCharacter = 2;
        }
    }

    public void select()
    {
        selectionMenu.SetActive(false);
        challengeMenu.SetActive(true);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(selectCharacter == 0)
        {
            player.GetComponent<CharacterMovement>().MoveSpeed = 3;
            player.GetComponent<Health>().maxHealth = 10f;
            player.GetComponent<Health>().initialHealth = 10f;
            player.GetComponent<Health>().CurrentHealth = 10f;
            player.GetComponent<CollectFruit>().healpoint = 1;
            rend.color = Color.green;
            Greenaura.SetActive(true);
            Redaura.SetActive(false);
            Blueaura.SetActive(false);
            abilitiesText.text = "Additional Move Speed";
        }

        if (selectCharacter == 1)
        {
            player.GetComponent<CharacterMovement>().MoveSpeed = 2;
            player.GetComponent<Health>().maxHealth = 15f;
            player.GetComponent<Health>().initialHealth = 15f;
            player.GetComponent<Health>().CurrentHealth = 15f;
            player.GetComponent<CollectFruit>().healpoint = 1;
            rend.color = Color.blue;
            Blueaura.SetActive(true);
            Redaura.SetActive(false);
            Greenaura.SetActive(false);
            abilitiesText.text = "Additional Health"; 
        }

        if (selectCharacter == 2)
        {
            player.GetComponent<CharacterMovement>().MoveSpeed = 2;
            player.GetComponent<Health>().maxHealth = 10f;
            player.GetComponent<Health>().initialHealth = 10f;
            player.GetComponent<Health>().CurrentHealth = 10f;
            player.GetComponent<CollectFruit>().healpoint = 2;
            rend.color = Color.red;
            Redaura.SetActive(true);
            Greenaura.SetActive(false);
            Blueaura.SetActive(false);
            abilitiesText.text = "Additional Healing";
        }
    }
}
