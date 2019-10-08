using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePacman : MonoBehaviour
{
    public float speed = 3;

    AudioSource wakaka = new AudioSource();

    // Start is called before the first frame update
    void Start()
    {
        wakaka = GetComponent<AudioSource>();
        wakaka.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right") && (Time.timeScale == 1))
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
            gameObject.GetComponent<Animator>().SetBool("DirX", false);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            wakaka.enabled = true;
        }
        if (Input.GetKey("left") && (Time.timeScale == 1))
        {
            gameObject.transform.Translate((-1*speed) * Time.deltaTime, 0, 0);
            gameObject.GetComponent<Animator>().SetBool("DirX", false);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            wakaka.enabled = true;
        }
        if (Input.GetKey("up") && (Time.timeScale == 1))
        {
            gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
            gameObject.GetComponent<Animator>().SetBool("DirY", false);
            wakaka.enabled = true;
        }
        if (Input.GetKey("down") && (Time.timeScale == 1))
        {
            gameObject.transform.Translate(0, (-1*speed) * Time.deltaTime, 0);
            gameObject.GetComponent<Animator>().SetBool("DirY", false);
            wakaka.enabled = true;
        }
        if(!Input.GetKey("right") && !Input.GetKey("left") && !Input.GetKey("up") && !Input.GetKey("down"))
        {
            gameObject.GetComponent<Animator>().SetBool("DirX", true);
            gameObject.GetComponent<Animator>().SetBool("DirY", true);
            wakaka.enabled = false;
        }


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Pared1")
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 10.34f, gameObject.transform.position.y + 0f, gameObject.transform.position.z);
        }
        if(collision.transform.tag == "Pared2")
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + -10.34f, gameObject.transform.position.y + 0f, gameObject.transform.position.z);
        }
        if(collision.transform.tag == "Enemies")
        {
            Destroy(gameObject);
            Destroy(this);
            Time.timeScale = 0;
        }
    }

    
}
