using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacdot : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager.scoreManager.RaiseScore(1);

        

        if(collision.transform.tag == "Pacman")
        {
            Destroy(gameObject);
        }
        
    }
}
