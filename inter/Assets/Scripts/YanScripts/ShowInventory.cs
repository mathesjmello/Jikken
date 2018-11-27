using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowInventory : MonoBehaviour
{
	public GameObject MascarasCompond;
	public GameObject Mascara1, Mascara2;
	public GameObject ColaSenhas;
	public GameObject Senha1, Senha2, Senha3;
    public GameObject IventoryPanel, QuestLogPainel;
	public Text QuestText;
    bool IsVisible = false;

	// Use this for initialization
	void Start () {
	Persistence.LoadData();
		
		if (Persistence.Senha>0)
		{
			Senha1.SetActive(true);
			if (Persistence.Senha > 1)
			{
				Senha2.SetActive(true);
				if (Persistence.Senha>2)
				{
					Senha3.SetActive(true);
				}
			}
		}
	}
	
    void Show()
    {
	    Persistence.LoadData();
	    switch (Persistence.Quest)
	    {
		    case 0:
			    QuestText.text = "procure seu pai em casa";
			    break;
		    case 1:
			    QuestText.text = "procure pistas de seu pai";
			    break;
		    case 2:
			    QuestText.text = "vá para o parque da vila";
			    break;
		    case 3:
			    QuestText.text = "vá para o mirante do templo";
			    break;
		    case 4:
			    QuestText.text = "procure coisas suspeitas pela região";
			    break;
			case 5:
				QuestText.text = "colete outras amostras";
				break;
		    case 6:
			    QuestText.text = "entre no túnel para investigar";
			    break;
		    case 7:
			    QuestText.text = "invada o complexo";
			    break;
		    case 8:
			    QuestText.text = "procure pelo seu pai no complexo";
			    break;
		    case 9:
			    QuestText.text = "destrua a planta central";
			    break;
		    case 10:
			    QuestText.text = "entre no túnel para investigar";
			    break;
		    case 11:
			    QuestText.text = "invada o complexo";
			    break;
		    case 12:
			    QuestText.text = "procure pelo seu pai no complexo";
			    break;
		    case 13:
			    QuestText.text = "destrua a planta central";
			    break;
	    }
        IventoryPanel.SetActive(true);
	    QuestLogPainel.SetActive(true);
	    MascarasCompond.SetActive(true);
	    if (Persistence.Mask>0)
	    {
		    Mascara1.SetActive(true);
		    if (Persistence.Mask>1)
		    {
			    Mascara2.SetActive(true);
		    }
	    }
	    if(SceneManager.GetActiveScene().name== "complexo")
		    ColaSenhas.SetActive(true);
    }
    
    void Hide()
    {
	    MascarasCompond.SetActive(false);
        IventoryPanel.SetActive(false);
	    QuestLogPainel.SetActive(false);
	    if(SceneManager.GetActiveScene().name== "complexo")
		    ColaSenhas.SetActive(false);
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
