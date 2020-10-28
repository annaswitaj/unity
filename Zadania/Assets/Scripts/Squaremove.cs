using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squaremove : MonoBehaviour
{
    public float speed = 0.5f;
   

    void Start()
    {
        transform.position = new Vector3(0f, 0f, 1f);

    }
    void Update()
    {  

        if ((transform.position.x == 0f && transform.position.z < 10f))
            {
            transform.Translate(0f, 0f, speed);
            if(transform.position.z>10f)
            {
                transform.position= new Vector3(0f, 0f, 10f);
            }
        }

        if((transform.position.z == 10f && transform.position.x < 9f))
            {
            transform.Translate(speed, 0f, 0f);
            if (transform.position.x > 9f)
            {
                transform.position = new Vector3(9f, 0f, 10f);
            }
        }

        if ((transform.position.x == 9f && transform.position.z> 0f))
        {
            transform.Translate(0f, 0f, -speed);
            if (transform.position.z < 1f)
            {
                transform.position = new Vector3(9f, 0f, 1f);
            }
        }

        if ((transform.position.x > 0f && transform.position.z == 1f))
        {
            transform.Translate(-speed, 0f, 0f);
            if (transform.position.x < 0f)
            {
                transform.position = new Vector3(0f, 0f, 1f);
            }
        }


    }
}
