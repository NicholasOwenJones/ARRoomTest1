using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharacterLocation : MonoBehaviour
{
    [Header("CURRENT POINT TO MOVE TO")]
    public StringReference point; // the current point name to move to sent by director or any other script.

    [Header("WHEN TO UPDATE")]
    public BoolVariable updateIt;


    //private GameObject[] pointsinscene; //If needed I can use this to create an array of points in the scene using FindObjectsWithTag("point") 

    public FloatReference point_radius, moveSpeed; // distance to each point.

    [Space][Header("LEAVE THIS BLANK")] [Tooltip("Leave this blank, only visible for debugging")]
    public GameObject pointToMoveTo; // leave empty. This is used to find the current gameobject point. It is public so I can see it in the editor for debugging.


    // Start is called before the first frame update
    void Start()
    {
        //sets the point to move to if it is empty and finds it in the scene.
        if (pointToMoveTo == null)
        {
                pointToMoveTo = GameObject.Find(point.Value); //finds the point in the scene.
        }
    }

    // Update is called once per frame
    void Update()
    {
        //We need to compare point to gameObjects in scene.
        if (pointToMoveTo.name != point.Value)
        {
            pointToMoveTo = GameObject.Find(point.Value);
        }

        if (Vector3.Distance(pointToMoveTo.transform.position, this.transform.position) < point_radius.Value)
        {
            this.transform.position = this.transform.position;
            updateIt.Value = true;
        }
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, pointToMoveTo.transform.position, Time.deltaTime * moveSpeed.Value);
            updateIt.Value = false;
        }
    }
}
