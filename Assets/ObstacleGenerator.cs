using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject Dinding;
    public float speed = 3f;
    public float spawnRate = 2;
    private float timer = 0;
    public float offset = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;

        if (timer < spawnRate) 
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnWall();
            timer = 0;
        }
    }

    void spawnWall()
    {
        float lowWall = transform.position.y - 2;
        float highWall = transform.position.y + 2;
        Instantiate(Dinding, new Vector3(Random.Range(transform.position.x, transform.position.x + Random.Range(6, 12)), Random.Range(lowWall, highWall), 0), transform.rotation);
    }
}
