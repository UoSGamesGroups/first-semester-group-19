using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class antDeath : MonoBehaviour {

    public GameObject rain;
    private int antHealth;
    public Text gameOver;
    private GameObject player;
	// Use this for initialization
	void Start () {
        rain = GameObject.FindGameObjectWithTag("Rain");
        antHealth = 100;
        gameOver.text = null;
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (antHealth < 0)
        {
            antHealth = 0;
        }
        if (antHealth == 0)
        {
            player.GetComponent<antMovement>().enabled = false;
            gameOver.text = "Game Over";
        }
	
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Rain")
        {
            //Debug.Log("Health: " + antHealth);
            antHealth -= 10;
        }
    }
}
