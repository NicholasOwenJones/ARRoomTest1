using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject player;

    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;

    public float diagonalLenth; 

    // Objects that are found in scene.

    public GameObject cube1;

    public GameObject cube2;

    public GameObject centre;

    // Start is called before the first frame update
    void Start()
    {
        centre = GameObject.FindGameObjectWithTag("centre");
        cube1 = GameObject.FindGameObjectWithTag("Cube2");
        cube2 = GameObject.FindGameObjectWithTag("Cube1");
        diagonalLenth = Vector3.Distance(cube1.transform.position, cube2.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
