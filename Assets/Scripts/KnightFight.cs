using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class KnightFight : MonoBehaviour
{

    //public GameObject WindPush;
    public GameObject FireBoll;
    public GameObject BlastAnim;
    public GameObject SwordAttack;

    public Transform firePoint;
    //public Transform PushPoint;
    public Transform SwordPoint;
    private KnightMoement knightMoement;



    bool facingRight;

    //float fireSpeed = 2;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // bool facingRight = knightMoement.facingRight;
        // SwordAttack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //bool facingRight = knightMoement.facingRight;

       // attaking
        //if (Input.GetKey(KeyCode.Mouse0))
        //{
        //    // SwordAttack.SetActive(true);
        //    GameObject sword = Instantiate(SwordAttack, SwordPoint.position, Quaternion.identity);
        //    //  animator.SetBool("isAttacking", true);
        //    animator.SetTrigger("isAttacking1");
        //    Destroy(sword, 0.1f);

        //}
        //else if (Input.GetKeyUp(KeyCode.Mouse0))
        //{
        //    // SwordAttack.SetActive(false);
        //}
        //else
        //{
        //    animator.SetBool("isAttacking", false);
        //    // SwordAttack.SetActive(false);
        //}






        //casting(Pushing)
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    animator.SetBool("isCasting", true);
        //    GameObject Push = Instantiate(WindPush, PushPoint.transform.position, Quaternion.identity);

        //    Destroy(Push, 5f);
        //}
        //else
        //{
        //    animator.SetBool("isCasting", false);
        //}

        //Dashing(skidding)
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    animator.SetBool("crouch", true);

        //}
        //else
        //{
        //    animator.SetBool("crouch", false);
        //}

        //Striking
        if (CrossPlatformInputManager.GetButtonDown("Strike"))
        {
            //animator.SetTrigger("isStriking1");
            //GameObject Fire = Instantiate(FireBoll, firePoint.transform.position, Quaternion.identity);

            //Destroy(Fire, 5f);

           StartCoroutine( "PlayerStrike");
        }
        else
        {
           // animator.SetBool("isStriking", false);
        }




    }
    //mobile attack

    public void Attack()
    {
        // SwordAttack.SetActive(true);
        GameObject sword = Instantiate(SwordAttack, SwordPoint.position, Quaternion.identity);
        //  animator.SetBool("isAttacking", true);
        animator.SetTrigger("isAttacking1");
        Destroy(sword, 0.1f);

    }

    //public void Strike()
    //{
    //    StartCoroutine("PlayerStrike");
    //}

    IEnumerator PlayerStrike()
    {
       // animator.SetBool("isStriking", true); 
        animator.SetTrigger("isStriking1");
        
        yield return new WaitForSeconds(0.8f);

        GameObject Fire = Instantiate(FireBoll, firePoint.transform.position, Quaternion.identity);

        Destroy(Fire, 5f);



    }
}
