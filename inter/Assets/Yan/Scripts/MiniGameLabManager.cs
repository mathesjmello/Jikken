using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameLabManager : MonoBehaviour {

    public GameObject PlaceHolder,LineObject;

    bool Uping;

    float spaceLado = -1f*3;
    float spaceCima = 0.5f;

    int spawnCaunter = 0;

    private void Start()
    {
        CompleteSpawn();
    }

    public void UpLineSpawner()
    {
        if (spawnCaunter < 2)
        {
            if (Uping)
            {
                spaceCima = spaceCima + 1.2f;
            }
            Vector3 SpawmPos = new Vector3(PlaceHolder.transform.position.x + spaceLado, PlaceHolder.transform.position.y + spaceCima, 0.1f);
            GameObject Line = Instantiate(LineObject, SpawmPos, Quaternion.identity);
            spaceLado = spaceLado + 1.2f;
            Line.transform.parent = PlaceHolder.transform;
            Uping = true;
            spawnCaunter++;
        }
        else
        {
            DownLineSpawner();
        }
    }

    public void DownLineSpawner()
    {
        if (spawnCaunter > -2)
        {
            if (!Uping)
            {
                spaceCima = spaceCima - 1.2f;
            }
            Vector3 SpawmPos = new Vector3(PlaceHolder.transform.position.x + spaceLado, PlaceHolder.transform.position.y + spaceCima, 0.1f);
            GameObject Line = Instantiate(LineObject, SpawmPos, Quaternion.Euler(Quaternion.identity.x, Quaternion.identity.y, 90));
            spaceLado = spaceLado + 1.2f;
            Line.transform.parent = PlaceHolder.transform;
            Uping = false;
            spawnCaunter--;
        }
        else
        {
            UpLineSpawner();
        }
    }

    void CompleteSpawn()
    {
        for(int i = 0; i < 6; i++)
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
        }
    }

}
