using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.Translate(deltaMovement * Time.deltaTime * 100f);
        lastCameraPosition = cameraTransform.position;
    }
}
