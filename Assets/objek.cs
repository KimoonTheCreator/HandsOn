using System.Collections;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab; // Prefab meteor yang akan di-instantiate

    private Camera mainCamera; // Referensi ke kamera utama

    private IEnumerator SpawnMeteor()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);

            if (mainCamera == null)
            {
                Debug.LogError("Kamera tidak ditemukan di scene!");
                yield break;
            }

            // Mendapatkan posisi X kamera
            float cameraX = mainCamera.transform.position.x;

            // Posisi spawn meteor (di sebelah kanan kamera, dengan Y acak)
            int randomY = Random.Range(-4, 5);
            Vector2 spawnPosition = new Vector2(cameraX + 5, randomY);

            // Instantiate meteor
            GameObject newMeteor = Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);

            // Memberikan kecepatan ke Rigidbody2D meteor
            Rigidbody2D rb = newMeteor.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.left * 10f; // Kecepatan ke kiri
            }

            // Hancurkan meteor setelah 2 detik
            Destroy(newMeteor, 2f);
        }
    }

    private void Start()
    {
        // Cari kamera menggunakan FindObjectOfType
        mainCamera = FindObjectOfType<Camera>();

        if (mainCamera == null)
        {
            Debug.LogError("Tidak ada kamera di scene. Tambahkan kamera terlebih dahulu!");
            return;
        }

        // Mulai coroutine untuk spawn meteor
        StartCoroutine(SpawnMeteor());
    }
}
