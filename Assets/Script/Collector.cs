using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private float width = 0f; // Lebar dari satu ground atau ceiling

    void Awake()
    {
        // Dapatkan lebar ground dari salah satu collider
        width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        // Periksa apakah objek yang menyentuh adalah Ground atau Ceiling
        if (target.CompareTag("BG") || target.CompareTag("Ground"))
        {
            // Pindahkan objek yang sudah keluar layar ke depan
            Vector3 temp = target.transform.position;
            temp.x += width * 13; // Pindahkan sejauh 13 lebar ground ke depan
            target.transform.position = temp;
        }
    }
}
