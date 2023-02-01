using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGhostAnimation : MonoBehaviour
{
    public Animator animator;

    public int animType = 1;

    // Start is called before the first frame update
    void Awake()
    {
        switch (animType)
        {
            case 0:
                animator.SetBool("default", true);
                animator.SetBool("left", false);
                animator.SetBool("right", false);
                animator.SetBool("yeet", false);
                break;
            case 1:
                animator.SetBool("default", false);
                animator.SetBool("left", true);
                animator.SetBool("right", false);
                animator.SetBool("yeet", false);
                break;
            case 2:
                animator.SetBool("default", false);
                animator.SetBool("left", false);
                animator.SetBool("right", true);
                animator.SetBool("yeet", false);
                break;
            case 3:
                animator.SetBool("default", false);
                animator.SetBool("left", false);
                animator.SetBool("right", false);
                animator.SetBool("yeet", true);
                break;
            default:
                animator.SetBool("default", true);
                animator.SetBool("left", false);
                animator.SetBool("right", false);
                animator.SetBool("yeet", false);
                break;
        }
    }
}
