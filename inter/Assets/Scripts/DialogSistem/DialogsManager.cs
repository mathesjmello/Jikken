using System.Collections;
using System.Collections.Generic;
using DialogSistem;
using UnityEngine;

public class DialogsManager : MonoBehaviour
{

	public static GameObject CurrentGameObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void GetObj(GameObject obj)
	{
		CurrentGameObject = obj;
	}
	public static void StopTime()
	{
		Time.timeScale = 0;
		Cursor.lockState = CursorLockMode.None;
	}

	public void Continue()
	{
		Time.timeScale = 1;
		Cursor.lockState = CursorLockMode.Locked;
		Destroy(CurrentGameObject);
	}

	public void ShowDialog()
	{
		if(CurrentGameObject.GetComponent<CollideToLori>())
		CurrentGameObject.GetComponent<CollideToLori>().ShowDialog();
		if (CurrentGameObject.GetComponent<PickString>())
		CurrentGameObject.GetComponent<PickString>().ShowDialog();
	}
}
