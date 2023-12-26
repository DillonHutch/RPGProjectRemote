using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    int speed = 8;
    float xInput;
    float yInput;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRen;

    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
        spriteRen = rb2d.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        Vector2 movInput = new Vector2(xInput, yInput);
        movInput.Normalize();
       
        transform.Translate(movInput * speed * Time.deltaTime);
        


        if(xInput == -1)
        {
            
            spriteRen.flipX = true;
        }
        else if(xInput == 1) 
        {
            spriteRen.flipX = false;
        }
        
    }
   
}
