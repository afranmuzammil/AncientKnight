using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightHealth : MonoBehaviour
{
    public float Health = 100f;
    //public GameObject Shield;
    public Animator animator;



    private void Update()
    {
        if (Health <= 0)
        {
           // animator.SetTrigger("Death");
            DestroyGameObject();

        }

        //white dizzzy logic
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "E_sword")
        {
            --Health;
            if (Health >= 0)
            {

                //  Debug.Log("collition with the player");
                // m_animator.SetBool("Hurt", true);
                animator.SetTrigger("hurt");
            }

        }
        else if (col.gameObject.tag == "E2_sword")
        {
            Health -= 2;
            if (Health >= 0)
            {

                //  Debug.Log("collition with the player");
                // m_animator.SetBool("Hurt", true);
                animator.SetTrigger("hurt");
            }
        }


    }
    void DestroyGameObject()
    {
        Destroy(gameObject, 1f);
    }




}
