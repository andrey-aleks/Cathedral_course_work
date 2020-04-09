using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpenDoor : MonoBehaviour
{
    public GameObject animationObject;
    private Animator animator;
    private bool isInTrigger;
    private bool played;

    void Start()
    {
        animator = animationObject.GetComponent<Animator>();
        isInTrigger = false;
        played = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            isInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            isInTrigger = false;
        }
    }

  

    void Update()
    {
        if (isInTrigger && played == false) {
            animator.SetBool("open", true);
            FindObjectOfType<AudioManagerScript>().Play("DoorOpen");
            played = true;
        }
        
       
    }
}
