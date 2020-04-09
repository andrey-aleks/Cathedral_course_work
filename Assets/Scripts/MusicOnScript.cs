using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnScript : MonoBehaviour

{
    public GameObject gameObject;
    private AudioSource audio;
    private bool playing;

    private void Start()
    {
        playing = false;
        audio = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && playing == false)
        {
            audio.Play();
            playing = true;
        }
    }
}