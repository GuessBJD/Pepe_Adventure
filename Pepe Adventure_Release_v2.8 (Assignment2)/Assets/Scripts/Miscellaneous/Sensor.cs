using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private bool trigger = false;

    bool getTrigger()
    {
        return trigger;
    }

    // Update is called once per frame
    void OnCollisionEnter2D()
    {
        trigger = true;
    }
    void OnCollisionExit2D()
    {
        trigger = false;
    }
}
