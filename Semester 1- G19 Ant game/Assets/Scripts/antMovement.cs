using UnityEngine;
using System.Collections;

public class antMovement : MonoBehaviour {

public KeyCode left;
public KeyCode right;
private float speed;
    //private float vlctyx;
    private float posX;


    void Awake()
    {
        posX = transform.position.x;
    }
    // Use this for initialization
    public void Start ()
    {
        speed = 4f;
       // vlctyx = GetComponent<Rigidbody2D>().velocity.x;
	}
	
	// Update is called once per frame
	public void Update ()
    {
        if (Input.GetKey(left)/* && transform.position.x > -6.149*/)
        {
           
            Debug.Log("pressed");
            GetComponent<Rigidbody2D>().transform.position.x += speed;
            // vlctyx = speed;
        }
        /*else
        {
            //vlctyx = 0;
        }*/
	}
}
