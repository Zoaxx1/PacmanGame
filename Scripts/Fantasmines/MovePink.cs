using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePink : MonoBehaviour
{
    public Transform[] points;
    int i = 0;
    public float speed;
    public float time;
    private float guard = 0.8f;
    private float changetime = 0.24f;
    private float mediumchange = 0.8f;
    private float longchange = 1.1f;
    private float superchange = 1.3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time -= Time.deltaTime;
        Vector2 move = Vector2.MoveTowards(transform.position, points[i].position, speed);
        if (transform.position != points[i].position)
        {
            GetComponent<Rigidbody2D>().MovePosition(move);
        }
        //Incremento de i
        if (time <= 0)
        {
            i++;
            time = guard;
            //Cambio de tiempo segun el lugar del mapa que recorra
            //Espacios Cortos
            if ((i >=5 ) && (i <= 7))
            {
                time = changetime;
            }
            else if ((i >= 9) && (i <= 11))
            {
                time = changetime;
            }
            else if ((i >= 17) && (i <= 20))
            {
                time = changetime;
            }else if((i==14) || (i == 16) || (i == 18) || (i == 19))
            {
                time = changetime;
            }//Espacios Medianos
            else if ((i == 1) || (i == 4))
            {
                time = mediumchange;
            }//Espacios Largos
            else if ((i == 2) && (i==12))
            {
                time = longchange;
            }//Espacios Muy Largos
            else if (i == 12)
            {
                time = superchange;
            }

            if (i == 21)
            {
                i = 1;
            }
        }

        if ((Time.timeScale == 0) && (ScoreManager.scoreManager.score == 100))
        {
            Destroy(gameObject);
        }
    }
}
