using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class antDeath : MonoBehaviour {

    public GameObject rain;
    public int antHealth;
    public Text gameOver;
    public GameObject restartGame;
    private GameObject player;
    public Image healthBar;
    public Text healthText;
	// Use this for initialization
	void Start () {
        rain = GameObject.FindGameObjectWithTag("Rain");
        antHealth = 100;
        gameOver.text = null;
        player = GameObject.FindGameObjectWithTag("Player");
        restartGame.SetActive(false);
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
            restartGame.SetActive(true);
        }
        healthText.text = "Health: " + antHealth;
	
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Rain")
        {
            antHealth -= 10;
            healthBar.fillAmount -= 0.1f;
        }
    }
}
