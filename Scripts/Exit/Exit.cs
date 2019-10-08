using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    Canvas canvas;
    int i = 0;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if((Time.timeScale == 0))
        {
            i++;
        }else if((Time.timeScale == 1) && (i < 10000))
        {
            i = 10000;
        }
        if((Time.timeScale == 0) && (i >= 10000))
        {
            canvas.enabled = true;
            Quit();
        }
    }

    public void Quit()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}
