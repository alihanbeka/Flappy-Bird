using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public GameObject Pipe;
    
    public float speed = 5f;

    private float leftEdge = -5;
    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x ;
    }

    void FixedUpdate()
    {
        transform.position+=Vector3.left*speed*Time.deltaTime; 
    }
    public void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < leftEdge)
        {
            Destroy(this.gameObject);
        }
        if (GameManager.state==GameManager.GameState.dead) {
            speed = 0;
        }
    }
}
