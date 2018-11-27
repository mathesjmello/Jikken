using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logo : MonoBehaviour {

    public string cena;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        Invoke("LoadScene", 6);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadScene()
    {
        MyLoad.Loading(cena);
    }
}
