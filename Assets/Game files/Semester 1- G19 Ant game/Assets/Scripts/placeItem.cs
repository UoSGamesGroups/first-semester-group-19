using UnityEngine;
using System.Collections;

public class placeItem : MonoBehaviour {
    public GameObject carriedItem;
    public GameObject player;
    public pickUpItem pickUpScript;
    private bool onLeaf;
    // Use this for initialization
    void Start () {
        player = this.gameObject;
        onLeaf = false;
    }

    // Update is called once per frame
    void Update () {

        //place for barrier
	    if (antMovement.direction == 1 && Input.GetKeyDown(KeyCode.E) && pickUpScript.carryingItem == true)
            {
            carriedItem = GameObject.FindGameObjectWithTag("Leaf");
            carriedItem.transform.parent = null;
            carriedItem.transform.position = new Vector2(player.transform.position.x + 0.2f, player.transform.position.y);
            carriedItem.transform.rotation = Quaternion.Euler(0, 0, 90);
            pickUpScript.carryingItem = false;
        }
        if (antMovement.direction == 0 && Input.GetKeyDown(KeyCode.E) && pickUpScript.carryingItem == true)
        {
            carriedItem = GameObject.FindGameObjectWithTag("Leaf");
            carriedItem.transform.parent = null;
            carriedItem.transform.position = new Vector2(player.transform.position.x - 0.2f, player.transform.position.y);
            carriedItem.transform.rotation = Quaternion.Euler(0, 0, 90);
            pickUpScript.carryingItem = false;
        }
        if (antMovement.direction == 0 && Input.GetKeyDown(KeyCode.Q) && pickUpScript.carryingItem == true)
        {
            carriedItem = GameObject.FindGameObjectWithTag("Leaf");
            carriedItem.transform.position = new Vector2(player.transform.position.x - 0.2f, player.transform.position.y-0.5f);
            carriedItem.transform.rotation = Quaternion.Euler(0, 0, 180);
            pickUpScript.carryingItem = false;
            onLeaf = true;

        }
        if (antMovement.direction == 1 && Input.GetKeyDown(KeyCode.Q) && pickUpScript.carryingItem == true)
        {
            carriedItem = GameObject.FindGameObjectWithTag("Leaf");
            carriedItem.transform.position = new Vector2(player.transform.position.x - 0.2f, player.transform.position.y- 0.5f);
            carriedItem.transform.rotation = Quaternion.Euler(0, 0, 180);
            pickUpScript.carryingItem = false;
            onLeaf = true;
        }
        if (onLeaf == true && Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y + 0.3f, 0);
            carriedItem.transform.parent = null;
            onLeaf = false;

        }
    }
}
