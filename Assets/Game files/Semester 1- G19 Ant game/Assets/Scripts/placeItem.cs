using UnityEngine;
using System.Collections;

public class placeItem : MonoBehaviour {
    public GameObject carriedItem;
    public GameObject player;
    // Use this for initialization
    void Start () {
        player = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        //place for barrier
	    if (antMovement.direction == 1 && Input.GetKeyDown(KeyCode.E))
            {
            carriedItem = GameObject.FindGameObjectWithTag("Leaf");
            carriedItem.transform.parent = null;
            carriedItem.transform.position = new Vector2(player.transform.position.x + 0.2f, player.transform.position.y);
            carriedItem.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (antMovement.direction == 0 && Input.GetKeyDown(KeyCode.E))
        {
            carriedItem = GameObject.FindGameObjectWithTag("Leaf");
            carriedItem.transform.parent = null;
            carriedItem.transform.position = new Vector2(player.transform.position.x - 0.2f, player.transform.position.y);
            carriedItem.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }
}
