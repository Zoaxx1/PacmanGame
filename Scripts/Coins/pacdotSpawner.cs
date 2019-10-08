using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacdotSpawner : MonoBehaviour
{
    int i, points = 99;
    public GameObject pacdotPrefab;
    float x = -4.5f;
    float y = -4.5f;
    float trasladoy = 1f;
    float trasladox = 1f;
    void Start()
    {
        for(i=0; i<points; i++)
        {
            if (y == 5.5f)
            {
                x += trasladox;
                y = (y-1) * -1f;
            }
            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(pacdotPrefab, position, rotation);
            y += trasladoy;
            

        }        
    }

}
