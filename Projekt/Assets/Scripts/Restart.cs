using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public GameHandler GH;
   
    public void RestartGame()
    {
         
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
       
        
    }
    public void RestartGameWhole()
    {
        PlayerPrefs.SetInt("CurrentCoins", 00);
        //PlayerPrefs.SetInt("Time",00);
        SceneManager.LoadScene(0); // loads start scene
                                                                   

    }

}
