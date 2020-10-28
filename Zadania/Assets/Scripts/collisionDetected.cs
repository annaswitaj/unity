using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class collisionDetected : MonoBehaviour
{

   private int sum=0;

    private void OnCollisionEnter(Collision other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.gameObject.tag == "enemy")
        {
            sum++;
            Debug.Log("Triggered by Enemy : " +sum);
        }
    }
}
