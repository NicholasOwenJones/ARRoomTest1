using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActGenerator : MonoBehaviour
{
    public StringReference startingPoint;
    public FloatReference point_radius;
    public FloatReference moveSpeed;
    public GameObject[] points;

    public GameObject startPoint;
    public GameObject character1block;
    GameObject character1;

    public int current = 0;



    // Start is called before the first frame update
    void Start()
    {
        //finds the first point to place the first character, places them down and gives them the tag Char1 so they can be located again.
        startPoint = GameObject.Find("point900");
        Instantiate(character1block);
        character1 = GameObject.FindGameObjectWithTag("Char1");
    }

    // Update is called once per frame
    void Update()
    {
        //moves the 1st character to the correct location.
        if (Vector3.Distance(points[current].transform.position, character1.transform.position) < point_radius.Value)
        {
            current++;
            if(current >= points.Length)
            {
                current = 0;
            }
        }
        character1.transform.position = Vector3.MoveTowards(character1.transform.position, points[current].transform.position, Time.deltaTime * moveSpeed.Value);
    }
}
