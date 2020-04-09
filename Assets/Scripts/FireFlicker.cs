using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlicker : MonoBehaviour
{
    public GameObject gameObject;
    public float minWait;
    public float maxWait;

    public float resultWait;

    void Start()
    {
   
    }

    private IEnumerable Wait()
    {
        resultWait = UnityEngine.Random.Range(minWait, maxWait);
        yield return new WaitForSeconds(4f);
    }

    private void Flickering()
    {
        gameObject.GetComponent<Light>().intensity = UnityEngine.Random.Range(7f, 10f);
        StartCoroutine(Wait());
    }
    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        Flickering();
    }
}
