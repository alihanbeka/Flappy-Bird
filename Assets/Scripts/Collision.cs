using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Player movement;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "base")
        {
            Debug.Log("game over");
            
            
            GameManager.state = GameManager.GameState.dead;       
        }
    }


}
