using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonLabManager : MonoBehaviour {

    public MiniGameLabManager miniGameScript;
    public Button[] Buttons;
    public Sprite UPSprite, DownSprite;
    public Slider TimeSlider;
    public GameObject KeyPanel,UpIcon,DownIcon,PausePanel,ButtonsPanel;
    public float minigameTime;
    public Image FillTimeSlider;
    int NUp,NDown;

    public AudioSource click;
    public AudioSource error;

    public GameObject lose;
    public static bool TimerStop;

    bool errorSound = true;
   

    // Use this for initialization
    void Start () {

        errorSound = true;
       

        TimerStop = false; 

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
    private void Update()
    {
        Timer();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!PausePanel.activeSelf)
            {
                PausePanel.SetActive(true);
                TimerStop = true;
            }
            else
            {
                PausePanel.SetActive(false);
                TimerStop = false;
            }
        }

        ButtonsPanel.SetActive(!TimerStop);
    }

    void UP()
    {
        miniGameScript.ButtonUp();
        SpawnFeedBackKey(true);
    }
    void Down()
    {
        miniGameScript.ButtonDown();
        SpawnFeedBackKey(false);
    }

    void SpawnFeedBackKey(bool Direction)
    {
        if (Direction)
            Instantiate(UpIcon, KeyPanel.transform);
        else
            Instantiate(DownIcon, KeyPanel.transform);          
    }

    void Timer()
    {

        if (!TimerStop)
        {
            minigameTime = minigameTime - 1 * Time.deltaTime;
        }

        if (minigameTime <= 0)
        {
            loseScreen();
        }

        TimeSlider.value = minigameTime;

        if(TimeSlider.value < TimeSlider.maxValue / 2 && TimeSlider.value > TimeSlider.maxValue / 4)
        {
            FillTimeSlider.color = Color.yellow;
        }
        else if(TimeSlider.value < TimeSlider.maxValue / 4)
        {
            FillTimeSlider.color = Color.red;
        }
        else
        {
            FillTimeSlider.color = Color.green;
        }
    }

    public void Restart()
    {

        SceneManager.LoadScene("TextMiniGameLabo");
    }
    
    public void Continuar()
    {
        Persistence.Pesquisa += 1;
        Persistence.SavaData();
        MyLoad.Loading("house_interno");
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        TimerStop = false;
    }

    public void MainMenu()
    {
        MyLoad.Loading("MainMenu");
    }

    public void playSound() {
        click.Play(0);
    }

    public void playError()
    {
        if (errorSound) {
            error.Play(0);
            errorSound = false;
        }
        
    }
    public void loseScreen()
    {
        lose.SetActive(true);
        //error.Play(0);

    }

}
