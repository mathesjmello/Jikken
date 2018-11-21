using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    int numero=1;
    //public Transform targetLook;
    Transform path;
    GameObject target;
    Vector3 direcao;
    public float velocity = 10;

    public GameObject[] pontosControle;

    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void LateUpdate()
    {

        for (int i = 0; i < numero; i++)
        {
            target = pontosControle[numero];
            numero++;
            print(numero);

            if (!target) return;
            direcao = (target.transform.position) - transform.position; //subtracao vetorial
            transform.forward = direcao; //aplicando a direcao para o alvo

            //transform.position += direcao * Time.deltaTime * velocity *(float) TimeManager.instance.MyTimeScale;
            transform.position += (direcao - direcao.normalized * target.transform.localScale.magnitude) * Time.deltaTime * velocity; //aplica movimento na camera respeitando o tamanho do planeta 
        }
        
        
    }
}


