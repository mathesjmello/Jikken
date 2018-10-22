using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public void NewGame()
    {
        Persistence.ReturnValues();
    }
    public void Continue()
    {
        Persistence.LoadData();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
