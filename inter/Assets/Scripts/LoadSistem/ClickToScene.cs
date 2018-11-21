using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToScene : MonoBehaviour
{

	public GameObject Help;
	public string NextScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact") && Help.activeSelf)
		{
			MyLoad.Loading(NextScene);
		}
	}

	private void OnTriggerStay(Collider other)
	{
		Help.SetActive(true);	
	}

	private void OnTriggerExit(Collider other)
	{
		Help.SetActive(false);
	}
}
