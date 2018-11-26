﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowInventory : MonoBehaviour
{
	public GameObject ColaSenhas;
	public GameObject Senha1, Senha2, Senha3;
    public GameObject IventoryPanel;
    bool IsVisible = false;

	// Use this for initialization
	void Start () {
	Persistence.LoadData();
		if (Persistence.Senha>0)
		{
			Senha1.SetActive(true);
			if (Persistence.Senha > 1)
			{
				Senha2.SetActive(true);
				if (Persistence.Senha>2)
				{
					Senha3.SetActive(true);
				}
			}
		}
	}
	
    void Show()
    {
        IventoryPanel.SetActive(true);
	    if(SceneManager.GetActiveScene().name== "complexo")
		    ColaSenhas.SetActive(true);
    }
    
    void Hide()
    {
        IventoryPanel.SetActive(false);
	    if(SceneManager.GetActiveScene().name== "complexo")
		    ColaSenhas.SetActive(false);
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!IsVisible)
            Show();
            else
            Hide();

            IsVisible = !IsVisible;
        }

	}
}
