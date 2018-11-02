using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class camera_focus : MonoBehaviour
{

    [SerializeField]
    private LayerMask rayMask;

    [SerializeField]
    private float maxiDistance;

    private RaycastHit hit;

    [SerializeField]
    private Transform depthOfFieldObject;

    private void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hit, maxiDistance, rayMask))
        {
            depthOfFieldObject.position = hit.point;

        }
        else {
            depthOfFieldObject.position = transform.position + transform.forward * maxiDistance * 0.5f;
        }
    }



}
