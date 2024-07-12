
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Pipes1;

    public float spawnRate = 1f;
    
    public float minHeight = -10f;

    public float maxHeight = 10f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        if (GameManager.state != GameManager.GameState.dead) { 

        GameObject pipes=Instantiate(Pipes1,transform.position,Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight); 
    }}
    
}


