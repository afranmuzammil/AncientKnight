using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class L1COntoller : MonoBehaviour
{
    public GameObject PauseMenu; 
    public GameObject OpsMenu;
    public int ScenceNumber;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPressPause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnPressPlay()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnPressRestart()
    {
        SceneManager.LoadScene(ScenceNumber);
        OnPressPlay();
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void OnPressOps()
    { 
        PauseMenu.SetActive(false);
        OpsMenu.SetActive(true);
       
    }
    public void OnClickBack()
    {
        OpsMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }




}
