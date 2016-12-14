using UnityEngine;
using System.Collections;

public class antMovement : MonoBehaviour {
    static public int direction;

    public float speed;
    
    void Start()
    {
        speed = 4.0f;
    }

    void Update()
    {
       // if (Input.GetKey("a") || Input.GetKey("d"))
      //  {

            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * speed * Time.deltaTime;
      //  }
        if (Input.GetKey(KeyCode.A))
            {
            direction = 0;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
        if (Input.GetKey(KeyCode.D))
            {
            direction = 1;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
    }
}

