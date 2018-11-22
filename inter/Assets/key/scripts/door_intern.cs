using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_intern : MonoBehaviour {

    public AudioSource door;
    public Animator anim;
    //public AudioSource door;

    public bool playerDentro = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerDentro)
        {
            anim.SetBool("open2", true);
        }
        else {
            anim.SetBool("open2", false);
            
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerDentro = true;
            door.Play(0);
        }
       
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerDentro = false;
            door.Play(0);
        }
    }


}
