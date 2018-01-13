using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animator animator;
    bool doorOpen;

    private void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorOpen = true;
            Doors("Open");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (doorOpen)
        {
            doorOpen = false;
            Doors("Close");
        }
    }
    void Doors(string direction)
    {
        animator.SetTrigger(direction);
    }
}
