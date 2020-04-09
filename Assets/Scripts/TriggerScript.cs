using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    public GameObject Object;
    private Renderer renderer;
    private bool played = false;
    private bool trig = false;

    void Start()
    {
        renderer = Object.GetComponent<Renderer>();
        renderer.enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (played != true && other.tag == "Player")
        {
            trig = true;
        }
    }

    private IEnumerator RemoveForTime()
    {
        yield return new WaitForSeconds(0.5f);
        renderer.enabled = false;
    }

    private void Screaming()
    {
        if (played == false)
        {
            Object.GetComponent<AudioSource>().PlayOneShot(Object.GetComponent<AudioClip>());
        }
    }

    private void Triggering()
    {
        if (trig == true && played != true)
        {
            renderer.enabled = true;
            Object.GetComponent<AudioSource>().enabled = true;
            StartCoroutine(RemoveForTime());
            played = true;
        }
    }

    void Update()
    {
        Triggering();
    }
}
