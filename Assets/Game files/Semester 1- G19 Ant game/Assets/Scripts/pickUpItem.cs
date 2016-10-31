using UnityEngine;
using System.Collections;

public class pickUpItem : MonoBehaviour {

    public GameObject item;
    public GameObject player;
	// Use this for initialization
	void Start ()
    {
        item = null;
        player = this.gameObject;	
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            item = GameObject.FindGameObjectWithTag("Leaf");
            item.transform.parent = player.transform;
            item.transform.position = new Vector2(player.transform.position.x, player.transform.position.y+0.5f);

        }

	}
}
