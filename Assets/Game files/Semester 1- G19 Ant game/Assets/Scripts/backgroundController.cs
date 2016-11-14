using UnityEngine;
using System.Collections;

public class backgroundController : MonoBehaviour {

    public Sprite darkBackground;
    public Sprite lightBackground;
   // public float timer;
	// Use this for initialization
	void Start () {
        StartCoroutine(swapBackgr());
       // timer = 150f;
	}
	
	// Update is called once per frame
	void Update () {
      /*  timer--;
        if (timer < 0)
        {
            timer = 150f;
        }*/
	}

    IEnumerator swapBackgr()
    {
        while (true)
        {
            Debug.Log("here");
            gameObject.GetComponent<SpriteRenderer>().sprite = lightBackground;
            transform.localScale = new Vector3(1, 1, 1);
            yield return new WaitForSeconds(0.1f);
            gameObject.GetComponent<SpriteRenderer>().sprite = darkBackground;
            transform.localScale = new Vector3(0.537037f, 0.5718755f, 1);
           // timer = 150;
            yield return new WaitForSeconds(1.5f);   
        }
    }
    
}
