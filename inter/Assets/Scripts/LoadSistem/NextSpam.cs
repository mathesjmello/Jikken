using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSpam : MonoBehaviour
{

	public GameObject Player,NextSpamGameObject;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerStay(Collider other)
	{
		Player.transform.position = NextSpamGameObject.transform.position;
	}
}
