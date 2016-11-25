using UnityEngine;
using System.Collections;

public class itemHealth : MonoBehaviour {

    public int health;
    public antDeath playerHealth;
    public currentItemHealth itemHealthScript;
    private int damageAmount = 10;
	// Use this for initialization
	void Start () {
        health = 100;
        itemHealthScript.healthBar.fillAmount = 100;
	}
	
	// Update is called once per frame
	void Update () {
	if (health < 0)
        {
            health = 0;
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
       
           
        if (col.gameObject.tag == "Rain" && gameObject.tag == "Leaf")
        {

            health -= damageAmount;
            itemHealthScript.healthBar.fillAmount -= 0.1f;

            if (transform.parent != null && transform.parent.tag == "Player")
            {
                Debug.Log(transform.parent.tag);
                playerHealth.antHealth += damageAmount;
                playerHealth.healthBar.fillAmount += damageAmount;

            }
            Debug.Log("Health: " + health);
        }
    }
}
