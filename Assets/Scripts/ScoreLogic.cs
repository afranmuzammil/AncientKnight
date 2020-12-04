using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreLogic : MonoBehaviour
{
    public int points = 0;
    public int coins = 0;

    public int CoinsGiven;
    public int HealthBoostGiven;
    public int NumEnemyGiven;

    public int minCoinsToCollect;

    public float finalScore;

    public Text ScoreText;
    public Exitlayer exitlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
       
    public  void KilledEnemy()
    {
        points =+ 10;
    }

    public void CoinTaken()
    {
        points =+ 5;
        coins =+ 1;
    }

    public void HealthTaken()
    {
        points =- 2;
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = finalScore.ToString("");


        int addUpScore = points + coins ;

        int divideScore = CoinsGiven + HealthBoostGiven + NumEnemyGiven;

        finalScore = addUpScore / divideScore;
        if (minCoinsToCollect == coins)
        {
            exitlayer.DisableTrigger();
        }

    }


}
