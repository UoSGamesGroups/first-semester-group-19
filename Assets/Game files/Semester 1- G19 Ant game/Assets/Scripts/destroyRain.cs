using UnityEngine;
using System.Collections;

public class destroyRain : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	}

   void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.collider.tag == "Grass"|| Coll.collider.tag == "Ground")
        {
            Destroy(gameObject, 6);        }
    }
}
