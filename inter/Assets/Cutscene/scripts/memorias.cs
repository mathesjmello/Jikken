using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memorias : MonoBehaviour {

    public Animator flashCamera;
    public int timeAnimation;
    //public Transform posPlayer;
    public GameObject player;

    void Start () {
        PlayerPrefs.SetInt("playerDentro",0);
        flashCamera.SetBool("flash", false);
        
            
	}

    private void Update()
    {
        if (PlayerPrefs.GetInt("playerDentro") == 1)
        {
            flashCamera.SetBool("flash", true);
            Invoke("memoria", timeAnimation);
        }
    }


    public void memoria() {
        flashCamera.SetBool("flash", false);
        PlayerPrefs.SetInt("playerDentro", 0);
    }
}
