using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickFall : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

   

    void OnCollisionEnter2D(Collision2D col)
    {
        Invoke("Fall", 1.5f);
        Destroy(gameObject, 2f);
    }

    void Fall()
    {
        rb.isKinematic = false;
    }
}
