using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPause : MonoBehaviour
{
    bool pause = false;
    Canvas canvas;
    
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            pause = !pause;
            canvas.enabled = pause;
            Time.timeScale = (pause) ? 0 : 1f;
        }
    }
}
