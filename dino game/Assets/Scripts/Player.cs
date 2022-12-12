using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jump = 400f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();   
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jump));
        }

        if (Input.touchCount >0)
        {
            Touch dokunma = Input.GetTouch(0);

            if (dokunma.phase == TouchPhase.Began)
            {
                rb.AddForce(new Vector2(0, jump));
            }
        }        


        
    }


}
