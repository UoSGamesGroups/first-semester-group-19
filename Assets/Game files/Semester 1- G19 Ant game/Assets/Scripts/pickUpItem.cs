using UnityEngine;
using System.Collections;

public class pickUpItem : MonoBehaviour {

    public GameObject item;
    public GameObject player;
    public bool carryingItem;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        item = this.gameObject;
        carryingItem = false;
    }


    void OnMouseUpAsButton()
    {
        if (player.transform.position.x < item.transform.position.x + 1.5 && player.transform.position.x > item.transform.position.x - 1.5)
        {
            item.transform.parent = player.transform;
            item.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 0.5f);
            item.transform.rotation = Quaternion.Euler(0, 0, 0);
            carryingItem = true;
        }
    }
}
