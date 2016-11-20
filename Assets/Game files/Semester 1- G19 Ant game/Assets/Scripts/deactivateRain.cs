using UnityEngine;
using System.Collections;

public class deactivateRain : MonoBehaviour {

    public GameObject runoff;
    public GameObject player;
  
    // Use this for initialization
    // Update is called once per frame
    void Update () {
	 if (gameObject.transform.position.y < -7)
        {
            gameObject.SetActive(false);
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag != "Rain")
        {
            foreach (ContactPoint2D pointOfContact in col.contacts)
            {

                Vector3 hitPoint = pointOfContact.point;
                Debug.Log("Point of contact" + hitPoint);
                Instantiate(runoff, (hitPoint), Quaternion.identity);

            }
        }
            gameObject.SetActive(false);
            transform.position = new Vector3(player.transform.position.x + (Random.Range(-7f, 9f)), transform.position.y + (Random.Range(6, 9)), transform.position.z);
    }
}
