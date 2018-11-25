using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_final : MonoBehaviour {

    public GameObject fimCam;
    public GameObject texto1;
    public GameObject texto2;
    //public float tempoAnim = 20;
    //public float tempoAnim2 = 10;
    public bool playerDentro = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerDentro) {
            
            Invoke("ativaWay", 5);
            playerDentro = false;
        }
	}

    public void ativaWay()
    {
        fimCam.SetActive(true);
        Invoke("textoFim1", 5);
    }
    public void textoFim1() {
        texto1.SetActive(true);
        Invoke("textoFim2", 5);
    }

    public void textoFim2()
    {
        texto1.SetActive(false);
        texto2.SetActive(true);
        Invoke("finalAnima", 5);
    }
    public void finalAnima() {
        PlayerPrefs.SetInt("fim", 1);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerDentro = true;
        }
    }
}
