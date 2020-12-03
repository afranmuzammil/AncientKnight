using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightHealth : MonoBehaviour
{
    public static int Health = 100;
    //public GameObject Shield;
    public Animator animator;
    public GameObject LostLevel;

    public HealthBarScript HealthBar;

    private void Start()
    {
        HealthBar.SetMaxHealth(Health);
    }

    private void Update()
    {
      //  Debug.Log(Health);
        HealthBar.SetHealth(Health);
        if (Health <= 0)
        {
            LostLevel.SetActive(true);
            Time.timeScale = 0f;
            Health = 100;
           //animator.SetTrigger("Death");
            //DestroyGameObject();
            return;

        }

        //white dizzzy logic
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "E_sword")
        {
            --Health;
            animator.SetTrigger("hurt");
            //if (Health >= 0)
            //{

            //    //  Debug.Log("collition with the player");
            //    // m_animator.SetBool("Hurt", true);
            //    animator.SetTrigger("hurt");
            //}

        }
        else if (col.gameObject.tag == "E2_sword")
        {
            Health -= 2;
            animator.SetTrigger("hurt");
            //if (Health >= 0)
            //{

            //    //  Debug.Log("collition with the player");
            //    // m_animator.SetBool("Hurt", true);
            //    animator.SetTrigger("hurt");
            //}
        }
        else if (col.gameObject.tag == "Opsticle")
        {
            Health -= 10;
            animator.SetTrigger("hurt");
         
        }


    }
    void DestroyGameObject()
    {
        Destroy(gameObject, 1f);
    }




}
