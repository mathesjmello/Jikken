using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameLabManager : MonoBehaviour {

    public GameObject PlaceHolder,LineObject,PanelLose,PanelWin;
    public AudioSource click;
    public AudioSource error;
    public AudioSource passOK;

    bool Uping;

    float spaceLado = -1f*3;
    float spaceCima = 0.5f;

    public static int SpawnDificult = 6;
    int changeLineCaunter = 0;
    int SpawnCounter;
    int spawnPlayerCount = 0;

    static public bool[] SaveSequence = new bool[6];

    bool resetSpawnPos = false;
    bool passSound = false;

    private void Start()
    {
        passSound = true;
    }
    void Awake()
    {
        CompleteSpawn();
    }

    void UpLineSpawner()
    {
        if (changeLineCaunter < 2)
        {
            if (Uping)
            {
               spaceCima = spaceCima + 1.2f;
            }
            SaveSequence[SpawnCounter] = true;
            LineObjectSpawn(true,false);
            Uping = true;
            SpawnCounter++;
            changeLineCaunter++;
        }
        else
        {
            DownLineSpawner();
        }
    }

    void DownLineSpawner()
    {
       
        if (changeLineCaunter > -2)
        {
            if (!Uping)
            {
                spaceCima = spaceCima - 1.2f;
            }
            SaveSequence[SpawnCounter] = false;
            LineObjectSpawn(false,false);
            Uping = false;
            SpawnCounter++;
            changeLineCaunter--;
        }
        else
        {
            UpLineSpawner();
        }
    }

    public void LineObjectSpawn(bool Direction, bool fromPlayer)
    {
        GameObject Line;
        SpriteRenderer SpritLine;


        if (!resetSpawnPos && fromPlayer)
        {
            spaceLado = -1f * 3;
            spaceCima = 0.5f;
            Uping = false;
            resetSpawnPos = true;
        }

        if (fromPlayer) {

            if (Uping && Direction)
            {
                spaceCima = spaceCima + 1.2f;
            }
            else if (!Uping && !Direction)
            {
                spaceCima = spaceCima - 1.2f;
            }
        }

        Vector3 SpawmPos = new Vector3(PlaceHolder.transform.position.x + spaceLado, PlaceHolder.transform.position.y + spaceCima, 0.1f);

        if (Direction)
        Line = Instantiate(LineObject, SpawmPos, Quaternion.identity);
        else
        Line = Instantiate(LineObject, SpawmPos, Quaternion.Euler(Quaternion.identity.x, Quaternion.identity.y, 90));

        SpritLine = Line.GetComponent<SpriteRenderer>();

        if (fromPlayer)
        {
            if(Direction == SaveSequence[spawnPlayerCount])
            {
                SpritLine.color = Color.green;
                Uping = Direction;
                spaceLado = spaceLado + 1.2f;
                spawnPlayerCount++;
            }
            else
            {
                if (Uping && Direction)
                {
                    spaceCima = spaceCima - 1.2f;
                }
                else if (!Uping && !Direction)
                {
                    spaceCima = spaceCima + 1.2f;
                }
                SpritLine.color = Color.red;
                LoseMiniGameEvent();
            }        
        }else
        {
            spaceLado = spaceLado + 1.2f; 
        }

        Line.transform.parent = PlaceHolder.transform;
       
    }

    void CompleteSpawn()
    {
        for(int i = 0; i < SpawnDificult; i++)
        {
            int random = Random.Range(1,100);
            if(random % 2 == 0)
            {
                UpLineSpawner();
            }
            else
            {
                DownLineSpawner();
            }
            Debug.Log(SaveSequence[i]);
        }
    }

    public void ButtonUp()
    {
        LineObjectSpawn(true, true);
    }
    public void ButtonDown()
    {
        LineObjectSpawn(false, true);
    }
    public void Update()
    {
        if (spawnPlayerCount >= SpawnCounter)
        {
            WinMiniGameEvent();
            
        }
    }
    public void WinMiniGameEvent()
    {
        
        PanelWin.SetActive(true);
        ButtonLabManager.TimerStop = true;

        if (passSound)
        {
            passOK.Play(0);
            passSound = false;
        }
        
    }
    public void LoseMiniGameEvent()
    {
        error.Play(0);
        PanelLose.SetActive(true);
        ButtonLabManager.TimerStop = true;
    }
}
