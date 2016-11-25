using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelTime : MonoBehaviour {
    private float timer = 0.0f;
    public Text timeText;
    private string seconds;
    private string minutes;
    // Use this for initialization
    void Start ()
    {
      
    }
	
	// Update is called once per frame
	void Update ()
    {
        minutes = Mathf.Floor(timer / 60).ToString("00");
        seconds = Mathf.Floor(timer % 60).ToString("00");
        timer += Time.deltaTime;
        timeText.text = minutes + ":" + seconds;
        
     
	}
}