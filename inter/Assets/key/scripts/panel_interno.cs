using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_interno : MonoBehaviour {

    //public Animator anim;
    //public GameObject lugar;
    public AudioSource open;
    public GameObject porta;
    public GameObject interacao;
    public bool playerDentro = false;

    public void Start()
    {
       

    }
        private void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (playerDentro) {

                porta.GetComponent<key>().abrirPorta();
                Cursor.lockState = CursorLockMode.Locked;
                open.Play(0);
            }
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerDentro = true;
            interacao.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            interacao.SetActive(false);
            playerDentro = false;

        }
    }
}
