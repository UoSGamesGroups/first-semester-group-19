﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameEnd : MonoBehaviour {
   
    public Text gameOver;
    public antDeath deathScript;
    // Use this for initialization

	

public void OnClick()
    {
        SceneManager.LoadScene(0);
        gameOver.text = null;
        gameObject.SetActive(false);
        deathScript.antHealth = 100;
        deathScript.healthBar.fillAmount += 1;
    }



}

