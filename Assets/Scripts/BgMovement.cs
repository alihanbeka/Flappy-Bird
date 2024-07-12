using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMovement : MonoBehaviour
{
    public float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameManager.state != GameManager.GameState.dead)
        {   transform.Translate(Vector3.left * Time.deltaTime * speed);


        }
    }
}
