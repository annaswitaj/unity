using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static Player;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    //Player.superJumpsRemaining=3;
    public GameHandler GH;
    public Player Py;


    public AudioClip coinSound;
    void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
        Py= GameObject.Find("Player").GetComponent<Player>();
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.layer == 9)
        {
            GH.coins++;
   

            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
           Py.superJumpsRemaining++;
        }
    }
}
