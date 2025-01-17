using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private float objectLength = 29f; // Panjang setiap objek (Ground, Ceiling, dan BG FC)
    private int totalObjects = 14;    // Jumlah total objek
    private float totalWidth = 0f;    // Total panjang dari semua objek

    void Awake()
    {
        // Hitung total panjang berdasarkan jumlah objek
        totalWidth = objectLength * totalObjects;
        Debug.Log($"Total width calculated: {totalWidth}");
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        // Periksa apakah objek yang menyentuh adalah Ground, Ceiling, atau BG FC
        Debug.Log($"Collider detected: {target.name}");

        if (target.CompareTag("Ground") || target.CompareTag("Ceiling") || target.CompareTag("BG FC"))
        {
            // Pindahkan objek yang sudah keluar layar ke depan
            Vector3 temp = target.transform.position;
            temp.x += totalWidth; // Pindahkan sejauh total panjang
            target.transform.position = temp;

            Debug.Log($"{target.name} moved to {temp.x}");
        }
    }
}
