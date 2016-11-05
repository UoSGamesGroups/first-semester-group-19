using UnityEngine;
using System.Collections;

public class deactivateRain : MonoBehaviour {

    public bool hit;
    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        hit = true; 
      //  if (col.collider.tag == "Ground")
        //{
            Debug.Log("here");
        transform.position = new Vector3(player.transform.position.x + (Random.Range(-7f,7f)), transform.position.y+6, transform.position.z);
            gameObject.SetActive(false);
       // }
    }
}
