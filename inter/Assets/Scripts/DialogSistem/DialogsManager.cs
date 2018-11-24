using System.Collections;
using System.Collections.Generic;
using DialogSistem;
using UnityEngine;

public class DialogsManager : MonoBehaviour
{
	public List<GameObject> CoisasPrimeiroDia;
	public List<GameObject> CoisasSegundoDia;
	public GameObject PosPesquisa1, PosPesquisa2, PosPesquisa3;


	public static GameObject CurrentGameObject;
	// Use this for initialization
	void Start () {
		Persistence.LoadData();
		if (Persistence.Day == 0)
		{
			foreach (var obj in CoisasPrimeiroDia)
			{
				obj.SetActive(true);
			}
		}
		else
		{
			
				switch (Persistence.Pesquisa)
				{
						case 0 :
							foreach (var obj in CoisasSegundoDia)
							{
								obj.SetActive(true);
							}
							break;
						case 1:
							PosPesquisa1.SetActive(true);
							break;
						case 2:
							PosPesquisa2.SetActive(true);
							break;
						case 3:
							PosPesquisa3.SetActive(true);
							break;
				}
				
		}
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
