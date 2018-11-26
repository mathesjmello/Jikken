using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItenReferences : MonoBehaviour
{

    public GameObject Help;
    public int ItemDifficult;
    public bool HasIcon = false;
    public bool DialogContent=false;

    private void OnTriggerEnter(Collider other)
    {
        Help.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Help.SetActive(false);
    }

    private void OnDestroy()
    {
        Help.SetActive(false);
    }
}
