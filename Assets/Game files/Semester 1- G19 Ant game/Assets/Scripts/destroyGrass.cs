    using UnityEngine;
using System.Collections;

public class destroyGrass : MonoBehaviour {
    [SerializeField]
    float collisionCounter;
    // Use this for initialization
	void Start () {
        collisionCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
	   if (collisionCounter == 5)
        {
            Destroy(gameObject);
        }
	}
    void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.collider.tag == "Rain")
        {
            collisionCounter += 0.5f;
            Debug.Log(collisionCounter);
        }
    }
}
