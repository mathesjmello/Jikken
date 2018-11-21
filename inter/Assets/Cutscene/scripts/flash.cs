using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class flash : MonoBehaviour {

   
    bool playerDentro = false;   
    public GameObject[] flashBacks;
    //public GameObject[] memo;
    public GameObject[] flashCol;
    GameObject[] flashStore;
    public int memoriaNumero;
    private void Start()
    {
        PlayerPrefs.SetInt("playerDentro", 0);
        print(PlayerPrefs.GetInt("playerDentro"));
    }

    void Update () {   

        if (PlayerPrefs.GetInt("playerDentro")==1) {
            Invoke("memoria",1);
        }
	}

    public void memoria() {
        if (PlayerPrefs.GetInt("playerDentro") == 1)
        {
            flashBacks[memoriaNumero].SetActive(true);
            flashCol[memoriaNumero].SetActive(false);
            Invoke("outro", 10);
        }
        
    }



    public void outro() {
        if (PlayerPrefs.GetInt("playerDentro") == 1)
        {
            memoriaNumero++;
            PlayerPrefs.SetInt("playerDentro", 0);
            print(memoriaNumero);
        }
    }
}
