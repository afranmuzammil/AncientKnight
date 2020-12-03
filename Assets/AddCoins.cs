using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            // Debug.Log("collition");

            Destroy(gameObject);
            L1COntoller.Coins = +1;
            return;
        }
    }
}
