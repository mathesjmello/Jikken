using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YanScripts;

public class QuickTime : MonoBehaviour {

   // public Renderer Rend;
    public float FadeDuration;
   // Color colorStart = Color.green;
   // Color colorEnd = Color.red;

    private void Start()
    {
       // Setting();
    }

    void Setting()
    {
      //  Rend = gameObject.GetComponentInChildren<Renderer>();
       // Rend.material.color = Color.green;
    }

    // Update is called once per frame
    void Update ()
    {
       // Debug.Log(Rend.material.color.ToString());
      //  ColorLerp();
        Destroy(gameObject,FadeDuration);
    }

    void ColorLerp()
    {
        //Rend.material.color = Color.Lerp(colorStart, colorEnd, Time.time * FadeDuration /2.5f);
    }

    private void OnDestroy()
    {
        PickUp.Interacting = false;
    }
}
