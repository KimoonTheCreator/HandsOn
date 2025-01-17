using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallscript : MonoBehaviour //script assigned to wall prefab
{
    public float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Killer")) 
        {
            Destroy(gameObject); //wall prefab self destructs in collision with game object tagged 'killer' behind the scene as level slides behind the player
        }
    }
}
