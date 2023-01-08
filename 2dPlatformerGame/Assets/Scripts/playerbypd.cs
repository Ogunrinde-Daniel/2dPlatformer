using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbypd : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private bool dead;
    
    private float horizontalInput;

    [SerializeField]private int speed;
    [SerializeField]private int jumpForce;
    [SerializeField] private GameObject failPanel;
    [SerializeField] private GameObject winPanel;



    void Start()
    {
        dead = false;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (dead) return;
        horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (horizontalInput * speed, 0);
        flip(horizontalInput);

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Saw"))
        {
            fail();
        }

        if (collision.gameObject.CompareTag("Portal"))
        {
            win();
        }

    }

    void fail()
    {
        dead = true;
        failPanel.SetActive(true);

    }

    void win()
    {
        dead = true;
        winPanel.SetActive(true);

    }

    void flip(float direction)
    {
        if(direction > 0)
        {
            sr.flipX = false;
        }
        else if(direction < 0)
        {
            sr.flipX = true;
        }
    }

}
