using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMoement : MonoBehaviour
{
    public float speed = 10f;
    public float jumpHight = 100;
    private Rigidbody2D rb;
    public Animator animator;
    public static bool facingRight;
    public bool jumped = false;

    private float deafultSpeed = 10f;
    Vector3 thescale;

    Vector2 movement;
    float moveHorizontal = 0f;
    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
        rb = GetComponent<Rigidbody2D>();

    }



    // Update is called once per frame
    private void Update()
    {



        //Debug.Log(speed);
        // Debug.Log(thescale);
        // if (Input.GetKey(KeyCode.A))
        // {
        //     facingRight = false;
        //     Flip();

        //     transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);


        //     animator.SetBool("walk", true);
        // }
        // else if (Input.GetKey(KeyCode.D))
        // {
        //     facingRight = true;
        //     // thescale = transform.localScale;
        //     // thescale.x *= 1;
        //     // transform.localScale = thescale;
        //     transform.Translate(-Vector2.left * speed * Time.fixedDeltaTime);
        //     animator.SetBool("walk", true);
        // }
        // else
        // {
        //     animator.SetBool("walk", false);
        // }

        moveHorizontal = Input.GetAxisRaw("Horizontal") * speed;
        // float jump = Input.GetAxis("Jump");
        Flip(moveHorizontal);
        movement = new Vector2(moveHorizontal, 0);
        //rb.AddForce(movement * speed *Time.deltaTime,ForceMode2D.Impulse );

        if (moveHorizontal != 0)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }

        //  Debug.Log(moveHorizontal);

        if (Input.GetKeyDown("space"))
        {

            jumped = true;
            transform.Translate(Vector2.up * jumpHight * Time.fixedDeltaTime);
            animator.SetBool("isJump", true);
            //rb.AddForce(new Vector2(0, 3), ForceMode2D.Impulse);
        }
        else if (Input.GetKeyUp("space"))
        {
            jumped = false;
        }
        else
        {
            animator.SetBool("isJump", false);

        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 4;

        }
        else
        {
            speed = deafultSpeed;
        }
        animator.SetFloat("Speed", speed);


    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            thescale = transform.localScale;

            thescale.x *= -1;

            transform.localScale = thescale;
        }

    }

    void FixedUpdate()
    {
        rb.AddForce(movement * Time.fixedDeltaTime, ForceMode2D.Impulse);

    }
}
