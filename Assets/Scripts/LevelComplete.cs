using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int ScenceNumber;
    public int NextLevelNumer;
    public GameObject OpsMenu;
    public GameObject LevelOver;
    
    public void NextLevel()
    {
        SceneManager.LoadScene(NextLevelNumer);
    }

    //public void OnPressPlay()
    //{
        
    //    Time.timeScale = 1f;
    //}
    public void OnPressRestart()
    {
        SceneManager.LoadScene(ScenceNumber);
        Time.timeScale = 1f;
       // KnightHealth.Health = 100;
        LevelOver.SetActive(false);
    }
    public void LevelLostRestart()
    {
       
        SceneManager.LoadScene(ScenceNumber);
        Time.timeScale = 1f;
        LevelOver.SetActive(false);
    }

    public void OnPressOps()
    {
        LevelOver.SetActive(false);
        OpsMenu.SetActive(true);

    }

  

    public void Quit()
    {

        Application.Quit();
    }
}
