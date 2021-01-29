using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject PanelWin;
    public Text YourScore;
    //public Text YourTime;
    [SerializeField] private Transform player;
    //public Text Clock;

    private void Start()
    {
        YourScore.text ="Your Score: " + PlayerPrefs.GetInt("CurrentCoins").ToString();
        //YourTime.text = "Your Time: " + PlayerPrefs.GetInt("Time").ToString();
    }

    void Update()
    {
        YourScore.text = "Your Score: " + PlayerPrefs.GetInt("CurrentCoins").ToString();
       // YourTime.text = "Your Time: " + PlayerPrefs.GetInt("Time").ToString();

    }
    void OnTriggerEnter(Collider other)

    {
        PanelWin.SetActive(true);

    }
   
}
