using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPlayer : MonoBehaviour {

    bool playerDentro = false;
    private void Update()
    {
        if (playerDentro == true) {
            PlayerPrefs.SetInt("playerDentro", 1);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            playerDentro = true;
            Invoke("sairPlayer", 5);
            
        }
    }

    public void sairPlayer() {
        playerDentro = false;
    }
}
