using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawbypd : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.transform.Rotate(0f,0f,2.5f);
    }
}
