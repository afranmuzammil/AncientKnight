using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    public Animator m_animator;

    

    // Update is called once per frame
    void Update()
    {
        if (EnemyScript.TargetInRange)
        {
            m_animator.SetBool("Walk", true);
        }
        else if(!EnemyScript.TargetInRange)
        {
            m_animator.SetBool("Walk", false);
        }

        if (EnemyScript.InattackRange)
        {
            m_animator.SetBool("Attack1", true);
        }
        else if (!EnemyScript.InattackRange)
        {
            m_animator.SetBool("Attack1", false);
        }


        if (EnemyScript.HealthIsNull)
        {
            m_animator.SetTrigger("Death");
        }
        //else if (!EnemyScript.HealthIsNull)
        //{
        //    m_animator.SetBool("Death", false);
        //}

        if (EnemyScript.gotHurt)
        {
            m_animator.SetBool("Hurt", true);
        }
        else if (!EnemyScript.gotHurt)
        {
            m_animator.SetBool("Hurt", false);
            //m_animator.SetTrigger("Recover");
        }



    }
}
