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
    public Slider slider;
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

        //make this a switch statement if everything else is finished
        if (antHealth == 0)
        {
            player.GetComponent<antMovement>().enabled = false;
            gameOver.text = "Game Over";
            restartGame.SetActive(true);
            healthBar.fillAmount = 0.0f;
        }
        // else if (antHealth > 0 && antHealth <=10)
        // {
        //     healthBar.fillAmount = 0.1f;
        // }
        //else if (antHealth < 10 && antHealth <= 20)
        // {
        //     healthBar.fillAmount = 0.2f;
        // }
        //else if (antHealth < 20 && antHealth <= 30)
        // {
        //     healthBar.fillAmount = 0.3f;
        // }
        //else if (antHealth < 30 && antHealth <= 40)
        // {
        //     healthBar.fillAmount = 0.4f;
        // }
        //else if (antHealth < 40 && antHealth <= 50)
        // {
        //     healthBar.fillAmount = 0.5f;
        // }
        //else if (antHealth < 50 && antHealth <= 60)
        // {
        //     healthBar.fillAmount = 0.6f;
        // }
        // else if (antHealth <= 60 && antHealth <= 70)
        // {
        //     healthBar.fillAmount = 0.7f;
        // }
        //else if (antHealth < 70 && antHealth <= 80)
        // {
        //     healthBar.fillAmount = 0.8f;
        // }
        //else if (antHealth < 80 && antHealth <= 90)
        // {
        //     healthBar.fillAmount = 0.9f;
        // }
        //else if (antHealth < 90 && antHealth <= 100)
        // {
        //     healthBar.fillAmount = 1f;
        // }

        slider.value = antHealth;


        healthText.text = "Health: " + antHealth;

	
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Rain")
        {

            antHealth -= 10;
            
        }
    }
}
