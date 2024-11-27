using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_script : MonoBehaviour
{

    /*public float spawn_heightOffset;
    public GameObject Dinding;
    public wall_script Dinding2;
    public float spawnRate;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
        pipe2 = Dinding.GetComponent<pipe_script>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        { 
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }

    private void spawnPipe()
    {
        float maxHeight_spawn = transform.position.y + spawn_heightOffset;
        float minHeight_spawn = transform.position.y - spawn_heightOffset; 

        Instantiate(Dindin, new Vector3 (transform.position.x, Random.Range(maxHeight_spawn, minHeight_spawn)), transform.rotation);
        Debug.Log("Spawn!");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    public void changingSpeed(float speed)
    {
        pipe2.moveSpeed += speed;
    }

    public void restartSpeed()
    {
        pipe2.moveSpeed = 4;
    }*/

}