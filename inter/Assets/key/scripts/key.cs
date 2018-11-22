using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class key : MonoBehaviour {



    public Text countText;
    public AudioSource doorOpen;
    public AudioSource click;
    public AudioSource error;
    public AudioSource ok;



    public string password = "1234";
    public string entradaPassword;

    public bool playerDentro = false;
    public bool portaAberta = true;
    public bool telaPassword = false;

    public Transform[] botoes;
    public Transform[] telaB;
    public GameObject telaKeyPad;
    public bool tela = false;
    public Animator anim;

    public GameObject letraInteracao;

    // Use this for initialization
    void Start () {
        anim.SetBool("open0", false);
        PlayerPrefs.SetInt("abrePorta", 0);
    }
	
	// Update is called once per frame
	void Update () {
        countText.text = entradaPassword;        

        if (Input.GetButtonDown("Interact"))
        {
            if (playerDentro)
            {
                Cursor.lockState = CursorLockMode.None;
                telaKeyPad.SetActive(true);
                Time.timeScale = 0;
            } 
        }     
	}
    public void fechaPortaPlayerPrefs() {
        PlayerPrefs.SetInt("abrePorta", 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            letraInteracao.SetActive(true);
            playerDentro = true;
           // tela = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        letraInteracao.SetActive(false);
        portaAberta = false;
        playerDentro = false;
        telaPassword = false;
        tela = false;
    }

    public void botao(string numero) {
        if (entradaPassword.Length < 4)
        {
            entradaPassword = entradaPassword + numero;
        }
            
            
    }

    public void testePassword() {

        if (entradaPassword == password)
        {
            Cursor.lockState = CursorLockMode.Locked;
            entradaPassword = "";
            anim.SetBool("open0", true);
            doorOpen.Play(0);
            Time.timeScale = 1;
            telaKeyPad.SetActive(false);
            Invoke("fecharPorta", 5);
            //ok.Play(0);
        }
        else {

            error.Play(0);
        }

    }

    public void resetPassword()
    {
        entradaPassword = "";       

    }

    public void fecharPorta() {
        anim.SetBool("open0", false);
        doorOpen.Play(0);
        //print("aqui");
    }

    public void abrirPorta()
    {
        anim.SetBool("open0", true);
        print("aqui");
        Invoke("fecharPorta", 3);
    }

    public void fecharPainel() {
        Cursor.lockState = CursorLockMode.Locked;
        telaKeyPad.SetActive(false);
        Time.timeScale = 1;
        entradaPassword = "";
    }

    public void playSound() {
        click.Play(0);
    }
}
