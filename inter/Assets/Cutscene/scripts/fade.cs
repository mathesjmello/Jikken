using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour {

    public int tempo;
    public Animator fadeAnimation;
    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("fim", 0);
        Invoke("inicio", tempo);        
        //Invoke("endAnimation",2);
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("fim") == 1) {
            fadeAnimation.SetBool("fadeIN", false);
            fadeAnimation.SetBool("fadeOut", true);
            Invoke("endAnimation", 3);
            
        }
	}

    public void inicio() {

        fadeAnimation.SetBool("fadeIN", true);
    }
    public void endAnimation() {
        MyLoad.Loading("house_exterior");
    }
}
