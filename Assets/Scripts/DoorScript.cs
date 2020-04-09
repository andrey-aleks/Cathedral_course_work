using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator _animator;

    public bool _isInTrigger = false;

    public bool _isOpen = false;


    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInTrigger = false;
        }
    }
/* НУЖНО ЛИ ЭТО?????
    private void OnTriggerStay(Collider other)
     {
         if (Input.GetKeyDown(KeyCode.E) && other.tag == "Player" )
         {
             _animator.SetBool("open", true);
         }
         */
    void Update()
    {
        if (_isInTrigger) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _isOpen = !_isOpen;
                _animator.SetBool("open", _isOpen);
            }
        }
    }
}
