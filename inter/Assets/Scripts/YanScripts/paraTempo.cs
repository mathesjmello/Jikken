﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paraTempo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void tempoAnda() {
        Time.timeScale = 1;

    }
}
