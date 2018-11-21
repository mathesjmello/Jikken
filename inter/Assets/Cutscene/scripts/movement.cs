using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    Vector3 vecLook = Vector3.zero;
    public GameObject Head;
    float headAngle = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ControlPlayer();
        
        transform.Rotate(Vector3.up, vecLook.y);
        Head.transform.localRotation = Quaternion.Euler(headAngle, 0, 0);
    }

    void ControlPlayer()
    {
        //pego a tecla e salvo no vector
        
        vecLook = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        headAngle += vecLook.x;
        //limite de rotacao da camera;
        headAngle = Mathf.Clamp(headAngle, -70, 70);
    }
}
