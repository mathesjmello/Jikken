using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLabManager : MonoBehaviour {

    public MiniGameLabManager miniGameScript;

    public Button[] Buttons;

    public Sprite UPSprite, DownSprite;

    int NUp,NDown;

	// Use this for initialization
	void Start () {

        for(int i = 0; i < MiniGameLabManager.SpawnDificult; i++)
        {
            if (MiniGameLabManager.SaveSequence[i])
            {
                NUp++;
            }
            else
            {
                NDown++;
            }
        }
        for (int i = 0; i < MiniGameLabManager.SpawnDificult; i++)
        {
            int random = Random.Range(1, 100);
            if (random % 2 == 0)
            {
                if (NUp > 0)
                {
                    Buttons[i].onClick.AddListener(UP);
                    Buttons[i].image.sprite = UPSprite;
                    NUp--;
                }
                else
                {
                    Buttons[i].onClick.AddListener(Down);
                    Buttons[i].image.sprite = DownSprite;
                }
            }
            else
            {              
                if (NDown > 0)
                {
                    Buttons[i].onClick.AddListener(Down);
                    Buttons[i].image.sprite = DownSprite;
                    NDown--;
                }
                else
                {
                    Buttons[i].onClick.AddListener(UP);
                    Buttons[i].image.sprite = UPSprite;
                }
            }
        }
    }

    void UP()
    {
        miniGameScript.ButtonUp();
    }
    void Down()
    {
        miniGameScript.ButtonDown();
    }
}
