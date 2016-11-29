using UnityEngine;

public class RainSpawn : MonoBehaviour
{

    public float speed = 3f;
    public GameObject raindrop;
    public float spawnTime = 1f;
    public Transform[] spawnPoints;

    private int MaxHealth = 5;
    private float size;
    private Rigidbody2D r2b;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        if(MaxHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(raindrop, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
