using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxMultiplier; // Kecepatan parallax
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    private void Start()
    {
        // Dapatkan transform kamera utama
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
        // Hitung pergerakan kamera
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;

        // Terapkan pergerakan ke layer ini
        transform.position += new Vector3(deltaMovement.x * parallaxMultiplier.x, deltaMovement.y * parallaxMultiplier.y);

        // Simpan posisi kamera terbaru
        lastCameraPosition = cameraTransform.position;
    }
}
