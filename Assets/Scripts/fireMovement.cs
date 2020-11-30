using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireMovement : MonoBehaviour
{
    public float fireSpeed = 2f;
    public GameObject m_object;
    public GameObject blastAnim;
    GameObject blastanimation;
    private Rigidbody2D rb;
    Vector3 thescale;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (CharcterController.m_FacingRight == true)
        {
            transform.Translate(-Vector2.left * fireSpeed * Time.fixedDeltaTime);
            Destroy(blastanimation, 0.5f);
        }
        else if (CharcterController.m_FacingRight == false)
        {
            thescale = transform.localScale;

            thescale.x *= -1;

            transform.localScale = thescale;

            transform.Translate(Vector2.left * fireSpeed * Time.fixedDeltaTime);
            Destroy(blastanimation, 0.5f);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {


        blastanimation = Instantiate(blastAnim, m_object.transform.position, Quaternion.identity);

        Destroy(m_object, 0.1f);
        Destroy(blastanimation, 0.2f);
    }
}
