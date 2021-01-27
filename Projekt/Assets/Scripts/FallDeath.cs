using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FallDeath : MonoBehaviour
{
    //private Rigidbody rigidbody;
    public GameObject PanelLose;

    [SerializeField] private Transform player;

    void OnTriggerEnter(Collider other)

    {
       
        PanelLose.SetActive(true);
      
    }

}
    
