using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightEnable : MonoBehaviour
{
    public GameObject gameObject;
    private bool isInTrigger;
    public bool lightEnable;
    void Start()
    {
        isInTrigger = false;
        lightEnable = gameObject.GetComponent<Light>().enabled;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInTrigger = false;
        }
    }

    private void Triggering()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.E)) {
            if (lightEnable)
            {
                gameObject.GetComponent<Light>().enabled = false;
                lightEnable = false;
            }
            else
            {
                gameObject.GetComponent<Light>().enabled = true;
                lightEnable = true;
            }
        }
    }
    void Update()
    {
        Triggering();
    }
}
