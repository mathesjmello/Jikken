using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ia : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject gotoposition;

    public GameObject cameraCutscene;
    public Transform CameraPosition;
    public Transform CameraTarget;

    bool playerDentro = false;

    void Start()    {
        PlayerPrefs.SetInt("cutscene", 0);
        //cameraCutscene.transform.parent = transform;
        Invoke("CameraCarro", 20);
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        agent.destination = gotoposition.transform.position;
        
    }

    public void CameraCarro()
    {
        PlayerPrefs.SetInt("cutscene", 1);
        
        //cameraCutscene.transform.parent = transform;
        //cameraCutscene.transform.position = new Vector3(CameraPosition.position.x, CameraPosition.position.y, CameraPosition.position.z);
        //cameraCutscene.transform.LookAt(CameraTarget);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "flash")
        {
            playerDentro = true;
            
        }
    }

    public void pararCarro() {
        agent.isStopped = true;
        Invoke("planoB", 5);
    }

    public void planoB() {

        playerDentro = false;
        agent.isStopped = false;


    }

   

}