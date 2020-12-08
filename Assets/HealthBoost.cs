using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    public ScoreLogic scoreLogic;

    private void Start()
    {
       // scoreLogic.GetComponent<ScoreLogic>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            // Debug.Log("collition");
            SoundManagerScript.PlaySound("healthLoad");
            Destroy(gameObject);
            KnightHealth.Health += 20;
            scoreLogic.HealthTaken();
            return;
        }
    }
}
