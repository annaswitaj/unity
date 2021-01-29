using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameHandler : MonoBehaviour
{
    public Text CoinText;
    public int coins;

   // public Text Clock;
   //public int timer;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("CurrentCoins");
        //timer = PlayerPrefs.GetInt("Time");
    }

    void Update()
    {

       // timer += (int)( Time.deltaTime);
     

        //Clock.text = "Time: "+timer;
        CoinText.text = "Coins : " + coins;
       //PlayerPrefs.SetInt("Time",timer); 
    }
}
