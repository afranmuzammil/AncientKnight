using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoins : MonoBehaviour
{

    public ScoreLogic scoreLogic;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            // Debug.Log("collition");
            SoundManagerScript.PlaySound("Coins");
            Destroy(gameObject);
            scoreLogic.CoinTaken(); 
            L1COntoller.Coins += 1;
            //return;
        }
    }
}
