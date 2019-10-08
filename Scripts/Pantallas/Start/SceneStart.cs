using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneStart : MonoBehaviour
{
    AudioSource audio = new AudioSource();
    Text cuenta;
    Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        canvas = GetComponent<Canvas>();        
        canvas.enabled = true;
        audio = GetComponent<AudioSource>();
        audio.enabled = true;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            canvas.enabled = false;
            audio.enabled = false;
            Time.timeScale = 1;
            Destroy(this);
        }
    }
}
