using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class RightLeft : MonoBehaviour
{
    private int direction = -1;
    public float speed = 0.5f;
    void Start()
    {
        transform.position = new Vector3(1f, 0.0f, 0.0f);
       
    }
    void Update()
    {
        if (transform.position.x>=11f || transform.position.x <= 1f)
        {
            direction *= -1;
        }
      
        transform.Translate(speed*direction, 0f, 0f);
    }
}

