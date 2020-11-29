using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windPUsh : MonoBehaviour
{
    public float windSpeed = 2f;
    //public GameObject m_object;

    private Rigidbody2D rb;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        transform.Translate(-Vector2.left * windSpeed * Time.fixedDeltaTime);
    }

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     Destroy(m_object, 0.2f);
    // }
}
