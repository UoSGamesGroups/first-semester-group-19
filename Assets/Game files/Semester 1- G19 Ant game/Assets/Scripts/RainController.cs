using UnityEngine;
using System.Collections;

public class RainController : MonoBehaviour
{
    public GameObject damageRain;
    public GameObject player;
    [SerializeField]
    private int rainCoundown;

    // Use this for initialization
    void Start()
    {
        rainCoundown = 100;
    }
    void Update()
    {
        rainCoundown--;

        if (rainCoundown == 0)
        {
            StartCoroutine(spawnRain());
            spawnRain();
            rainCoundown = 100;
        }
        else
        {
            StopCoroutine(spawnRain());
        }
    }




    IEnumerator spawnRain()
    {
        if (rainCoundown == 0)
        {
            for (int i = 0; i < 6; i++)
            { 
                Instantiate(damageRain, new Vector3(Random.Range(player.transform.position.x - 10, player.transform.position.x + 10), 5.6f, 0), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
