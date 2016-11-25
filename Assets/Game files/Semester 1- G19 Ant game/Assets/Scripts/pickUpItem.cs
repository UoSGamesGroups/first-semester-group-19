using UnityEngine;
using System.Collections;

public class pickUpItem : MonoBehaviour {

    public GameObject item;
    public GameObject player;
    public antMovement moveScript;
    public bool carryingItem;
    private bool encumbered;
    public currentItemHealth itemHealth;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        item = gameObject;
        carryingItem = false;
        encumbered = false;
    }

    void Update()
    {
        if (encumbered)
        {
            moveScript.speed = 3f;
        }
        if (!encumbered)
        {
            moveScript.speed = 4f;
        }
        if (!carryingItem)
        {
            encumbered = false;
        }
    }

    void OnMouseUpAsButton()
    {
        if (player.transform.position.x < item.transform.position.x + 3 && player.transform.position.x > item.transform.position.x - 3)
        {
            itemHealth.currentItem = gameObject;
            item.transform.parent = player.transform;
            item.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 0.5f);
            item.transform.rotation = Quaternion.Euler(0, 0, 0);
            carryingItem = true;
            encumbered = true;
            
        }
    }
}
