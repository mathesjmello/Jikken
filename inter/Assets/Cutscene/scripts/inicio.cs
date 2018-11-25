using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicio : MonoBehaviour {

    //public GameObject camera;
    public GameObject sounds;
    public GameObject controleCam;
    public GameObject player;

    public GameObject textoInicio;
    public int tempo;

	// Use this for initialization
	void Start () {
        Invoke("inicioCutscene", tempo);
        Destroy(textoInicio, 22);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void introducao() {
        textoInicio.SetActive(true);
    }

    public void inicioCutscene() {
        //camera.SetActive(true);
        player.SetActive(true);
        controleCam.SetActive(true);
        sounds.SetActive(true);
    }

}
