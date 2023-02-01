using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCDialogueTrigger : MonoBehaviour
{
	public NPCDialogue dialogue;

    public GameObject trigger;
    public GameObject dialogueBox;

    private void OnTriggerEnter2D(Collider2D other)
    {
        dialogueBox.SetActive(true);
        TriggerDialogue();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        dialogueBox.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        dialogueBox.SetActive(false);
    }

	public void TriggerDialogue()
	{
		FindObjectOfType<NPCDialogueManager>().StartDialogue(dialogue);
	}

}