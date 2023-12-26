using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int speed = 8;
    float xInput;
    float yInput;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRen;
    bool canLoad = false;

    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
        spriteRen = rb2d.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        FlipSprite();
    }

    /// <summary>
    /// Flips sprite to correct position
    /// </summary>
    void FlipSprite()
    {
        if (xInput == -1)
        {

            spriteRen.flipX = true;
        }
        else if (xInput == 1)
        {
            spriteRen.flipX = false;
        }
    }

    /// <summary>
    /// code for moving the player across the scene 
    /// </summary>
    void PlayerMovement()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        Vector2 movInput = new Vector2(xInput, yInput);
        movInput.Normalize();
        transform.Translate(movInput * speed * Time.deltaTime);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Grass")
        {
            
            if (xInput != 0 || yInput != 0)
            {
                canLoad = true;
                int ranSceneLoad = Random.Range(0, 500);
                Debug.Log(ranSceneLoad);
                if (ranSceneLoad >= 499 && canLoad)
                {
                    SceneManager.LoadScene(1);
                }
            }
            else
            {
                canLoad = false;
            }
        }
        
    }

}
