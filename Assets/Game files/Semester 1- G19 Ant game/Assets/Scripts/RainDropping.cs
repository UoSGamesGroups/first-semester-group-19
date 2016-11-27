using UnityEngine;
using System.Collections;

public class RainDropping : MonoBehaviour {

    public GameObject raindrop;
    public GameObject rainsplashOb;

    public float FallSpeed = 4f;

    bool isDead; //Whether the player is dead.
    bool isCollided; //Whether the raindrop is touching the ground/player.
    ParticleSystem splashParticles;  //Reference to the particle system that plays when it collides with the ground or the player.
    CircleCollider2D cirColl2D; //Reference to the circle collider.


    void Start ()
    {
        //Setting up the references.
        splashParticles = GetComponent<ParticleSystem>();
        cirColl2D = GetComponent<CircleCollider2D>();
	}


    void Update ()
    {
	    if(isCollided)
        {
            DestroyObject(raindrop);
        }
	}

    public void RainSplash(Vector2 splashZone)
    {
        splashParticles.transform.position = splashZone;
        splashParticles.Play();
    }

    void Death()
    {
        isDead = true;
        cirColl2D.isTrigger = true;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            Instantiate(rainsplashOb, new Vector3(transform.position.x, transform.position.y,-2),Quaternion.identity);
            Destroy(gameObject); //Destroy rain drop on collision with ground.
            isCollided = true; //Defines isCollided as true to instantiate particles.
        }

        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject); //Destroy rain drop on collision with and kill player.
            isCollided = true;
        }
    }
}
