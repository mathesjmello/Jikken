using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamAfterDestroy : MonoBehaviour
{
	public bool ChangeMask;
	public bool ChangeQuestlog;
	public List<GameObject> SpamObjects;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDestroy()
	{
		if (ChangeMask)
		{
			Persistence.Mask += 1;
			Persistence.SavaData();
		}
		if (ChangeQuestlog)
		{
			Persistence.Quest += 1;
			Persistence.SavaData();
		}
			
		foreach (var obj in SpamObjects)
		{
			obj.SetActive(true);
		}
	}

}
