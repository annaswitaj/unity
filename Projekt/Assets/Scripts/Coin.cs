using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static Player;

public class Coin : MonoBehaviour
{
   
    public GameHandler GH;
    public Player Py;
 

    public AudioClip coinSound;
    void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
        Py= GameObject.Find("Player").GetComponent<Player>();
        GH.coins = PlayerPrefs.GetInt("CurrentCoins");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.layer == 9)
        {
            GH.coins++;
            PlayerPrefs.SetInt("CurrentCoins", GH.coins);

            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
           Py.superJumpsRemaining++;
        }
    }
}
