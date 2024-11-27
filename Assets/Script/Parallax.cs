using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour{
    [SerializeField] private Vector2 parallaxEffectMultiplier;
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    // Start is called before the first frame update
    private void Start()
    {
        Camera foundCamera = FindObjectOfType<Camera>();
    if (foundCamera != null)
    {
        Debug.Log("Found Camera: " + foundCamera.name);
    }
    else
    {
        Debug.LogError("No Camera found in the scene!");
    }

        cameraTransform = FindObjectOfType<Camera>().transform;
        lastCameraPosition = cameraTransform.position; 
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 deltamovement = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3 (deltamovement.x * parallaxEffectMultiplier.x, deltamovement.y *parallaxEffectMultiplier.y);
        lastCameraPosition = cameraTransform.position;
    }
}
