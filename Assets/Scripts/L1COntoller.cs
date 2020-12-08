using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class L1COntoller : MonoBehaviour
{
    public GameObject PauseMenu; 
    public GameObject OpsMenu;
    public GameObject LevelLost;
    public int ScenceNumber;
    public static float Coins = 0;
    public Text CoinText;
    // Update is called once per frame


    private void Start()
    {
        
    }
    void Update()
    {
        CoinText.text = Coins.ToString("");
        //Debug.Log(Coins);
    }

    public void OnPressPause()
    {
        SoundManagerScript.PlaySound("buttonSound");
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnPressPlay()
    {
        SoundManagerScript.PlaySound("buttonSound");
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnPressRestart()
    {
        SoundManagerScript.PlaySound("buttonSound");
        SceneManager.LoadScene(ScenceNumber);
        OnPressPlay();
    }
    public void Quit()
    {
        SoundManagerScript.PlaySound("buttonSound");
        Application.Quit();
    }
    public void OnPressOps()
    {
        SoundManagerScript.PlaySound("buttonSound");
        PauseMenu.SetActive(false);
        OpsMenu.SetActive(true);
       
    }
    public void OnClickBack()
    {
        SoundManagerScript.PlaySound("buttonSound");
        OpsMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void OnClickBackLL()
    {
        SoundManagerScript.PlaySound("buttonSound");
        OpsMenu.SetActive(false);
        LevelLost.SetActive(true);
    }




}
