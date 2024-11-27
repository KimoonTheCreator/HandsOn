using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (collision.gameObject.CompareTag("Ground")) // Pastiin tanah atau floor punya tag "Ground"
        {
            isGrounded = true;
            jumpCount = 0; // Reset hitungan lompatan
        }
    }
}