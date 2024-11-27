using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Mendapatkan komponen Animator yang terpasang pada GameObject
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Memeriksa apakah tombol Space ditekan
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Memicu animasi jump dengan menggunakan Trigger
            animator.SetTrigger("JumpTrigger");
        }
    }
}
