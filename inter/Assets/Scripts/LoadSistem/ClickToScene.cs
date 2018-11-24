using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToScene : MonoBehaviour
{
	private bool _toDentro;
	public GameObject Help;
	public string NextScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact") && Help.activeSelf && _toDentro)
		{
			Help.SetActive(false);
			Cursor.lockState = CursorLockMode.None;
			MyLoad.Loading(NextScene);
		}
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
