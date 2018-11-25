using System.Collections;
using System.Collections.Generic;
using DialogSistem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogsManager : MonoBehaviour
{
	public GameObject Spam1, Spam2;
	public GameObject Player;
	public List<GameObject> CoisasPrimeiroDia;
	public List<GameObject> CoisasSegundoDia;
	public GameObject PosPesquisa1, PosPesquisa2, PosPesquisa3;


	public static GameObject CurrentGameObject;
	// Use this for initialization
	void Start () {
		Persistence.LoadData();
		print(Persistence.Day);
		print(Persistence.Pesquisa);
		if (Persistence.Day == 0)
		{
			foreach (var obj in CoisasPrimeiroDia)
			{
				obj.SetActive(true);
			}
		}
		else
		{
			if (SceneManager.GetActiveScene().name == "house_interior"||SceneManager.GetActiveScene().name =="cena")
			{
				if (Persistence.Pesquisa == 0)
				{
					foreach (var obj in CoisasSegundoDia)
					{
						obj.SetActive(true);
					}
				}
				else if (Persistence.Pesquisa == 1)
				{
					PosPesquisa1.SetActive(true);
					Player.transform.rotation= Quaternion.Euler(0,285,0);
					Player.transform.position = Spam1.transform.position;
				}
				else if (Persistence.Pesquisa == 2)
				{
					Player.transform.position = Spam1.transform.position;
					Player.transform.rotation= Quaternion.Euler(0,285,0);
					PosPesquisa2.SetActive(true);
				}
				else if (Persistence.Pesquisa == 3)
				{
					if (SceneManager.GetActiveScene().name =="cena")
					{
						foreach (var obj in CoisasSegundoDia)
                        					{
                        						obj.SetActive(true);
                        					}
					}
					Player.transform.position = Spam1.transform.position;
					Player.transform.rotation= Quaternion.Euler(0,285,0);
					PosPesquisa3.SetActive(true);
				}
			}
			else if(SceneManager.GetActiveScene().name == "complexo")
			{
				if (Persistence.Pesquisa == 4)
				{
					PosPesquisa1.SetActive(true);
					Player.transform.position = Spam1.transform.position;
				}
				if (Persistence.Pesquisa == 5)
				{
					PosPesquisa2.SetActive(true);
					Player.transform.position = Spam2.transform.position;
				}
			}
			else
			{
				foreach (var obj in CoisasSegundoDia)
				{
					obj.SetActive(true);
				}
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
