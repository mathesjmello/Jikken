using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowInfo : MonoBehaviour
{
	public bool SenhaSim;
	public bool SodeTocar;
	public GameObject Senha;
	public GameObject Help;
	public GameObject Text;
	private bool _toDentro;
	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene().name == "End")
		{
			Text.SetActive(true);
			Senha.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact") && Help.activeSelf && _toDentro)
		{
			Help.SetActive(false);
			Text.SetActive(true);
			Senha.SetActive(true);
			ChecaSenha();
			Persistence.Senha += 1;
			Persistence.SavaData();
			Time.timeScale = 0;
			Cursor.lockState = CursorLockMode.None;
		}
	}

	private void ChecaSenha()
	{
		if (SceneManager.GetActiveScene().name=="complexo"&& SenhaSim)
		{
			Persistence.Senha += 1;
			Persistence.SavaData();
		}
		
	}

	public void Fecha()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Time.timeScale = 1;
		Text.SetActive(false);
		Destroy(gameObject);
	}
	private void OnTriggerStay(Collider other)
    	{
		    if (SodeTocar)
		    {
			    Debug.Log("deu");
			    Senha.SetActive(true);
			    Text.SetActive(true);
			    Time.timeScale = 0;
			    Cursor.lockState = CursorLockMode.None;
			    return;
			    
		    }
    		_toDentro = true;
    		Help.SetActive(true);	
    	}
    
    	private void OnTriggerExit(Collider other)
    	{
    		_toDentro = false;
    		Help.SetActive(false);
    	}
}
