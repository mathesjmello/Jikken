using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class GameMenuManager : MonoBehaviour {

    public GameObject PausePanel;
    public GameObject Invetario;
    public PostProcessingProfile efeito;
    public float focus_distance;
    public float focal_length;

    private void Start()
    {
        var focus = efeito.depthOfField.settings;
        focus.focusDistance = focus_distance = 10f;
        efeito.depthOfField.settings = focus;

        var focal = efeito.depthOfField.settings;
        focal.focalLength = focal_length = 5f;
        efeito.depthOfField.settings = focal;
    }
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!PausePanel.activeSelf)
            {
                
                OpenPause();
            }else
            {
                
                    //cria uma variavel para armazenzar o valor
                    var focus = efeito.depthOfField.settings;
                    focus.focusDistance = focus_distance = 10f;
                    efeito.depthOfField.settings = focus;

                    var focal = efeito.depthOfField.settings;
                    focal.focalLength = focal_length = 5f;
                    efeito.depthOfField.settings = focal;
                
                ClosePause();
            }           
        }
	}

    public void OpenPause()
    {
        Cursor.lockState = CursorLockMode.None;
        
        PausePanel.SetActive(true);
        Invetario.SetActive(false);

        Time.timeScale = 0;
        //ativa o efeito de desfoque

        //cria uma variavel para armazenzar o valor
        var focus = efeito.depthOfField.settings;
            focus.focusDistance = focus_distance = 0.1f;
            efeito.depthOfField.settings = focus;

            var focal = efeito.depthOfField.settings;
            focal.focalLength = focal_length = 300f;
            efeito.depthOfField.settings = focal;
        
    }

   

    public void ClosePause()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        //Invoke("tempoNormal", 2);
        PausePanel.SetActive(false);
        Invetario.SetActive(true);
        //cria uma variavel para armazenzar o valor
        var focus = efeito.depthOfField.settings;
        focus.focusDistance = focus_distance = 10f;
        efeito.depthOfField.settings = focus;

        var focal = efeito.depthOfField.settings;
        focal.focalLength = focal_length = 5f;
        efeito.depthOfField.settings = focal;
    }
  
}
