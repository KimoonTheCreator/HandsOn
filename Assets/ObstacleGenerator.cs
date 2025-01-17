using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject Dinding; //Assign prefab Wall
    public float speed = 3f; 
    public float spawnRate = 2; //Spawn rate obstacle (interchangeable)
    private float timer = 0; //Timer resets when obstacle spawns
    //public float offset = 3; REDUNDANT (might still need idk)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position; //Spawn position based on time since game start
        temp.x += speed * Time.deltaTime; 
        transform.position = temp;

        if (timer < spawnRate) 
        {
            timer += Time.deltaTime; 
        }
        else
        {
            spawnWall(); 
            timer = 0; //Timer resets when obstacle spawns
        }
    }

    void spawnWall() //Obstacle spawn function
    {
        float lowWall = transform.position.y - 2; //Obstacle spawn coordinates in y axis(s) (interchangeable)
        float highWall = transform.position.y + 2; 
        Instantiate(Dinding, new Vector3(Random.Range(transform.position.x, transform.position.x + Random.Range(6, 12)), Random.Range(lowWall, highWall), 0), transform.rotation); //Obstacle spawns randomly between low and high state
    }
}
