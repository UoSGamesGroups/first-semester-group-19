using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class currentItemHealth : MonoBehaviour {
    public GameObject currentItem;
    public Text healthText;
    public Image healthBar;
	// Use this for initialization
	void Start ()
    {
        currentItem = GameObject.FindGameObjectWithTag("Leaf");
    }
	
	// Update is called once per frame
	void Update ()
    {
        healthText.text = "Current Item: " + currentItem.GetComponent<itemHealth>().health;
	}
}
