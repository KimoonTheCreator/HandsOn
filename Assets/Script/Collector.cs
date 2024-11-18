using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Collecter : MonoBehaviour
{   private float width = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        width=GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag=="BG"|| target.tag== "Ground"){
            Vector3 temp = target.transform.position;
            temp.x += width * 13;
            target.transform.position = temp;
    }
 }
}//class