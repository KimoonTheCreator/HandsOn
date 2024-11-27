using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    bool isGrounded = true; // Menentukan apakah pemain sedang di tanah
    int jumpCount = 0;      // Menghitung jumlah lompatan

<<<<<<< Updated upstream
    public float jumpForce = 10f; // Kekuatan lompatan
=======
    public Transform groundCheck; // Posisi untuk mengecek tanah
    public float groundCheckRadius = 0.2f;// Radius pengecekan tanah

    public Vector2 forwardDirection = Vector2.right; // Arah gerakan maju
    public float thrust = 5f; // Gaya dorong tambahan

    private bool isGrounded = false; // Menentukan apakah pemain sedang di tanah
    private int jumpCount = 0;       // Menghitung jumlah lompatan (maksimal 2)
>>>>>>> Stashed changes

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Ambil komponen Rigidbody2D
    }

    void Update()
    {
<<<<<<< Updated upstream
        // Mengecek input untuk lompatan
        if (Input.GetKeyDown(KeyCode.Space))
=======
        // Mengecek apakah pemain berada di tanah
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Tambahkan gaya dorong terus-menerus
        rb.AddForce(forwardDirection * thrust * Time.deltaTime, ForceMode2D.Force);

        // Lompatan (maksimal 2 kali)
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || jumpCount < 2))
>>>>>>> Stashed changes
        {
            if (isGrounded || jumpCount < 2) // Bisa meloncat jika di tanah atau sudah meloncat sekali
            {
                Jump();
            }
        }
    }

    void Jump()
    {
<<<<<<< Updated upstream
        // Atur ulang kecepatan vertikal untuk mencegah lompatan bertumpuk
        rb.velocity = new Vector2(rb.velocity.x, 0);

        // Tambahkan gaya ke atas
=======
        // Reset kecepatan vertikal sebelum melompat
        rb.velocity = new Vector2(rb.velocity.x, 0);

        // Tambahkan gaya lompatan
>>>>>>> Stashed changes
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        jumpCount++;
<<<<<<< Updated upstream
        isGrounded = false;
=======
>>>>>>> Stashed changes
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Pastikan pemain menyentuh tanah
        if (collision.gameObject.CompareTag("Ground")) // Pastiin tanah atau floor punya tag "Ground"
        {
<<<<<<< Updated upstream
            isGrounded = true;
            jumpCount = 0; // Reset hitungan lompatan
        }
    }
}
=======
            jumpCount = 0; // Reset jumlah lompatan saat menyentuh tanah
        }
    }
}
>>>>>>> Stashed changes
