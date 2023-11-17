using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RudyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");

       
    }
    private void FixedUpdate()
    {
        Vector2 postion = rigidbody2d.position;
        postion.x = postion.x + 3.0f * horizontal * Time.deltaTime;
        postion.y = postion.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(postion);
    }
}    
    