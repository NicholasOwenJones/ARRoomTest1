using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActGenerator : MonoBehaviour
{
    public GameObject character1block, character2block;//, choice1, point;

    // Start is called before the first frame update
    void Start()
    {
        //if (point == null)
        //{
        //    point = GameObject.Find("point-508"); 
        //}

        Instantiate(character1block);
        Instantiate(character2block);

        //Instantiate(choice1, point.transform);
    }




















    // Update is called once per frame
    void Update()
    {

    }

    //OLD STUFF
    //public StringReference startingPoint;
    //public FloatReference point_radius;
    //public FloatReference moveSpeed;
    //public GameObject startPoint;
    //GameObject character1;
    //public int current = 0;

    //OLD START STUFF
    //        //finds the first point to place the first character, places them down and gives them the tag Char1 so they can be located again.
    //startPoint = GameObject.Find("point000");

    //character1 = GameObject.FindGameObjectWithTag("Char1");

    //OLD UPDATE STUFF
    //moves the 1st character to the correct location.
    //    if (Vector3.Distance(points[current].transform.position, character1.transform.position) < point_radius.Value)
    //    {
    //        current++;
    //        if(current >= points.Length)
    //        {
    //            current = 0;
    //        }
    //    }
    //    character1.transform.position = Vector3.MoveTowards(character1.transform.position, points[current].transform.position, Time.deltaTime * moveSpeed.Value);

}
