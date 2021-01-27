using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject PanelWin;

    [SerializeField] private Transform player;
    public Text Clock;
    public float seconds, minutes;

    void Update()
    {
        Clock.text = "00";
    
    }
    void OnTriggerEnter(Collider other)

    {
        PanelWin.SetActive(true);

    }
   
}
