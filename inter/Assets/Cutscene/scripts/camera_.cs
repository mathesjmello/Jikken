using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ : MonoBehaviour
{
    public Transform CameraPosition;
    //public Transform CameraTarget;

    public GameObject target;
    public  Transform target0;
    Vector3 direcao;
    public float velocity = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (PlayerPrefs.GetInt("cutscene") == 1) {
            //transform.parent = transform;
            transform.position = new Vector3(CameraPosition.position.x, CameraPosition.position.y, CameraPosition.position.z);
            transform.LookAt(target0);
            Invoke("desativa", 2);
            /*
            if (!target) return;
            direcao = (target.transform.position) - transform.position; //subtracao vetorial
            transform.forward = direcao; //aplicando a direcao para o alvo

            //transform.position += direcao * Time.deltaTime * velocity *(float) TimeManager.instance.MyTimeScale;
            transform.position += (direcao - direcao.normalized * target.transform.localScale.magnitude) * Time.deltaTime * velocity; //aplica movimento na camera respeitando o tamanho do planeta 
            */
        }
        
    }

    public void desativa() {


        PlayerPrefs.SetInt("cutscene", 0);

    }
}


