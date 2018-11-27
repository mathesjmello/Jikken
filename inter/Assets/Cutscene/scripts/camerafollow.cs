using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {

    public float sensitivityX = 15F;
    public float sensitivityY = 15F;
    public float minimumX = -90F;
    public float maximumX = 90F;
    public float minimumY = -60F;
    public float maximumY = 60F;
    float rotationY = 0F;
    float rotationX = 0f;

    public GameObject dica;

    void Start()
    {
        Invoke("ligaDica", 22);
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {        
        rotationX += Input.GetAxis("Mouse X") * sensitivityX;
        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }

    public void ligaDica() {
        dica.SetActive(true);
        Invoke("apaga", 5);
    }

    public void apaga() {
        
            dica.SetActive(false);
        

    }
}


