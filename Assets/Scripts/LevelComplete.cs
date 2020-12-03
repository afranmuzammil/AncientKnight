using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int ScenceNumber;
    public GameObject OpsMenu;
    public GameObject LevelOver;
    public void NextLevel()
    {
        SceneManager.LoadScene(2);
    }

    //public void OnPressPlay()
    //{
        
    //    Time.timeScale = 1f;
    //}
    public void OnPressRestart()
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
