using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        print(rb);
        rb.velocity = transform.forward * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
