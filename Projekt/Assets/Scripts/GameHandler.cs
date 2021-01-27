using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameHandler : MonoBehaviour
{
    public Text CoinText;
    public int coins=0;

    public Text Clock;
   public float timer=0;
   
    void Update()
    {

        timer += Time.deltaTime;
            
        Clock.text = timer.ToString("00") ;
        CoinText.text = "Coins : " + coins;
        
    }
}
