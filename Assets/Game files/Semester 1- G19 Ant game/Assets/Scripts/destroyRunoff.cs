using UnityEngine;
using System.Collections;

public class destroyRunoff : MonoBehaviour {
    public Transform runoff;
	// Use this for initialization
	void Start () {
        StartCoroutine(destroy());
        Physics2D.IgnoreCollision(runoff.GetComponent<Collider2D>(), GetComponent<Collider2D>());

	}
	
	// Update is called once per frame
	void Update () {
	}
    IEnumerator destroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
