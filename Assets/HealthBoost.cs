using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
           // Debug.Log("collition");
           
            Destroy(gameObject);
            KnightHealth.Health += 20;
            return;
        }
    }
}
