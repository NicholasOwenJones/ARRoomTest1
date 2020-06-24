using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directions : MonoBehaviour
{

    //script for controlling the character from point to point on the stage
    public GameObject character1; //which character to control
    public GameObject[] points; //the array of points the character should move between.
    public float point_radius = 1, moveSpeed; //the radius of each point and the movespeed of the character.
    int current = 0; //the int tracking which point the character is at currently.

    // Start is called before the first frame update
    void Start()
    {
        if (character1 = null)
        {
            character1 = GameObject.FindGameObjectWithTag("Char1");
        }
    }
       
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(points[current].transform.position, character1.transform.position) < point_radius)
        {
            current++; //instead of this you can use current = Random.Range(0,waypoint.Length);
            if (current >= points.Length)
            {
                current = 0;
            }
        }
        character1.transform.position = Vector3.MoveTowards(character1.transform.position, points[current].transform.position, Time.deltaTime * moveSpeed);
    }
}
