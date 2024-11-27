using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Tambahkan namespace untuk SceneManager

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    bool isGrounded = true; // Menentukan apakah pemain sedang di tanah
    int jumpCount = 0;      // Menghitung jumlah lompatan

    public float jumpForce = 10f; // Kekuatan lompatan

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Ambil komponen Rigidbody2D
    }

    void Update()
    {
        // Mengecek input untuk lompatan
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded || jumpCount < 2) // Bisa meloncat jika di tanah atau sudah meloncat sekali
            {
                Jump();
            }
        }
    }

    void Jump()
    {
        // Atur ulang kecepatan vertikal untuk mencegah lompatan bertumpuk
        rb.velocity = new Vector2(rb.velocity.x, 0);

        // Tambahkan gaya ke atas
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        jumpCount++;
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Pastikan pemain menyentuh tanah
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0; // Reset hitungan lompatan
        }

        // Periksa apakah pemain menabrak obstacle
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("I touched it!");
            Vector2 collisionNormal = collision.contacts[0].normal;

            if (isCollisionFromTop(collisionNormal))
            {
                Debug.Log("Top"); // Pemain di atas dinding
            }
            else
            {
                Debug.Log("Death, Press R to Restart");
                Time.timeScale = 0f; // Game berhenti
                EnableRestart(); // Game dapat direstart
            }
        }
    }

    private bool isCollisionFromTop(Vector2 collisionNormal)
    {
        return collisionNormal.y > 0.5f;
    }

    private void EnableRestart() // Placeholder death mechanism
    {
        StartCoroutine(CheckForRestart()); // Cek apakah R dipencet
    }

    private System.Collections.IEnumerator CheckForRestart()
    {
        while (!Input.GetKeyDown(KeyCode.R)) // Menunggu input key R
        {
            yield return null;
        }

        RestartGame();
    }

    // Fungsi reset sementara
    private void RestartGame() // Placeholder death mechanism
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}