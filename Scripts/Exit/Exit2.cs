﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Time.timeScale == 1) && (Input.GetKeyDown("escape"))){
            Application.Quit();
        }
    }
}
