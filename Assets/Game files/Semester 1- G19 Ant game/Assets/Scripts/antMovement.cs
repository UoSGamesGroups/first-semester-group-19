using UnityEngine;
using System.Collections;

public class antMovement : MonoBehaviour {

    float speed;

    void Start()
    {
        speed = 4.0f;
    }

    void Update()
    {
        if (Input.GetKey("a") || Input.GetKey("d"))
        {

            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * speed * Time.deltaTime;
        }
    }

}
