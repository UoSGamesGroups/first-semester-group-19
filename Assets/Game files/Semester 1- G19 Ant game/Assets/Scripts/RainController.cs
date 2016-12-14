using UnityEngine;
using System.Collections;

public class RainController : MonoBehaviour
{
    public GameObject[] rainArray;
    public GameObject damageRain;
    private int rainAmount = 20;
    public GameObject player;
    [SerializeField]
    private int rainCountdown;    // Use this for initialization
    void Start()
    {
        rainArray = new GameObject[rainAmount];
        for (int i = 0; i < rainAmount; i++)
        {
            GameObject newRain = Instantiate(damageRain, new Vector3((float)i, 8, 0), Quaternion.identity) as GameObject;
            rainArray[i] = newRain;
            newRain.SetActive(false);
        }

        rainCountdown = 70;
    }
    private GameObject findSpareRain()
    {
        for (int i = 0; i < rainAmount; i++)
        {
            if (rainArray != null) {
                if (rainArray[i].activeSelf == false)
                {
                    rainArray[i].transform.rotation = Quaternion.identity;
                    rainArray[i].transform.position = new Vector2(player.transform.position.x + Random.Range(-5, 5), 9);
                    rainArray[i].transform.localScale = new Vector2(Random.Range(0.25f, 0.35f), Random.Range(0.25f, 0.35f));
                    rainArray[i].GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.5f, 1f);
                    rainArray[i].SetActive(true);
                 
                    return rainArray[i];
                }
            }
        }

        return null;

    }
    
    void Update()
    {
        

        rainCountdown--;

        if (rainCountdown == 0)
        {
            for (int i = 0; i < 8; i++)
            {
                findSpareRain();
            }
            rainCountdown = 100;
        }

    }

}
