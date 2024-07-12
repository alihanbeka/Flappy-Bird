using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float upsideForce = 5f;
    public float directMove = 10f;
    public PipeMovement pipe;


    void Update()
    {

        rb.AddForce(new Vector2(directMove * Time.deltaTime, 0), ForceMode2D.Force);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, upsideForce);
            

            GameManager.state = GameManager.GameState.play;
        }
           transform.rotation = Quaternion.Euler(0,0,rb.velocity.y*5);

        if (GameManager.state == GameManager.GameState.dead)
        {
            stopMovement();



        }
        
    }
    public void stopMovement()
    {
        rb.isKinematic = false;
        upsideForce = 0;
         
        


    }
}
