﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameContoller : MonoBehaviour
{
    public Animator CrosFadeAnim;
    public GameObject OpsMenu;
    public GameObject MainMenu;

    public LevelLoad levelLoad;


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        //SceneManager.LoadScene(1);
        SoundManagerScript.PlaySound("buttonSound");
        //  Handheld.Vibrate();
        Vibration.Vibrate(100);
        levelLoad.LeadScence(1);
    }

    public void OnClickOptions()
    {
        SoundManagerScript.PlaySound("buttonSound");
        Vibration.Vibrate(100);
        OpsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Quit()
    {
        SoundManagerScript.PlaySound("buttonSound");
        Vibration.Vibrate(100);
        Application.Quit();
    }


    public void OnClickBack()
    {
        SoundManagerScript.PlaySound("buttonSound");
        Vibration.Vibrate(100);
        OpsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

   //IEnumerator LoadNextLevel(int LevelIndex)
   // {
   //     CrosFadeAnim.SetTrigger("Start");

   //     yield return new WaitForSeconds(1f);
   //     SceneManager.LoadScene(LevelIndex);

   // }
}
