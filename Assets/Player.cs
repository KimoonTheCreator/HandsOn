using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 10f; // Kekuatan lompatan
    public float moveSpeed = 5f;  // Kecepatan bergerak
    public LayerMask groundLayer; // Layer untuk tanah

    private bool isGrounded = false; // Menentukan apakah pemain sedang di tanah
    private int jumpCount = 0;       // Menghitung jumlah lompatan (maksimal 2)
    private Vector2 velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Ambil komponen Rigidbody2D
    }

    void Update()
    {
        // Kontrol horizontal
        float moveInput = Input.GetAxis("Horizontal");
        velocity.x = moveInput * moveSpeed;

        // Lompatan (maksimal 2 kali)
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            Jump();
        }

        // Manual gravitasi (hanya jika tidak di tanah)
        if (!isGrounded)
        {
            velocity.y += Physics2D.gravity.y * Time.deltaTime;
        }

        // Terapkan gerakan ke Rigidbody
        rb.velocity = velocity;
    }

    void Jump()
    {
        // Reset kecepatan vertikal sebelum melompat
        velocity.y = 0;

        // Tambahkan gaya lompatan
        velocity.y = jumpForce;

        // Tambahkan jumlah lompatan
        jumpCount++;
        isGrounded = false; // Pemain tidak lagi di tanah
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            // Reset lompatan saat menyentuh tanah
            isGrounded = true;
            jumpCount = 0;   // Reset jumlah lompatan
            velocity.y = 0;  // Hentikan gerakan vertikal
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = false; // Pemain tidak di tanah
        }
    }
}
