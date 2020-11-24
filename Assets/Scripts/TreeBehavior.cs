using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
            return;
        

        foreach (Transform tChild in transform)
        {
            Rigidbody2D childRigidBody = tChild.gameObject.GetComponent<Rigidbody2D>();
            childRigidBody.gravityScale = 2.0f;
        }
            
    }
}
