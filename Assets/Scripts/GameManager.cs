
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject startScreenUI;
    public GameObject player;

    public enum GameState
    {
        idle,
        play,
        dead
    }

    public static GameState state { get; set; }
    private void Start()
    {
        state = GameState.idle;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
    }

    private void Update()
    {

        if (state == GameState.idle)
        {
            Beginning();
        }
        else if (state == GameState.play) 
        { 
            Play();
        }
        else if (state == GameState.dead)
        {
            Dead();
        }
    }

    public void Beginning()
    {
    

    }

    public void Play()
    {
        player.GetComponent<Rigidbody2D>().gravityScale = 2f;
        startScreenUI.SetActive(false);

    }

    public void Dead()
    {
        gameOverUI.SetActive(true);

    }

}
