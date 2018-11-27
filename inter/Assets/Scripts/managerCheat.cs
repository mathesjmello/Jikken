using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerCheat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cena1(int quest) {
        //house exterior
        Persistence.Quest = 0;        

    }

    public void LoadScene(string Scene)
    {
        MyLoad.Loading(Scene);
    }
}
