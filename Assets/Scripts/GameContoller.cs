using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameContoller : MonoBehaviour
{

    public GameObject OpsMenu;
    public GameObject MainMenu;


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClickOptions()
    {
        OpsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }


    public void OnClickBack()
    {
        OpsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
