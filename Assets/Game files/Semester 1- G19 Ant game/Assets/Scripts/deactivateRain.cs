using UnityEngine;
using System.Collections;

public class deactivateRain : MonoBehaviour {

    //public bool hit;
    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 if (gameObject.transform.position.y < -7)
        {
            gameObject.SetActive(false);
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        //hit = true; 
        transform.position = new Vector3(player.transform.position.x + (Random.Range(-5f,5f)), transform.position.y+(Random.Range(6,9)), transform.position.z);
            gameObject.SetActive(false);
    }
}
