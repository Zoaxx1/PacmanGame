using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
    int i = 0;
    AudioSource audio;
    Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        audio = GetComponent<AudioSource>();
        audio.enabled = false;
    }

    void Update()
    {
        if (Time.timeScale == 0){
            i++;
        }else if ((Time.timeScale == 1) && (i < 10000)){
            i = 10000;
            }
        if ((Time.timeScale == 0) && (i >= 10000) && (ScoreManager.scoreManager.score < 100))
        {
            canvas.enabled = true;
            audio.enabled = true;
        }
              
    }                    
    

}
