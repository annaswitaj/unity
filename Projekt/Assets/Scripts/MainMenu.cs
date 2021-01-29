using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void NewGame()
    { 
        PlayerPrefs.SetInt("CurrentCoins", 00);
       // PlayerPrefs.SetInt("Time",00);
        SceneManager.LoadScene(1);
        //PlayerPrefs.SetInt("PlayerCurrentCoins", playerCoins);
       
    }

    public void QuitGme()
    {
        Debug.Log("Game Exitied");
        Application.Quit();
    }
}
