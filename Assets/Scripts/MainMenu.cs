using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject gameObject;
    private TextMesh Text;

    public bool quit;

    private void Start()
    {
                Text = gameObject.GetComponent<TextMesh>();
            }
    private void OnMouseEnter()
    {
        Text.color = Color.green;
    }

    private void OnMouseExit()
    {
        Text.color = Color.white;
    }

    [System.Obsolete]
    private void OnMouseUp()
    {
        if (quit == true)
        {
            // use this for builded game 
            // Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.LoadLevel("SampleScene");
        }
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            // use this for builded game 
            // Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
