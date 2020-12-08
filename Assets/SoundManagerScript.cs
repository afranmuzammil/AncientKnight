using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip PlayerHitSound, PlayerFireSound ,CoinTaken,healthTaken, PlayerDeathSound,BlastSound,WinSound,loseSound,PlayerAttack, enemeyAttack,SenceTransSound,buttonClicSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHitSound = Resources.Load<AudioClip>("PlayerHit");
        PlayerFireSound = Resources.Load<AudioClip>("Shoot");
        CoinTaken = Resources.Load<AudioClip>("Coins");
        healthTaken = Resources.Load<AudioClip>("healthLoad");
        PlayerDeathSound = Resources.Load<AudioClip>("PlayerDead");
        BlastSound = Resources.Load<AudioClip>("BlastSound");
        WinSound = Resources.Load<AudioClip>("stinger_win");
        loseSound = Resources.Load<AudioClip>("stinger_lose");
        PlayerAttack = Resources.Load<AudioClip>("playerAttackSound");
        enemeyAttack = Resources.Load<AudioClip>("EnamyAtack");
        SenceTransSound = Resources.Load<AudioClip>("transition");
        buttonClicSound = Resources.Load<AudioClip>("buttonSound");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "PlayerHit":
                audioSrc.PlayOneShot(PlayerHitSound);
                break;
            case "Shoot":
                audioSrc.PlayOneShot(PlayerFireSound);
                break;
            case "Coins":
                audioSrc.PlayOneShot(CoinTaken);
                break;
            case "healthLoad":
                audioSrc.PlayOneShot(healthTaken);
                break;
            case "PlayerDead":
                audioSrc.PlayOneShot(PlayerDeathSound);
                break;
            case "BlastSound":
                audioSrc.PlayOneShot(BlastSound);
                break;
            case "stinger_win":
                audioSrc.PlayOneShot(WinSound);
                break;
            case "stinger_lose":
                audioSrc.PlayOneShot(loseSound);
                break;
            case "playerAttackSound":
                audioSrc.PlayOneShot(PlayerAttack);
                break;
            case "EnamyAtack":
                audioSrc.PlayOneShot(enemeyAttack);
                break;
            case "transition":
                audioSrc.PlayOneShot(SenceTransSound);
                break;
            case "buttonSound":
                audioSrc.PlayOneShot(buttonClicSound);
                break;
        } 
    }
}
