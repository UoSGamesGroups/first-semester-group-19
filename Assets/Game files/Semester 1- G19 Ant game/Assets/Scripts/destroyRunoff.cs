﻿using UnityEngine;
using System.Collections;

public class destroyRunoff : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(destroy());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator destroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}