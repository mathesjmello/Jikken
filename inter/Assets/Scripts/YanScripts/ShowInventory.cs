using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventory : MonoBehaviour {

    public GameObject IventoryPanel;
    bool IsVisible = false;

	// Use this for initialization
	void Start () {
		
	}
	
    void Show()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        IventoryPanel.SetActive(true);
    }
    
    void Hide()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        IventoryPanel.SetActive(false);
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!IsVisible)
            Show();
            else
            Hide();

            IsVisible = !IsVisible;
        }

	}
}
