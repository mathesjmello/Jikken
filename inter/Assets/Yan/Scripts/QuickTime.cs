using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTime : MonoBehaviour {

    public Material Material;
    public float FadeDuration;
    Color colorStart = Color.green;
    Color colorEnd = Color.red;

	// Update is called once per frame
	void Update () {
        StartCoroutine(preSetup());
        Material.color = Color.Lerp(colorStart, colorEnd, Time.time *FadeDuration);
    }

    IEnumerator preSetup()
    {
        Material.color = colorStart;
        yield return new WaitForSeconds(FadeDuration);
        Destroy(gameObject);
        PickUp.Interacting = false;
        
    }

    private void OnDestroy()
    {
        StopCoroutine(preSetup());
    }
}
