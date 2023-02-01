using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{

	public Text nameText;
	public Text dialogueText;
	public Text buttonText;

	public Animator[] animator;
	public new AudioSource[] audio;

	private Queue<string> names;
	private Queue<string> sentences;

	// Use this for initialization
	void Awake()
	{
		names = new Queue<string>();
		sentences = new Queue<string>();
	}

	public void StartDialogue(Dialogue dialogue)
	{
		sentences.Clear();
		names.Clear();

		foreach (string name in dialogue.name)
		{
			names.Enqueue(name);
		}

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{
		if (names.Count == 0 && sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		if(names.Count == 1 && sentences.Count == 1)
        {
			buttonText.text = "Start >>>";
        }

		string name = names.Dequeue();
		nameText.text = name;

		SetAnimation(name);
		SetAudio(name);

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return new WaitForSeconds(.02f);
		}
	}

	void SetAnimation(string name)
    {
		if (name == "Pepe")
		{
			animator[0].SetBool("isTalking", true);
			animator[1].SetBool("isTalking", false);
		}
		else if (name == "Master")
		{
			animator[0].SetBool("isTalking", false);
			animator[1].SetBool("isTalking", true);
		}
		else
		{
		};
    }

	void SetAudio(string name)
    {
		if (name == "Pepe")
		{
			audio[0].Play();
		}
		else if (name == "Master")
		{
			audio[1].Play();
		}
		else
		{
		};
	}

	void EndDialogue()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}