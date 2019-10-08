using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRed : MonoBehaviour
{
    public Transform[] points;
    int i = 0;
    public float speed;
    public float time;
    private float guard = 0.77f;
    private float changetime = 0.26f;
    private float mediumchange = 0.8f;
    private float longchange = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time -= Time.deltaTime;
        Vector2 move = Vector2.MoveTowards(transform.position, points[i].position, speed);
        if(transform.position != points[i].position)
        {
            GetComponent<Rigidbody2D>().MovePosition(move);
        }       

        //Incremento de i
        if(time <= 0)
        {
            i++;
            time = guard;
            //Cambio de tiempo segun el lugar del mapa que recorra
            //Espacios Cortos
            if ((i >= 4) && (i <= 9))
            {
                time = changetime;
            }
            else if ((i >= 11) && (i <= 16) && (i != 15))
            {
                time = changetime;
            }//Espacios Medianos
            else if ((i == 15) || (i == 2) || (i == 18))
            {
                time = mediumchange;
            }//Espacios Largos
            else if (i == 10)
            {
                time = longchange;
            }
            if (i >= 19)
            {
                i = 1;
                time = mediumchange;
            }
        }
        
        if((Time.timeScale == 0) && (ScoreManager.scoreManager.score == 100))
        {
            Destroy(gameObject);
        }
    }
}
