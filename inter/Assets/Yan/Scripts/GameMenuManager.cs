using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuManager : MonoBehaviour {

    public GameObject PausePanel;
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!PausePanel.activeSelf)
            {
                OpenPause();
            }else
            {
                ClosePause();
            }           
        }
	}

    public void OpenPause()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void ClosePause()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
}
