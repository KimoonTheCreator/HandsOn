using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MapGenerator : MonoBehaviour 
{
    public GameObject PrevCeiling;
    public GameObject PrevFloor;
    public GameObject Ceiling;
    public GameObject Floor;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x > Floor.transform.position.x)
        {
        var tempCeiling = PrevCeiling;
        var tempFloor = PrevFloor;
        PrevCeiling = Ceiling;
        PrevFloor = Floor;
        tempCeiling.transform.position += new UnityEngine.Vector3(80, 0, 0);
        tempFloor.transform.position += new UnityEngine.Vector3(80, 0, 0);
        Ceiling = tempCeiling;
        Floor = tempFloor;
        }
    }
}