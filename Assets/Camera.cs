using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new UnityEngine.Vector3(5f * Time.deltaTime, 0, 0);
    }
}
