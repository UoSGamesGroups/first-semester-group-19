using UnityEngine;
using System.Collections;

public class backgroundController : MonoBehaviour {

    public Sprite darkBackground;
    public Sprite lightBackground;
    public float timer;
	// Use this for initialization
	void Start () {
        StartCoroutine(swapBackgr());
        timer = 150f;
	}
	
	// Update is called once per frame
	void Update () {
        timer--;
        if (timer < 0)
        {
            timer = 150f;
            StartCoroutine(swapBackgr());
        }
	}

    IEnumerator swapBackgr()
    {
        if (timer <= 0)
        {
   
            gameObject.GetComponent<SpriteRenderer>().sprite = lightBackground;
            transform.localScale = new Vector3 (1,1,1);
            yield return new WaitForSeconds(0.3f);
            gameObject.GetComponent<SpriteRenderer>().sprite = darkBackground;
            transform.localScale = new Vector3(0.5f, 0.5f, 1);
            StopCoroutine(swapBackgr());        
        }
    }
    
}
