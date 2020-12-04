using UnityEngine;
using System.Collections;
using Pathfinding;

public class EnemyScript : MonoBehaviour
{


    public float lookRadius = 4f;
    public int EnemyHealth = 10;
    public Transform target;
    public Transform myTansfrom;
    public Transform E_SowrdPoint;
    public GameObject EnemySowrd;
    public EnemyAI enemyAI;
    public float AttackRange = 2f;
    public EHealthBar EhealthBar;
    public ScoreLogic scoreLogic;
    //  public Animator m_animator;

    public static bool TargetInRange = false;
    public static bool InattackRange = false;
    public static bool HealthIsNull = false;
    public static bool gotHurt = false;

   


    // Use this for initialization
    void Start()
    {
        EhealthBar.SetMaxHealth(EnemyHealth);
        // m_animator = GetComponent<Animator>();

        // aIPath.GetComponent<AIPath>();


    }

    // Update is called once per frame
    void Update()
    {
        ////Check if character just landed on the ground
        //if (!m_grounded && m_groundSensor.State())
        //{
        //    m_grounded = true;
        //    m_animator.SetBool("Grounded", m_grounded);
        //}

        ////Check if character just started falling
        //if (m_grounded && !m_groundSensor.State())
        //{
        //    m_grounded = false;
        //    m_animator.SetBool("Grounded", m_grounded);
        //}

        EhealthBar.SetHealth(EnemyHealth);

        // Move
        float distance = Vector2.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            TargetInRange = true;
            //  Debug.Log("in radius");
           GetComponent<EnemyAI>().enabled = true;
          
        }
        else
        {
            TargetInRange = false;
           
            GetComponent<EnemyAI>().enabled = false;
        }
        

        // -- Handle Animations --
        //Death
        if (EnemyHealth <= 0)
        {
            HealthIsNull = true;
            scoreLogic.KilledEnemy();
            DestroyGameObject();
            return;
           
        }
        else
        {
            HealthIsNull = false;
        }



        if (distance<=AttackRange)
        {
            InattackRange = true;
          
            GameObject E_sword = Instantiate(EnemySowrd, E_SowrdPoint.position, Quaternion.identity);
            Destroy(E_sword, 0.1f);
            //return;
        }
        else
        {
            InattackRange = false;
           
        }


    }


    private void OnCollisionEnter2D(Collision2D col)
    {

        //Debug.Log("collition");
        if (col.gameObject.tag == "sword")
        {
            --EnemyHealth;
            gotHurt = true;
            // Debug.Log("collition with the player");
            
        }
        else if (col.gameObject.tag == "fireBall")
        {
            EnemyHealth -= 2;
            gotHurt = true;
            Debug.Log("collition with the fireBall");
            

        }
        else
        {
            gotHurt = false;
           
        }

    }

    void DestroyGameObject()
    {
        Destroy(gameObject, 1f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
