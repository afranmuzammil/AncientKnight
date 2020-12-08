using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public Animator CrosFadeAnim;
   
   
    public void LeadScence(int levelIndex) {

        StartCoroutine(LoadNextLevel(levelIndex));
    }

    IEnumerator LoadNextLevel(int LevelIndex)
    {
        CrosFadeAnim.SetTrigger("Start");
        SoundManagerScript.PlaySound("transition");
        yield return new WaitForSeconds(1f);
        //SoundManagerScript.PlaySound("transition");
        SceneManager.LoadScene(LevelIndex);

    }
}
