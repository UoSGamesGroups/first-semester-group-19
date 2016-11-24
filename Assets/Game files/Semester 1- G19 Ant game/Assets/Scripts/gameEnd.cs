using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameEnd : MonoBehaviour {
    private GameObject player;
    public Text gameOver;
    public antDeath deathScript;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	

public void OnClick()
    {
        SceneManager.LoadScene(0);
        gameOver.text = null;
        gameObject.SetActive(false);
        deathScript.antHealth = 100;
    }



}

