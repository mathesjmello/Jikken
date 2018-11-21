using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour {

    public GameObject texto;
    bool playerDentro = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerDentro == true) {
            texto.SetActive(true);
            
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            playerDentro = true;
            Destroy(this, 7);
        }
    }
}
