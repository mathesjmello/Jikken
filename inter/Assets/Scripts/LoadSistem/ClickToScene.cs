using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToScene : MonoBehaviour
{
	public bool PassDay;
	private bool _toDentro;
	public GameObject Help;
	public string NextScene;
	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene().name=="end")
		{
			Cursor.lockState = CursorLockMode.None;
			MyLoad.Loading(NextScene);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact") && Help.activeSelf && _toDentro)
		{
			if (PassDay)
			{
				Persistence.Day = 1;
				Persistence.SavaData();
			}
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
