using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System.Threading;
using UnityEngine.UIElements;

public class meteor : MonoBehaviour
{
    public GameObject go;
    public Rigidbody2D rb;
    public float i = 0f;
    
    // Start is called before the first frame update
    IEnumerator ir()
    {
        while (true)
        {
            i += 7f;
            yield return new WaitForSeconds(2f);
            int y = UnityEngine.Random.Range(-4,5);
            Vector2 pos = new Vector2(i+30, y);
            Instantiate(go, pos, Quaternion.identity);
            rb.velocity = Vector2.left*25f;
            Destroy(go, 2f);
        }
    }
    void Start()
    {
        StartCoroutine(ir());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


// public class meteor : MonoBehaviour
// {
//     public GameObject go;
//     public Rigidbody2D rb;
    
//     // Start is called before the first frame update
//     private IEnumerator ir()
//     {
//         while (true)
//         {
//             float mc = Camera.main.transform.position.x;
//             yield return new WaitForSeconds(2f);
//             int y = UnityEngine.Random.Range(-4,5);
//             Vector2 pos = new Vector2(mc+30, y);
//             Instantiate(go, pos, Quaternion.identity);
//             rb.velocity = Vector2.left*10f;
//             Destroy(go, 2f);
//         }
//     }
//     void Start()
//     {
//         StartCoroutine(ir());
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
