using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
	public GameObject Senha;
	public GameObject Help;
	public GameObject Text;
	private bool _toDentro;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact") && Help.activeSelf && _toDentro)
		{
			Help.SetActive(false);
			Text.SetActive(true);
			Senha.SetActive(true);
			Time.timeScale = 0;
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void Fecha()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Time.timeScale = 1;
		Text.SetActive(false);
	}
	private void OnTriggerStay(Collider other)
    	{
    		_toDentro = true;
    		Help.SetActive(true);	
    	}
    
    	private void OnTriggerExit(Collider other)
    	{
    		_toDentro = false;
    		Help.SetActive(false);
    	}
}
