using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

    [SerializeField] float m_speed = 1.0f;
    [SerializeField] float m_jumpForce = 7.5f;

    public float lookRadius = 4f;
    public float EnemyHealth = 10f;
    public Transform target;
    public Transform myTansfrom;
    public Transform E_SowrdPoint;
    public GameObject EnemySowrd;
    private Animator m_animator;
    private Rigidbody2D m_body2d;
    private Sensor_Bandit m_groundSensor;
    private bool m_grounded = false;
    //private bool m_combatIdle = false;
    //private bool m_isDead = false;
    private bool TargetInRange = false;
    public KnightMoement knightMoement;

    // Use this for initialization
    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
        m_groundSensor = transform.Find("GroundSensor").GetComponent<Sensor_Bandit>();
        knightMoement.GetComponent<KnightFight>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check if character just landed on the ground
        if (!m_grounded && m_groundSensor.State())
        {
            m_grounded = true;
            m_animator.SetBool("Grounded", m_grounded);
        }

        //Check if character just started falling
        if (m_grounded && !m_groundSensor.State())
        {
            m_grounded = false;
            m_animator.SetBool("Grounded", m_grounded);
        }

        // // -- Handle input and movement --
        // float inputX = Input.GetAxis("Horizontal");

        // // Swap direction of sprite depending on walk direction
        // if (inputX > 0)
        //     transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        // else if (inputX < 0)
        //     transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        // Move
        float distance = Vector2.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            TargetInRange = true;
            //transform.LookAt(target);
            //m_body2d.transform.Translate(Vector2.left * m_speed * Time.fixedDeltaTime, myTansfrom);

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, transform.position.y, -5), m_speed * Time.deltaTime);

            //m_body2d.velocity = new Vector2(inputX * m_speed, m_body2d.velocity.y);
        }
        else
        {
            TargetInRange = false;
        }
        //Set AirSpeed in animator
        m_animator.SetFloat("AirSpeed", m_body2d.velocity.y);

        // -- Handle Animations --
        //Death
        if (EnemyHealth <= 0)
        {

            m_animator.SetTrigger("Death");
            DestroyGameObject();
            // else
            //m_animator.SetTrigger("Recover");

            //m_isDead = !m_isDead;
        }

        //Hurt
        // else if (Input.GetKeyDown("q"))
        //     m_animator.SetTrigger("Hurt");

        //Attack


        //Change between idle and combat idle
        // else if (Input.GetKeyDown("f"))
        //     m_combatIdle = !m_combatIdle;

        //Jump
        if (TargetInRange && knightMoement.jumped)
        {
            Debug.Log("jumping");
            m_animator.SetBool("jump1", true);
            m_grounded = false;
            m_animator.SetBool("Grounded", m_grounded);
            m_body2d.velocity = new Vector2(m_body2d.velocity.x, m_jumpForce);
            m_groundSensor.Disable(0.2f);
        }
        else
        {
            m_animator.SetBool("jump1", false);
        }

        if (TargetInRange)
        {
            m_animator.SetBool("Attack1", true);
            GameObject E_sword = Instantiate(EnemySowrd, E_SowrdPoint.position, Quaternion.identity);
            Destroy(E_sword, 0.1f);
        }
        else
        {
            m_animator.SetBool("Attack1", false);
        }

        //Run
        // else if (Mathf.Abs(inputX) > Mathf.Epsilon)
        //     m_animator.SetInteger("AnimState", 2);

        // //Combat Idle
        // else if (m_combatIdle)
        //     m_animator.SetInteger("AnimState", 1);

        // //Idle
        // else
        //     m_animator.SetInteger("AnimState", 0);
    }


    private void OnCollisionEnter2D(Collision2D col)
    {

        //Debug.Log("collition");
        if (col.gameObject.tag == "sword")
        {
            --EnemyHealth;
            //  Debug.Log("collition with the player");
            // m_animator.SetBool("Hurt", true);
            m_animator.SetTrigger("Hurt1");
        }
        else if (col.gameObject.tag == "fireBall")
        {
            EnemyHealth -= 2;
            // Debug.Log("collition with the fireBall");
            m_animator.SetTrigger("Hurt1");
            //m_animator.SetTrigger("Recover");

        }
        else
        {
            // m_animator.SetBool("Hurt1", false);
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
