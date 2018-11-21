using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCustcene : MonoBehaviour {

    // Use this for initialization
    bool playerDentro = false;
    private void Update()
    {
        if (playerDentro == true)
        {
            PlayerPrefs.SetInt("fim", 1);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerDentro = true;           

        }
    }

    
}
