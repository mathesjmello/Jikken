using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamAfterDestroy : MonoBehaviour
{

	public List<GameObject> SpamObjects;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDestroy()
	{
		foreach (var obj in SpamObjects)
		{
			obj.SetActive(true);
		}
	}

}
