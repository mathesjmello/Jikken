using System.Collections;
using System.Collections.Generic;
using DialogSistem;
using UnityEngine;
using UnityEngine.UI;


public class CollideToLori : MonoBehaviour {

	public  int DialogId;
	public  int DialogLenthg;
	public NevgoXmlImporter Decoder;
	public  List<string> CurrentDialog;
        
	public  Text CurrentText;
	public  GameObject DialogPainel;
	public  Button Next;
	public  Button Exit;
	// Use this for initialization
	void Start () {
		Decoder = FindObjectOfType<NevgoXmlImporter>();
		CurrentDialog = Decoder.Frases;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay(Collider other)
	{
		ShowDialog();
	}
	
	public void ShowDialog()
	{
		DialogsManager.StopTime();
		DialogsManager.GetObj(gameObject);
		DialogPainel.SetActive(true);
		CurrentText.text = CurrentDialog[DialogId];
		if (DialogLenthg>0)
		{
			DialogId++;
			Next.gameObject.SetActive(true);
			DialogLenthg--;
		}
		else
		{
			DialogId++;
			Next.gameObject.SetActive(false);
			Exit.gameObject.SetActive(true);
		}
	}

	

	
	
}
