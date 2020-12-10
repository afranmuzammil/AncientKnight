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
    public Animator CrosFadeAnim;

    public void NextLevel()
    {
        //SceneManager.LoadScene(NextLevelNumer);
        StartCoroutine(LoadNextLevel(NextLevelNumer));
        Vibration.Vibrate(100);
    }

    //public void OnPressPlay()
    //{
        
    //    Time.timeScale = 1f;
    //}
    public void OnPressRestart()
    {
        SoundManagerScript.PlaySound("buttonSound");
        Vibration.Vibrate(100);
        SceneManager.LoadScene(ScenceNumber);
        Time.timeScale = 1f;
       // KnightHealth.Health = 100;
        LevelOver.SetActive(false);
    }
    public void LevelLostRestart()
    {

        SoundManagerScript.PlaySound("buttonSound");
        Vibration.Vibrate(100);
        SceneManager.LoadScene(ScenceNumber);
        Time.timeScale = 1f;
        LevelOver.SetActive(false);
    }

    public void OnPressOps()
    {
        SoundManagerScript.PlaySound("buttonSound");
        Vibration.Vibrate(100);
        LevelOver.SetActive(false);
        OpsMenu.SetActive(true);

    }

  

    public void Quit()
    {
        SoundManagerScript.PlaySound("buttonSound");
        Vibration.Vibrate(100);
        Application.Quit();
    }

    IEnumerator LoadNextLevel(int LevelIndex)
    {
        CrosFadeAnim.SetTrigger("Start");
        SoundManagerScript.PlaySound("transition");
        yield return new WaitForSeconds(1f);
        SoundManagerScript.PlaySound("transition");
        SceneManager.LoadScene(LevelIndex);

    }
}
